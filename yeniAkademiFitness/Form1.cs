using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yeniAkademiFitness.Models;

namespace yeniAkademiFitness
{
    public partial class Form1 : Form
    {
        yeniAkademiFitnessEntities db = new yeniAkademiFitnessEntities();
        public Form1()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            dataGridView1.DataSource = db.uyeler.ToList();
            txtAd.Text = txtSoyad.Text = txtTel.Text = txtTCKN.Text = txtID.Text = txtArama.Text = cBoxUyelikTipi.Text = txtBorcDurumu.Text = null;
            lblKalanGun.Visible = false;
            dtpKayitTarih.Value = dtpBitisTarih.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTCKN.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtpKayitTarih.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            dtpBitisTarih.Value = (DateTime)dataGridView1.CurrentRow.Cells[6].Value;
            cBoxUyelikTipi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBorcDurumu.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            DateTime date = DateTime.Now.Date;
            double kalangun = (dtpBitisTarih.Value - date).TotalDays;
            lblKalanGun.Visible = true;
            lblKalanGun.Text = kalangun.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTel.Text == "" || txtTCKN.Text == "")
            {
                MessageBox.Show("Boş alan bırakmadan doldurun.", "Boş Bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                uyeler uye = new uyeler();
                uye.uyeAd = txtAd.Text;
                uye.uyeSoyad = txtSoyad.Text;
                uye.uyeTelefon = txtTel.Text;
                uye.uyeTCKN = txtTCKN.Text;
                uye.uyeKayitTarih = dtpKayitTarih.Value;
                uye.uyeBitisTarih = dtpBitisTarih.Value;
                uye.uyeUyelikTipi = cBoxUyelikTipi.Text;
                uye.uyeBorcDurumu = txtBorcDurumu.Text;
                db.uyeler.Add(uye);
                db.SaveChanges();
                temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTel.Text == "" || txtTCKN.Text == "")
            {
                MessageBox.Show("Boş alan bırakmadan doldurun.", "Boş Bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                uyeler uye = db.uyeler.FirstOrDefault(x => x.uyeID == id);
                uye.uyeAd = txtAd.Text;
                uye.uyeSoyad = txtSoyad.Text;
                uye.uyeTelefon = txtTel.Text;
                uye.uyeTCKN = txtTCKN.Text;
                uye.uyeBitisTarih = dtpBitisTarih.Value;
                uye.uyeUyelikTipi = cBoxUyelikTipi.Text;
                uye.uyeBorcDurumu = txtBorcDurumu.Text;
                db.SaveChanges();
                temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecek = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            uyeler silinecekUye = db.uyeler.FirstOrDefault(x => x.uyeID == silinecek);
            DialogResult onay = MessageBox.Show($@"ID'si {silinecekUye.uyeID} olan {silinecekUye.uyeAd} {silinecekUye.uyeSoyad} kalıcı olarak silinecek. Bu işlemi yapmak istediğine emin misin?", "Kalıcı Olarak Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                db.uyeler.Remove(silinecekUye);
                db.SaveChanges();
                temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranacak = txtArama.Text;
            uyeler ara = db.uyeler.FirstOrDefault(x => x.uyeAd == aranacak);
            dataGridView1.DataSource = db.uyeler.Where(x => x.uyeAd.Contains(aranacak)).ToList();
        }
    }
}
