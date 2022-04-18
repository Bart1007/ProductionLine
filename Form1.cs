using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSK_Projekt3
{

    public partial class Form1 : Form
    {
        Dictionary<string, string> uzytkownicy = new Dictionary<string, string>();
        int ilosc_prob = 3;
        public Form1()
        {
            InitializeComponent();
            uzytkownicy.Add("admin", "admin");
        }

        private void button_potwierdz_obecnosc(object sender, EventArgs e)
        {
            string login = pole_login.Text;
            string haslo = pole_haslo.Text;
            bool istnienie_uzytkownika = uzytkownicy.ContainsKey(login);

            if (istnienie_uzytkownika)
            {
                if (haslo == uzytkownicy[login])
                {
                    string zalogowano = "Zalogowano pomyślnie!";
                    string tytul = "Zalogowano";
                    MessageBox.Show(zalogowano, tytul);
                    this.Hide();
                    this.okno2 = new Form2(pole_login.Text);
                    this.okno2.ShowDialog();
                    this.Close();

                }
                else if (haslo == "")
                {
                    label4.Text = "Proszę podać hasło";
                }
                else
                {
                    label4.Text = "Podano nieprawidłowe hasło.";
                    label5.Text = "Ilość prób: " + ilosc_prob;
                    ilosc_prob -= 1;

                    if (ilosc_prob < 0)
                    {
                        string zle_haslo = "Trzykrotnie podano złe hasło. Program zostanie wyłączony";
                        string tytul = "Błąd";
                        MessageBox.Show(zle_haslo, tytul);
                        this.Close();
                    }
                }

            }
            else
            {
                label4.Text = "Użytkownik o podanym loginie nie istnieje.";
            }
        }

        private void Zaloguj_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_potwierdz_obecnosc(sender, e);
            }
        }
    }
}
