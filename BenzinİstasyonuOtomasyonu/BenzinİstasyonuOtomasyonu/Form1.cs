using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenzinİstasyonuOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double D_Benzin95 = 0, D_Benzin97 = 0, D_Dizel = 0, D_EuroDizel = 0, D_Lpg = 0;
        double E_Benzin95 = 0, E_Benzin97 = 0, E_Dizel = 0, E_EuroDizel = 0, E_Lpg = 0;
        double F_Benzin95 = 0, F_Benzin97 = 0, F_Dizel = 0, F_EuroDizel = 0, F_Lpg = 0;
        double S_Benzin95 = 0, S_Benzin97 = 0, S_Dizel = 0, S_EuroDizel = 0, S_Lpg = 0;
        String[] depo_bilgileri;
        String[] fiyat_bilgileri;
        private void cBox_fueltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_fueltype.Text == "BENZİN (95)")
            {
                numeric_benzin95.Enabled = true;
                numeric_benzin97.Enabled = false;
                numeric_dizel.Enabled = false;
                numeric_eurodizel.Enabled = false;
                numeric_lpg.Enabled = false;
            }
            else if (cBox_fueltype.Text == "BENZİN (97)")
            {
                numeric_benzin95.Enabled = false;
                numeric_benzin97.Enabled = true;
                numeric_dizel.Enabled = false;
                numeric_eurodizel.Enabled = false;
                numeric_lpg.Enabled = false;
            }
            else if (cBox_fueltype.Text == "DİZEL") 
            {
                numeric_benzin95.Enabled = false;
                numeric_benzin97.Enabled = false;
                numeric_dizel.Enabled = true;
                numeric_eurodizel.Enabled = false;
                numeric_lpg.Enabled = false;
            }
            else if (cBox_fueltype.Text == "EURO DİZEL")
            {
                numeric_benzin95.Enabled = false;
                numeric_benzin97.Enabled = false;
                numeric_dizel.Enabled = false;
                numeric_eurodizel.Enabled = true;
                numeric_lpg.Enabled = false;
            }
            else if (cBox_fueltype.Text == "LPG")
            {
                numeric_benzin95.Enabled = false;
                numeric_benzin97.Enabled = false;
                numeric_dizel.Enabled = false;
                numeric_eurodizel.Enabled = false;
                numeric_lpg.Enabled = true;
            }
            numeric_benzin95.Value = 0;
            numeric_benzin97.Value = 0;
            numeric_dizel.Value = 0;
            numeric_eurodizel.Value = 0;
            numeric_lpg.Value = 0;
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            S_Benzin95 = double.Parse(numeric_benzin95.Value.ToString());
            S_Benzin97 = double.Parse(numeric_benzin97.Value.ToString());
            S_Dizel = double.Parse(numeric_dizel.Value.ToString());
            S_EuroDizel = double.Parse(numeric_eurodizel.Value.ToString());
            S_Lpg = double.Parse(numeric_lpg.Value.ToString());

            if (numeric_benzin95.Enabled == true)
            {
                D_Benzin95 = D_Benzin95 - S_Benzin95;
                lbl_pay.Text = Convert.ToString(F_Benzin95 * S_Benzin95);
            }

            else if (numeric_benzin97.Enabled == true)
            {
                D_Benzin97 = D_Benzin97 - S_Benzin97;
                lbl_pay.Text = Convert.ToString(F_Benzin97 * S_Benzin97);
            }

            else if (numeric_dizel.Enabled == true)
            {
                D_Dizel = D_Dizel - S_Dizel;
                lbl_pay.Text = Convert.ToString(F_Dizel * S_Dizel);
            }

            else if (numeric_eurodizel.Enabled == true)
            {
                D_EuroDizel = D_EuroDizel - S_EuroDizel;
                lbl_pay.Text = Convert.ToString(F_EuroDizel * S_EuroDizel);
            }

            else if (numeric_lpg.Enabled == true)
            {
                D_Lpg = D_Lpg - S_Lpg;
                lbl_pay.Text = Convert.ToString(F_Lpg * S_Lpg);
            }

            depo_bilgileri[0] = Convert.ToString(D_Benzin95);
            depo_bilgileri[1] = Convert.ToString(D_Benzin97);
            depo_bilgileri[2] = Convert.ToString(D_Dizel);
            depo_bilgileri[3] = Convert.ToString(D_EuroDizel);
            depo_bilgileri[4] = Convert.ToString(D_Lpg);

            System.IO.File.WriteAllLines(Application.StartupPath + "\\Depo.txt", depo_bilgileri);
            depo_txt_oku();
            depo_txt_yazdır();
            pBarGüncelle();
            numericMax();

            numeric_benzin95.Value = 0;
            numeric_benzin97.Value = 0;
            numeric_dizel.Value = 0;
            numeric_eurodizel.Value = 0;
            numeric_lpg.Value = 0;

        }

        private void btn_updateprice_Click(object sender, EventArgs e)
        {
            try 
            {
                F_Benzin95 = F_Benzin95 + (F_Benzin95 * Convert.ToDouble(tBox_discountbenzin95.Text) / 100);
                fiyat_bilgileri[0] = Convert.ToString(F_Benzin95);
            }
            catch (Exception e0)
            {
                tBox_discountbenzin95.Text = "Hata";
            }

            try
            {
                F_Benzin97 = F_Benzin97 + (F_Benzin97 * Convert.ToDouble(tBox_discountbenzin97.Text) / 100);
                fiyat_bilgileri[1] = Convert.ToString(F_Benzin97);
            }
            catch (Exception e0)
            {
                tBox_discountbenzin97.Text = "Hata";
            }

            try
            {
                F_Dizel = F_Dizel + (F_Dizel * Convert.ToDouble(tBox_discountdizel.Text) / 100);
                fiyat_bilgileri[2] = Convert.ToString(F_Dizel);
            }
            catch (Exception e0)
            {
                tBox_discountdizel.Text = "Hata";
            }

            try
            {
                F_EuroDizel = F_EuroDizel + (F_EuroDizel * Convert.ToDouble(tBox_discounteurodizel.Text) / 100);
                fiyat_bilgileri[3] = Convert.ToString(F_EuroDizel);
            }
            catch (Exception e0)
            {
                tBox_discounteurodizel.Text = "Hata";
            }

            try
            {
                F_Lpg = F_Lpg + (F_Lpg * Convert.ToDouble(tBox_discountlpg) / 100);
                fiyat_bilgileri[4] = Convert.ToString(F_Lpg);
            }
            catch (Exception e0)
            {
                tBox_discountlpg.Text = "Hata";
            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", fiyat_bilgileri);
            fiyat_txt_oku();
            fiyat_txt_yazdır();
        }

        private void btn_updateinfo_Click(object sender, EventArgs e)
        {
            try
            {
                E_Benzin95 = Convert.ToDouble(tBox_depobenzin95.Text);
                if (E_Benzin95 + D_Benzin95 > 1000 || E_Benzin95 < 0)
                {
                    tBox_depobenzin95.Text = "Hata";
                }
                else
                {
                    depo_bilgileri[0] = Convert.ToString(E_Benzin95 + D_Benzin95);
                }
            }
            catch (Exception e0) 
            {
                tBox_depobenzin95.Text = "Hata";
            }

            try
            {
                E_Benzin97 = Convert.ToDouble(tBox_depobenzin97.Text);
                if (E_Benzin97 + D_Benzin97 > 1000 || E_Benzin97 < 0)
                {
                    tBox_depobenzin97.Text = "Hata";
                }
                else
                {
                    depo_bilgileri[1] = Convert.ToString(E_Benzin97 + D_Benzin97);
                }
            }
            catch (Exception e1)
            {
                tBox_depobenzin97.Text = "Hata";
            }

            try
            {
                E_Dizel = Convert.ToDouble(tBox_depodizel.Text);
                if (E_Dizel + D_Dizel > 1000 || E_Dizel < 0)
                {
                    tBox_depodizel.Text = "Hata";
                }
                else
                {
                    depo_bilgileri[2] = Convert.ToString(E_Dizel + D_Dizel);
                }
            }
            catch (Exception e2)
            {
                tBox_depodizel.Text = "Hata";
            }

            try
            {
                E_EuroDizel = Convert.ToDouble(tBox_depoeurodizel.Text);
                if (E_EuroDizel + D_EuroDizel > 1000 || E_EuroDizel < 0)
                {
                    tBox_depoeurodizel.Text = "Hata";
                }
                else
                {
                    depo_bilgileri[3] = Convert.ToString(E_EuroDizel + D_EuroDizel);
                }
            }
            catch (Exception e3)
            {
                tBox_depoeurodizel.Text = "Hata";
            }

            try
            {
                E_Lpg = Convert.ToDouble(tBox_depolpg.Text);
                if (E_Lpg + D_Lpg > 1000 || E_Lpg < 0)
                {
                    tBox_depolpg.Text = "Hata";
                }
                else
                {
                    depo_bilgileri[4] = Convert.ToString(E_Lpg + D_Lpg);
                }
            }
            catch (Exception e4)
            {
                tBox_depolpg.Text = "Hata";
            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\Depo.txt", depo_bilgileri);
            depo_txt_oku();
            depo_txt_yazdır();
            pBarGüncelle();
            numericMax();
        }
        private void depo_txt_oku() 
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Depo.txt");
            D_Benzin95 = Convert.ToDouble(depo_bilgileri[0]);
            D_Benzin97 = Convert.ToDouble(depo_bilgileri[1]);
            D_Dizel = Convert.ToDouble(depo_bilgileri[2]);
            D_EuroDizel = Convert.ToDouble(depo_bilgileri[3]);
            D_Lpg = Convert.ToDouble(depo_bilgileri[4]);
        }

        private void depo_txt_yazdır()
        {
            lbl_depobenzin95.Text = D_Benzin95.ToString("N");
            lbl_depobenzin97.Text = D_Benzin97.ToString("N");
            lbl_depodizel.Text = D_Dizel.ToString("N");
            lbl_depoeurodizel.Text = D_EuroDizel.ToString("N");
            lbl_depolpg.Text = D_Lpg.ToString("N");
        }

        private void fiyat_txt_oku()
        {
            fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Fiyat.txt");
            F_Benzin95 = Convert.ToDouble(fiyat_bilgileri[0]);
            F_Benzin97 = Convert.ToDouble(fiyat_bilgileri[1]);
            F_Dizel = Convert.ToDouble(fiyat_bilgileri[2]);
            F_EuroDizel = Convert.ToDouble(fiyat_bilgileri[3]);
            F_Lpg = Convert.ToDouble(fiyat_bilgileri[4]);
        }

        private void fiyat_txt_yazdır()
        {
            lbl_discountbenzin95.Text = F_Benzin95.ToString("N");
            lbl_discountbenzin97.Text = F_Benzin97.ToString("N");
            lbl_discountdizel.Text = F_Dizel.ToString("N");
            lbl_discounteurodizel.Text = F_EuroDizel.ToString("N");
            lbl_discountlpg.Text = F_Lpg.ToString("N");
        }

        private void pBarGüncelle()
        {
            pBar_benzin95.Value = Convert.ToInt32(D_Benzin95);
            pBar_benzin97.Value = Convert.ToInt32(D_Benzin97);
            pBar_dizel.Value = Convert.ToInt32(D_Dizel);
            pBar_eurodizel.Value = Convert.ToInt32(D_EuroDizel);
            pBar_lpg.Value = Convert.ToInt32(D_Lpg);
        }

        private void numericMax()
        {
            numeric_benzin95.Maximum = decimal.Parse(D_Benzin95.ToString());
            numeric_benzin97.Maximum = decimal.Parse(D_Benzin97.ToString());
            numeric_dizel.Maximum = decimal.Parse(D_Dizel.ToString());
            numeric_eurodizel.Maximum = decimal.Parse(D_EuroDizel.ToString());
            numeric_lpg.Maximum = decimal.Parse(D_Lpg.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Akaryakıt Otomasyonu";
            depo_txt_oku();
            depo_txt_yazdır();
            fiyat_txt_oku();
            fiyat_txt_yazdır();
            pBarGüncelle();
            numericMax();

            String[] yakit_turleri = { "BENZİN (95)", "BENZİN (97)", "DİZEL", "EURO DİZEL", "LPG" };
            cBox_fueltype.Items.AddRange(yakit_turleri);
            numeric_benzin95.Enabled = false;
            numeric_benzin97.Enabled = false;
            numeric_dizel.Enabled = false;
            numeric_eurodizel.Enabled = false;
            numeric_lpg.Enabled = false;

            numeric_benzin95.DecimalPlaces = 2;
            numeric_benzin97.DecimalPlaces = 2;
            numeric_dizel.DecimalPlaces = 2;
            numeric_eurodizel.DecimalPlaces = 2;
            numeric_lpg.DecimalPlaces = 2;

            numeric_benzin95.Increment = 0.1M;
            numeric_benzin97.Increment = 0.1M;
            numeric_dizel.Increment = 0.1M;
            numeric_eurodizel.Increment = 0.1M;
            numeric_lpg.Increment = 0.1M;

            numeric_benzin95.ReadOnly = true;
            numeric_benzin97.ReadOnly = true;
            numeric_dizel.ReadOnly = true;
            numeric_eurodizel.ReadOnly = true;
            numeric_lpg.ReadOnly = true;
        }
    }
}
