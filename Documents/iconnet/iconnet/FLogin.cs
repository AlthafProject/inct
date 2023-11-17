using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconnet
{
    public partial class FLogin : Form
    {
        data.iconnet db = new data.iconnet();
        ErrorProvider errorProvider = new ErrorProvider();
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
            var login = db.Users.FirstOrDefault(l => l.kode_admin == tbkode.Text &&
            l.Password == tbpassword.Text);

                if (!Regex.IsMatch(tbkode.Text, "^[0-9]{2,}$"))
                {
                    errorProvider.SetError(tbkode, "please input your kode admin valid");
                }

                if (login != null)
            {
                data.global.name = login.FullName;
                this.Hide();
                FBeranda fBeranda = new FBeranda();
                fBeranda.Show();
            }
            else
            {
                MessageBox.Show("login gagal", @"Error");
             }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
