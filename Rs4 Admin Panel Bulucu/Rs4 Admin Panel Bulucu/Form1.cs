using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Rs4_Admin_Panel_Bulucu
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void onay_button_Click(object sender, EventArgs e)
        {
            string site = site_giris_text.Text.Trim();
            if (site == "")
            {
                MessageBox.Show("Lütfen Site Alan Adı Giriniz!", "Uyarı!");
            }
            else 
            {
                if (full_radio.Checked)
                {
                    using (var f = new StreamReader("full.txt"))
                    {
                        while (true)
                        {
                            string satir = f.ReadLine();
                            if (satir == null)
                            {
                                MessageBox.Show("Admin Panel Bulunanamadı Maleseff!", "Uyarı!");
                            }
                            else 
                            {
                                gecmis_label.Text = satir;
                                try
                                {
                                    WebRequest request = WebRequest.Create("https://" + site + "/" + satir);
                                    string tarama = "https://" + site + "/" + satir;
                                    request.Proxy = WebRequest.GetSystemWebProxy();
                                    HttpWebResponse ilk_yanit = (HttpWebResponse)request.GetResponse();
                                    string yanit = Convert.ToString(ilk_yanit);
                                    if (yanit == "System.Net.HttpWebResponse")
                                    {
                                        goster_textbox.Text += tarama+"\n";
                                        ilk_yanit.Close();
                                        MessageBox.Show("Admin Panel Bulundu!", "Uyarı!");
                                    }
                                }
                                catch
                                {}
                            }
                        }
                    }
                }
                else
                {
                    using (var f = new StreamReader("fast.txt"))
                    {
                        while (true)
                        { 
                            string satir = f.ReadLine();
                            if (satir == null)
                            {
                                MessageBox.Show("Admin Panel Bulunanamadı Maleseff!", "Uyarı!");
                            }
                            else
                            {
                                gecmis_label.Text = satir;
                                try
                                {
                                    WebRequest request = WebRequest.Create("https://" + site + "/" + satir);
                                    string tarama = "https://" + site + "/" + satir;
                                    request.Proxy = WebRequest.GetSystemWebProxy();
                                    HttpWebResponse ilk_yanit = (HttpWebResponse)request.GetResponse();
                                    string yanit = Convert.ToString(ilk_yanit);
                                    if (yanit == "System.Net.HttpWebResponse")
                                    {
                                        goster_textbox.Text += tarama+"\n";
                                        ilk_yanit.Close();
                                        MessageBox.Show("Admin Panel Bulundu!", "Uyarı!");
                                    }
                                }
                                catch
                                {}
                            }
                        }
                    }
                }
            }
        }

        private void durdur_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Durduruldu", "Uyarı!");
        }

        private void temizle_button_Click(object sender, EventArgs e)
        {
            goster_textbox.Text = "";
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Sadece Alan adını girin\nörnek: rusygame.com, elitehackz.org\nSağ tarafdan hızlı veya full modu isteğinize göre seçin", "Help!");
        }
    }
}