using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;

namespace SQLLiteMerger
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker _backgroundWorker;
        private const string fileFilter = "Sqlite Files (*.sqlite3,*.sqlite,*.db)|*.sqlite3;*.sqlite;*.db|RootMagic File (*.rmgc)|*.rmgc|All files (*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.ProgressChanged += _backgroundWorker_ProgressChanged;
        }

        private void _backgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbl_Progress.Text = e.UserState?.ToString();
        }

        private void _backgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(getOutputFile()))
            {
                return;
            }

            using (var connection = new SQLiteConnection($"Data Source={getOutputFile()}"))
            {
                connection.Open();
                var fileNames = getInputFiles();
                foreach (var file in fileNames)
                {
                    ReadSqlLiteFile(file, connection);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = fileFilter;
            openFileDialog1.ShowDialog();
            foreach (var fileName in openFileDialog1.FileNames)
            {
                listBox_InputFiles.Items.Add(fileName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var elems = listBox_InputFiles.SelectedItems.Cast<string>().ToList();
            foreach (var item in elems)
            {
                listBox_InputFiles.Items.Remove(item);
            } 
        }

        private void btn_SelectOutputFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = fileFilter;
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.ShowDialog();
            txt_OutputFile.Text = saveFileDialog1.FileName;
        }

        private string[] getInputFiles()
        {
            return listBox_InputFiles.Items.Cast<string>().ToArray();
        }

        private string getOutputFile()
        {
            return txt_OutputFile.Text;
        }

        private void ReadSqlLiteFile(string filename, SQLiteConnection dConnection)
        {
            using (var connection = new SQLiteConnection($"Data Source={filename}"))
            {
                connection.Open();
                var tableNames = getTableNames(connection);
                var dTableNames = getTableNames(dConnection);

                var progress = 0;

                foreach (var tableName in tableNames)
                {
                    progress++;
                    _backgroundWorker.ReportProgress((int)(100.0 * progress / tableNames.Count), $"Processing {tableName}");
                    if (!dTableNames.Contains(tableName))
                    {
                        var command = connection.CreateCommand();
                        command.CommandText = $"SELECT sql FROM sqlite_master WHERE tbl_name = '{tableName}';";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var result = reader.GetString(0);
                                result = result.Replace("COLLATE RMNOCASE", "");
                                runCommand(result, dConnection);
                            }
                        }
                    }

                    var readTableContentsCommand = connection.CreateCommand();
                    readTableContentsCommand.CommandText = $"Select * FROM {tableName}";
                    using (var tableReader = readTableContentsCommand.ExecuteReader())
                    {
                        while (tableReader.Read())
                        {
                            var values = "";
                            for (int i = 0; i < tableReader.FieldCount; i++)
                            {
                                var value = tableReader.GetValue(i);
                                var valuestr = string.Empty;

                                if (value is byte[])
                                {
                                    valuestr = ByteArrayToString((byte[])value);
                                    valuestr = $"X'{valuestr}'";
                                }
                                else if (value is string)
                                {
                                    valuestr = value.ToString()?.Replace("'", "''");
                                    valuestr = $"'{valuestr}'";
                                }
                                else
                                {
                                    valuestr = value.ToString();
                                }

                                values += valuestr;

                                if (i + 1 < tableReader.FieldCount)
                                {
                                    values += ", ";
                                }
                            }
                            var insertStatement = $"INSERT INTO {tableName} VALUES ({values});";
                            runCommand(insertStatement, dConnection);
                        }
                    }
                }

                connection.Close();
            }
        }

        private void runCommand(string cmd, SQLiteConnection connection)
        {
            var command = new SQLiteCommand(connection);
            command.CommandText = cmd;
            command.ExecuteNonQuery();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        private List<string> getTableNames(SQLiteConnection connection)
        {
            var tableNames = new List<string>();
            var command = connection.CreateCommand();
            command.CommandText =
                    @"
                        SELECT name FROM sqlite_schema 
                        WHERE type IN ('table','view') 
                        AND name NOT LIKE 'sqlite_%'
                        ORDER BY 1;
                    ";
            //command.Parameters.AddWithValue("$id", id);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var tableName = reader.GetString(0);
                    tableNames.Add(tableName);
                }
            }

            return tableNames;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _backgroundWorker.RunWorkerAsync();
        }
    }
}