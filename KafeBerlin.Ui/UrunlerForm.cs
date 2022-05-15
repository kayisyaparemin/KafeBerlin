using KafeBerlin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeBerlin.Ui
{
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }

        private void UrunEkle()
        {
            if (txtUrunAd.Text.Length > 0)
            {
                if (nudBirimFiyat.Value > 0)
                {
                    Urun urun = new Urun();
                    urun.UrunAd = txtUrunAd.Text;
                    urun.BirimFiyat = nudBirimFiyat.Value;
                    AnaForm.db.Urunler.Add(urun);
                    MessageBox.Show("Urun Ekledi");
                }
                else
                {
                    MessageBox.Show("Birim fiyat 0 dan farklı olmalıdır!");
                }
                
            }
            else
            {
                MessageBox.Show("Eklenecek Ürün adı boş olamaz!");
            }
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
        }

        }
    }

