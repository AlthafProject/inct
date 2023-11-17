using iconnet.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iconnet
{
    public partial class FView : Form
    {
        data.iconnet db = new data.iconnet();
        public FView()
        {
            InitializeComponent();

            load();
        }

        public void load()
        {
            var data = db.onlines.Where(m => m.DeletedAt == null).Select(u => new
            {
                id = u.ID,
                nik = u.Nik,
                name = u.Name,
                nometeran = u.kdmeteran,
                nohp = u.Nohp,
                email = u.Email,
                alamat = u.alamat,
                kelurahan = u.kelurahan,
                kecamatan = u.kecamatan,
                kabupaten = u.kota,
                titikkor = u.lokasi,
                layanan = u.layanan,
                proses = u.process,
                created = u.CreatedAt
            }).ToList();

            dataGridView1.DataSource = data;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBeranda fb = new FBeranda();
            fb.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var data = db.onlines.Where(d => d.Name.Contains(textBox1.Text)).Select(u => new
            {
                id = u.ID,
                nik = u.Nik,
                name = u.Name,
                nometeran = u.kdmeteran,
                nohp = u.Nohp,
                email = u.Email,
                alamat = u.alamat,
                kelurahan = u.kelurahan,
                kecamatan = u.kecamatan,
                kabupaten = u.kota,
                titikkor = u.lokasi,
                layanan = u.layanan,
                proses = u.process,
                created = u.CreatedAt
            }).ToList();

            dataGridView1.DataSource = data;
        }

        Dictionary<int, bool> checkBoxStates = new Dictionary<int, bool>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Action"].Index)
                {
                    // Mengambil nilai id dari kolom "idcollumn"
                    int customerId;
                    if (dataGridView1.Rows[e.RowIndex].Cells["idcollumn"].Value != null &&
                        int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["idcollumn"].Value.ToString(), out customerId))
                    {
                        var customer = db.onlines.Find(customerId);
                        if (customer != null)
                        {
                            if (MessageBox.Show("Anda Yakin Ingin Menghapus Data Tersebut?", @"Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                try
                                {
                                    // Uncomment if you want to delete the record immediately
                                    db.onlines.Remove(customer);
                                    db.SaveChanges();

                                    /*  var soft = new data.online
                                      {
                                          DeletedAt = DateTime.Now
                                      };

                                      db.onlines.Add(soft);
                                      db.SaveChanges();*/
                                }
                                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                                {
                                    foreach (var validationErrors in ex.EntityValidationErrors)
                                    {
                                        foreach (var validationError in validationErrors.ValidationErrors)
                                        {
                                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                                        }
                                    }

                                    // Handle the validation errors as needed
                                }
                            }

                            load(); // Move the load() outside the if-else block
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.");
                            load(); // Move the load() here to ensure it's called in both cases
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID data tidak valid.");
                    }
                }

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["proccess"].Index)
            {
                // Mengambil nilai id dari kolom "idcollumn"
                int customerId;
                if (dataGridView1.Rows[e.RowIndex].Cells["idcollumn"].Value != null &&
                    int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["idcollumn"].Value.ToString(), out customerId))
                {
                    var customer = db.onlines.Find(customerId);
                    if (customer != null)
                    {
                        if (MessageBox.Show("Apakah Anda Sudah Cek Data Pelanggan?", @"Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                // Update existing 'customer' instead of creating a new 'dataset'
                                customer.process = "Success";
                                db.SaveChanges();

                                load();
                            }
                            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                            {
                                foreach (var validationErrors in ex.EntityValidationErrors)
                                {
                                    foreach (var validationError in validationErrors.ValidationErrors)
                                    {
                                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                                    }
                                }

                                // Handle the validation errors as needed
                            }
                        }
                    }
                }
            }

        }
    }
}
    



 

