using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Interop;

namespace dogShelter
{
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();

            //dataGridView.Rows.Add("9:00", "10:00", "14:00", "18:00", "19:00");
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            var fr = new FoodCalculator();
            fr.ShowDialog();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                                                                Data Source='C:\programming\Timesheet.xlsx'
                                                                ;Extended Properties='Excel 12.0;HDR=YES';");
            OleDbDataAdapter myAdapter = new OleDbDataAdapter("Select * from [sheet1$]", myConnection);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 90, 94);
            dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 134, 137);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(161, 96, 98);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.BackgroundColor = Color.FromArgb(224, 90, 94);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(161, 96, 98);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(161, 96, 98);
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.Columns[0].DefaultCellStyle.Format = "H:mm";
            //dataGridView.Rows[0].Cells[0].Value = "8:00";
            //dataGridView.FirstDisplayedCell = "a";


            myConnection.Close();
        }
    }
}
