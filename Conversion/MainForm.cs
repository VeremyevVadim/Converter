using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NbrbAPI.Models;
using Newtonsoft.Json;

namespace Conversion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();  
        }

        private Rate[] rate;

        private bool getCurrencies()
        {
            string rateRequest = "http://www.nbrb.by/api/exrates/rates?periodicity=0";

            StreamReader stream = null;
            try
            {
                // Get currencies
                System.Net.HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(rateRequest);
                System.Net.HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                string response;
                stream = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                response = stream.ReadToEnd();
               
                Rate[] temp = JsonConvert.DeserializeObject<Rate[]>(response);
                rate = new Rate[temp.Length + 1];
                temp.CopyTo(rate, 0);

                rate[rate.Length - 1] = new Rate { Cur_ID = 0, Cur_Scale = 1, Cur_OfficialRate = 1M, Cur_Name = "Белорусский рубль" };

                return true;
            }
            catch (WebException)
            {
                MessageBox.Show("Ошибка подключения к НБРБ. Проверьте Ваше интернет соединение.");
                return false;
            }
            catch (JsonException)
            {
                MessageBox.Show("Ошибка десериализации.");
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка чтения ответа от НБРБ.");
                return false;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
             }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (getCurrencies())
            {
                initializeComponents();
            }
        }

        private void initializeComponents()
        {
            foreach (Rate currency in rate)
            {
                cbSourceCurrency.Items.Add(currency.Cur_Name);
                cbDestCurrency.Items.Add(currency.Cur_Name);
            }

            btnReconnect.Enabled = false;
            btnConvert.Enabled = true;
            lblConnected.Text = "Подключение установлено.";

            if (cbSourceCurrency.Items.Count > 0)
            {
                cbSourceCurrency.SelectedIndex = 0;
                cbDestCurrency.SelectedIndex = 0;
            }
        }

        private void btnReconnect_Click(object sender, EventArgs e)
        {
            if (getCurrencies())
            {
                initializeComponents();
            }
        }

        private void tbDestCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и точка
            {
                e.Handled = true;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal src;

            try
            {
                CultureInfo cultures = new CultureInfo("en-US");

                src = Convert.ToDecimal(tbSourceCurrency.Text, cultures);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат чисел.");
                return;
            }

            Rate srcRate = rate[cbSourceCurrency.SelectedIndex];
            Rate destRate = rate[cbDestCurrency.SelectedIndex];
            decimal? result;

            try
            {
                result = (src / srcRate.Cur_Scale * srcRate.Cur_OfficialRate) / destRate.Cur_OfficialRate * destRate.Cur_Scale;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("В ходе расчёта произошло деление на ноль.");
                return;
            }
            tbDestCurrency.Text = string.Format("{0:F2}", result);
        }
    }
}
