using System;
using System.Windows.Forms;

namespace POSK_Projekt3
{
    public partial class Form2 : Form
    {
        int czas_obecnosci = 30;
        int minuta = 0;
        Random rnd = new Random();

        /* indeksy:
        0, 1 - rdzen1
        2, 3 - rdzen2
        4, 5 - rdzen3
        6, 7 - rdzen4
        8, 9 - zuzycie procesora
        10, 11 - temperatura proceosora */

        int[] parametry = new int[12] { 20, 60, 30, 70, 30, 40, 60, 80, 40, 80, 70, 80 };
        int a;
        int b;
        string[] wentylator = new string[2] { "wyłączone", "włączone" };
        int reset_wentylatorow = 0;

        public Form2(string uzytkownik)
        {
            InitializeComponent();
            label_zalogowano_jako.Text = "Zalogowano jako: " + uzytkownik;
            textBox_wentylatory.Text = wentylator[0];
        }

        private void timer_czas(object sender, EventArgs e)    //wyswietla aktualna date i czas
        {
            label_czas_data.Text = "Czas i data: " + DateTime.Now.ToString("dddd, dd.MM.yyyy, HH:mm:ss");
            int minuta = DateTime.Now.Second;
        }

        private void timer_minuta_Tick(object sender, EventArgs e)  //odlicza minute - obecnosc
        {
            if (minuta >= 60)
            {
                timer_obecnosc.Enabled = true;
                button1.Enabled = true;
            }
            minuta += 1;
        }

        public void timer_obecnosc_Tick(object sender, EventArgs e) //odlicza 30 sekund na potwierdzenie obecnosci
        {
            if (czas_obecnosci % 2 == 0)
            {
                button1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                button1.BackColor = System.Drawing.Color.White;
            }
            if (czas_obecnosci <= 0)
            {
                this.Hide();
                timer_obecnosc.Enabled = false;
                timer_minuta.Enabled = false;
                string wylogowanie = "Nie potwierdzono obecności przy stanowisku pracy. Nastąpiło wylogowanie z systemu.";
                string tytul = "Wylogowanie";
                MessageBox.Show(wylogowanie, tytul);
                this.Close();
            }
            label_obecnosc.Text = "Zostało " + czas_obecnosci + " sek";
            czas_obecnosci -= 1;

        }

        private void button_potwierdz_obecnosc(object sender, EventArgs e)  //potwierdza obecnosc dyspozytora
        {
            minuta = 0;
            czas_obecnosci = 30;
            button1.BackColor = System.Drawing.Color.White;
            timer_obecnosc.Enabled = false;
            button1.Enabled = false;
            label_obecnosc.Text = "";
        }

        private void button_zamknij_Click(object sender, EventArgs e)  //wylogowanie i zamkniecie programu
        {
            this.Hide();
            timer_obecnosc.Enabled = false;
            timer_minuta.Enabled = false;
            string wylogowanie = "Pomyślnie wylogowano i zamknięto program.";
            string tytul = "Wylogowanie";
            MessageBox.Show(wylogowanie, tytul);
            this.Close();
        }

        private void timer_parametrow(object sender, EventArgs e)   //kontrola parametrow (co sekunde)
        {
            progressBar_rdzen1.Value = rnd.Next(parametry[0], parametry[1]);
            progressBar_rdzen2.Value = rnd.Next(parametry[2], parametry[3]);
            progressBar_rdzen3.Value = rnd.Next(parametry[4], parametry[5]);
            progressBar_rdzen4.Value = rnd.Next(parametry[6], parametry[7]);
            progressBar_procesor.Value = rnd.Next(parametry[8], parametry[9]);
            int zmiana_temperatury = rnd.Next(parametry[10], parametry[11]);
            reset_wentylatorow += 1;

            if (reset_wentylatorow == 5)
            {
                textBox_wentylatory.BackColor = System.Drawing.Color.White;
                textBox_wentylatory.Text = wentylator[0];
                reset_wentylatorow = 0;
            }

            if (progressBar_rdzen1.Value >= 80 || progressBar_rdzen2.Value >= 80
                || progressBar_rdzen3.Value >= 80 || progressBar_rdzen4.Value >= 80)  //sprawdzenie rdzeni
            {

                label_ostrzezenie_rdzen.Text = "Zużycie rdzeni: ponad normę";
                label_ostrzezenie_rdzen.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                label_ostrzezenie_rdzen.Text = "Zużycie rdzeni: w normie";
                label_ostrzezenie_rdzen.ForeColor = System.Drawing.Color.Black;
            }

            if (progressBar_procesor.Value >= 80)    //sprawdzenie zużycia procesora
            {
                label_ostrzezenie_pamiec.Text = "Zużycie pamięci: ponad normę!";
                label_ostrzezenie_pamiec.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label_ostrzezenie_pamiec.Text = "Zużycie pamięci: w normie";
                label_ostrzezenie_pamiec.ForeColor = System.Drawing.Color.Black;
            }
            if (zmiana_temperatury >= 80)  //sprawdzenie temperatury
            {
                textBox_temperatura.Text = "ponad normę!";
                textBox_temperatura.BackColor = System.Drawing.Color.Red;
                label_ostrzezenie_temp.Text = "Temperatura: ponad normę!";
                label_ostrzezenie_temp.ForeColor = System.Drawing.Color.Red;
                button_wlacz_wentylatory.Enabled = true;
            }
            else
            {
                textBox_temperatura.Text = "normalna";
                textBox_temperatura.BackColor = System.Drawing.Color.White;
                label_ostrzezenie_temp.Text = "Temperatura: w normie";
                label_ostrzezenie_temp.ForeColor = System.Drawing.Color.Black;
                button_wlacz_wentylatory.Enabled = false;
            }
        }

        private void timer_zdarzenie_losowe_Tick(object sender, EventArgs e)    //wywolywanie zdarzenia losowego (co 10 sek)
        {
            int losowy = 2 * rnd.Next(6);

            if (parametry[losowy] < 80)
            {
                parametry[losowy] = 80;
                parametry[losowy + 1] = 100;
            }
        }

        private void button_zmiensz_zuzycie(object sender, EventArgs e)    //zmniejsza zuzycie wybranego rdzenia lub procesora
        {
            Button buttoon = (Button)sender;
            switch (buttoon.Text[6].ToString())
            {
                case "1":
                    a = 0;
                    b = 1;
                    break;

                case "2":
                    a = 2;
                    b = 3;
                    break;

                case "3":
                    a = 4;
                    b = 5;
                    break;

                case "4":
                    a = 6;
                    b = 7;
                    break;

                case "s":
                    a = 8;
                    b = 9;
                    break;
            }
            parametry[a] = rnd.Next(20, 40);
            parametry[b] = rnd.Next(40, 80);
        }

        private void button_wlacz_wentylatory_Click(object sender, EventArgs e) //wlacza wentylator / obniza temperature
        {
            textBox_wentylatory.BackColor = System.Drawing.Color.LightGreen;
            textBox_wentylatory.Text = wentylator[1];
            parametry[10] -= 20;
            parametry[11] -= 20;
        }
    }
}
