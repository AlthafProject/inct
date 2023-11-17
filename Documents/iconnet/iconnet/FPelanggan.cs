using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconnet
{
    public partial class FPelanggan : Form
    {
        data.iconnet db = new data.iconnet();
        public FPelanggan()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
/*
            if (!Regex.IsMatch(tbemail.Text, "^[a-zA-Z0-9]+@[a-zA-Z]+/.[a-zA-Z]{2,}$"))
            if (!Regex.IsMatch(tbnik.Text, "^[0-9]{2,}$"))
            if (!Regex.IsMatch(tbnohp.Text, "^[0-9]{2,}$"))
            if (!Regex.IsMatch(tbmeteran.Text, "^[0-9]{2,}$"))*/
                try
                {
                    var customer = new data.online
                    {
                        Nik = int.TryParse(tbnik.Text, out var nikValue) ? nikValue : 0,
                        Name = tbname.Text,
                        kdmeteran = int.TryParse(tbmeteran.Text, out var meteranvalue) ? meteranvalue : 0,
                        Nohp = int.TryParse(tbnohp.Text, out var nohpvalue) ? nohpvalue : 0,
                        Email = tbemail.Text,
                        alamat = tbalamat.Text,
                        kelurahan = tbkelurahan.Text,
                        kecamatan = tbkecamatan.Text,
                        kota = tbkabupaten.Text,
                        lokasi = tblokasi.Text,
                        CreatedAt = DateTime.Now,
                        DeletedAt = null,
                        process = "Proccess"
                    };

                    if (cbduapuluh.Checked)
                    {
                        customer.layanan = cbduapuluh.Text;
                    }
                    else if (cbtigalima.Checked)
                    {
                        customer.layanan = cbtigalima.Text;
                    }
                    else if (cblimapuluh.Checked)
                    {
                        customer.layanan = cblimapuluh.Text;
                    }
                    else if (cbseratus.Checked)
                    {
                        customer.layanan = cbseratus.Text;
                    }

                    db.onlines.Add(customer);
                    db.SaveChanges();

                    MessageBox.Show("data berhasil di input", @"success");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                    // Handle the validation error as needed.
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBeranda fBeranda = new FBeranda();
            fBeranda.Show();
        }
    }
}
