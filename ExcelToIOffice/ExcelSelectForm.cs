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
    public partial class ExcelSelectForm : Form
    {
        public ExcelSelectForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        class SheetComboItem
        {
            public int ID { get; set; }
            public string SheetName { get; set; }
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Source Excel File";
            openFileDialog.Filter = "Excel files|*.xls;*.xlsx|All files|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                FileText.Text = file;

                ExcelManager em = ExcelManager.Instance;
                em.openFile(file);
                string[] sheetNames = em.getSheets();

                SheetComboItem[] datasource  = new SheetComboItem[sheetNames.Length];
                int i = 1;
                foreach(string sheetName in sheetNames)
                {
                    datasource[i-1] = new SheetComboItem { ID = i, SheetName = sheetName };
                    i++;
                }
                SheetDropdown.ValueMember = "ID";
                SheetDropdown.DisplayMember = "SheetName";
                SheetDropdown.DataSource = datasource;
            }
            else
            {
                //TODO
                //Do nothing?  Might need to clear sheet select stuff
            }
        }

        private void SheetDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            int excelIndex = SheetDropdown.SelectedIndex + 1;
            ExcelManager.Instance.SetActiveSheet(excelIndex);
            MappingForm mappingForm = new MappingForm();
            mappingForm.Location = this.Location;
            mappingForm.Size = this.Size;
            mappingForm.Show();
            this.Hide();

        }
    }
}
