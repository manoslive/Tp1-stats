using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace tp1_echantillonnage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_ChoisirFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChoixFichier = new OpenFileDialog();
            if(ChoixFichier.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Open(ChoixFichier.FileName);
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                int rowsCount = worksheet.UsedRange.Rows.Count;

                //Initializing Columns
                DGV_Population.ColumnCount = worksheet.UsedRange.Columns.Count;
                for (int x = 0; x < DGV_Population.ColumnCount; x++)
                {
                    DGV_Population.Columns[x].Name = "Column " + x.ToString();
                }

                for (int i=0; i < rowsCount; i++)
                {
                    //dataGridView1.Rows[i].Cells["Column1"].Value = worksheet.Cells[i + 1, 1].Value;
                    //dataGridView1.Rows[i].Cells["Column2"].Value = worksheet.Cells[i + 1, 2].Value;
                    DGV_Population.Rows.Add(worksheet.Cells[i + 1, 1].Value, worksheet.Cells[i + 1, 2].Value);
                }
            }
        }
    }
}
