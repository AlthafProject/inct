using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconnet
{
    public partial class FBeranda : Form
    {
        public FBeranda()
        {
            InitializeComponent();

            Load += (e, args) =>
            {
                btnpelanggan.Click += (o, EventArgs) =>
                {
                    direct(typeof(FPelanggan));
                };
                btnview.Click += (o, EventArgs) =>
                {
                    direct(typeof(FView));
                };
                btnlog.Click += (o, EventArgs) =>
                {
                    direct(typeof(FLogin));
                };
            };
        }

        private void FBeranda_Load(object sender, EventArgs e)
        {
            lblname.Text = data.global.name;
            timer1.Start();
        }

        private void direct(Type type)
        {
            var form = (Form)Activator.CreateInstance(type);
            form.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss");
        }
    }
}
