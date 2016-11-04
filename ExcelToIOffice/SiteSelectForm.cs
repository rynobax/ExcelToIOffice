using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ExcelToIOffice
{
    public partial class SiteSelectForm : Form
    {
        public SiteSelectForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            string URL = SiteText.Text;
            if(URL.Length > 8 && URL.Substring(0, 7) != "http://" && URL.Substring(0, 8) != "https://")
            {
                URL = "http://" + URL;
            }
            NetworkManager nm = new NetworkManager(UsernameText.Text, PasswordText.Text, URL);
            string user = "";
            try
            {
                user = nm.SendGetUsersRequest(1, 0);
            }
            catch(UriFormatException ex)
            {
                MessageBox.Show("The URL " + SiteText.Text + " is invalid.  Change it and try again", "URL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        if ((int)response.StatusCode == 401)
                        {
                            MessageBox.Show("Account info was rejected, change the info and try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not complete request, error was " + (int)response.StatusCode + ".", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Something terrible has happened.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            IOfficeHelper.Instance.getAllDatabaseFieldsFromJson(user);

            var excelSelectForm = new ExcelSelectForm();
            excelSelectForm.Location = this.Location;
            excelSelectForm.Size = this.Size;
            excelSelectForm.Show();
            this.Hide();
        }

        private void SiteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiteLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
