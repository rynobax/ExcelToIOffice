using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToIOffice
{
    public partial class MappingForm : Form
    {
        class ExcelComboItem
        {
            public int ID { get; set; }
            public string ExcelHeader { get; set; }
        }

        class DatabaseComboItem
        {
            public int ID { get; set; }
            public string DatabaseField { get; set; }
            public string ReadableName { get; set; }
        }

        public MappingForm()
        {
            InitializeComponent();

            /* Get values for excel dropdown */
            object[,] sheetValues = ExcelManager.Instance.getWholeSheet();
            int headerCount = sheetValues.GetLength(1);
            ExcelComboItem[] excelDatasource = new ExcelComboItem[headerCount];
            for (int col = 1; col <= sheetValues.GetLength(1); ++col)
            {
                //get header values
                string value = sheetValues[1, col].ToString();
                excelDatasource[col - 1] = new ExcelComboItem { ID = col, ExcelHeader = value };
            }
            excelDropdown.ValueMember = "ID";
            excelDropdown.DisplayMember = "ExcelHeader";
            excelDropdown.DataSource = excelDatasource;


            /* Get values for database dropdown */
            List<IOfficeHelper.DBField> fields = IOfficeHelper.Instance.getDBFields();
            DatabaseComboItem[] databaseDatasource = new DatabaseComboItem[fields.Count];
            int i = 0;
            foreach(var field in fields)
            {
                databaseDatasource[i] = new DatabaseComboItem { ID = i, DatabaseField = field.dbname, ReadableName = field.readableName };
                i++;
            }
            databaseDropdown.ValueMember = "ID";
            databaseDropdown.DisplayMember = "ReadableName";
            databaseDropdown.DataSource = databaseDatasource;
        }

        private void SelectTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addRelationButton_Click(object sender, EventArgs e)
        {
            /* Add it to the list */
            DatabaseComboItem dbSelectedItem = (DatabaseComboItem)databaseDropdown.SelectedItem;
            ExcelComboItem excelSelectedItem = (ExcelComboItem)excelDropdown.SelectedItem;
            TableLayoutPanel t = new TableLayoutPanel();
            t.ColumnCount = 2;
            t.RowCount = 1;
            t.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            t.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            t.Controls.Add(new Label { Text = excelSelectedItem.ExcelHeader });
            t.Controls.Add(new Label { Text = dbSelectedItem.ReadableName });
            t.AutoSize = true;
            AddedFlowPanel.Controls.Add(t);

            /* Remove the choices from the dropdown */
            ExcelComboItem[] oldExcelDatasource = (ExcelComboItem[]) excelDropdown.DataSource;
            ExcelComboItem[] newExcelDatasource = new ExcelComboItem[oldExcelDatasource.Length - 1];

            int i = 0;
            foreach(ExcelComboItem item in oldExcelDatasource)
            {
                if(item.ID != excelSelectedItem.ID)
                {
                    newExcelDatasource[i] = item;
                    i++;
                }
            }

            DatabaseComboItem[] oldDatabaseDatasource = (DatabaseComboItem[])databaseDropdown.DataSource;
            DatabaseComboItem[] newDatabaseDatasource = new DatabaseComboItem[oldDatabaseDatasource.Length - 1];

            i = 0;
            foreach (DatabaseComboItem item in oldDatabaseDatasource)
            {
                if (item.ID != dbSelectedItem.ID)
                {
                    newDatabaseDatasource[i] = item;
                    i++;
                }
            }

            excelDropdown.DataSource = newExcelDatasource;
            databaseDropdown.DataSource = newDatabaseDatasource;
        }
    }
}
