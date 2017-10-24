using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Grace Su, October 2017
//Copyright(c) GVative LLC.All rights reserved.
/// <summary>
/// This program allows user to open a CSV, TSV or any customizable delimiter seperated data file in a gridview to view, edit and save it free. Users do not 
/// have to have Excel or other software to open a CSV or TSV file that is very commonly used to store data.
/// It is optional have the first row as a column header (must have same column number across all rows).
/// Future expansion could include graphing the data in 2D or 3D view to help user to visaulize data.
/// </summary>

namespace CSVFileGridEditor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            comboBoxDelimiters.SelectedIndex = 0;
        }

        Char delimiter = ',';
        String ExtensionName = "CSV";
        String FileFilter=  "CSV Files (*.csv)|*.csv";
        private void comboBoxDelimiters_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDelimiters.SelectedIndex)
            {
                case 0:
                    delimiter = ',';
                    ExtensionName = "CSV";
                    FileFilter = "CSV Files (*.csv)|*.csv";
                    break;
                case 1:
                    delimiter = ';';
                    ExtensionName = "SSV";
                    FileFilter = "Semicolon seperated Files (*.ssv)|*.ssv";
                    break;
                case 2:
                    delimiter = '\t';
                    ExtensionName = "TSV";
                    FileFilter = "Tab seperated Files (*.tsv)|*.tsv";
                    break;
                case 3:
                    delimiter = ' ';
                    ExtensionName = "WSV";
                    FileFilter = "White space seperated Files (*.wsv)|*.wsv";
                    break;
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fdlg = new OpenFileDialog();
            Fdlg.Filter = FileFilter;
            if (Fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string csvPath = Fdlg.FileName;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                if (System.IO.File.Exists(csvPath))
                {
                    System.IO.StreamReader fileReader = new System.IO.StreamReader(csvPath, false);
                    String FirstRow = fileReader.ReadLine();
                    String[] ColumnNames = FirstRow.Split(delimiter);
                    dataGridView1.ColumnCount = ColumnNames.Length;
                    dataGridView1.ColumnHeadersVisible = true;

                    // Set the column header style.
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                    columnHeaderStyle.BackColor = Color.Beige;
                    columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                    dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                    if (checkBoxFirstRowIsHeader.Checked)
                    {
                        for (int i = 0; i < ColumnNames.Length; i++)
                        {
                            dataGridView1.Columns[i].Name = ColumnNames[i];
                        }
                    }
                    //Reading Data
                    while (fileReader.Peek() != -1)
                    {
                        String fileRow = fileReader.ReadLine();
                        String[] fileDataField = fileRow.Split(delimiter);
                        dataGridView1.Rows.Add(fileDataField);
                    }
                    fileReader.Dispose();
                    fileReader.Close();
                }

            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = FileFilter;
            dlg.DefaultExt = ExtensionName;
            dlg.AddExtension = true;
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName, false);
                if (checkBoxFirstRowIsHeader.Checked)
                {
                    int NonEmptyColumnNameCount = 0;
                    String strHeaders = String.Empty;
                    for (int m = 0; m < dataGridView1.ColumnCount; m++)
                    {
                        if(!String.IsNullOrWhiteSpace(dataGridView1.Columns[m].Name))
                            NonEmptyColumnNameCount++;
                        strHeaders += dataGridView1.Columns[m].Name;
                        if (m < dataGridView1.ColumnCount - 1)
                            strHeaders += delimiter;
                    }
                    if (NonEmptyColumnNameCount > 0)
                        writer.WriteLine(strHeaders);
                }

                for (int i=0;i< dataGridView1.RowCount;i++)
                {
                    String strLine = String.Empty;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            strLine += dataGridView1.Rows[i].Cells[j].Value.ToString();
                            if (j < dataGridView1.ColumnCount - 1)
                                strLine += delimiter;
                        }
                        else
                            break;
                    }
                    writer.WriteLine(strLine);
                }
                writer.Close();
                writer.Dispose();
            }
        }


    }
}
