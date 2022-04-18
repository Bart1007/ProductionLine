
namespace POSK_Projekt3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.napis_stanowisko = new System.Windows.Forms.Label();
            this.label_zalogowano_jako = new System.Windows.Forms.Label();
            this.label_czas_data = new System.Windows.Forms.Label();
            this.timer_aktualny_czas = new System.Windows.Forms.Timer(this.components);
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.groupBox_obecnosc = new System.Windows.Forms.GroupBox();
            this.label_obecnosc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer_minuta = new System.Windows.Forms.Timer(this.components);
            this.timer_obecnosc = new System.Windows.Forms.Timer(this.components);
            this.groupBox_parametry = new System.Windows.Forms.GroupBox();
            this.textBox_temperatura = new System.Windows.Forms.TextBox();
            this.textBox_wentylatory = new System.Windows.Forms.TextBox();
            this.progressBar_procesor = new System.Windows.Forms.ProgressBar();
            this.progressBar_rdzen1 = new System.Windows.Forms.ProgressBar();
            this.progressBar_rdzen2 = new System.Windows.Forms.ProgressBar();
            this.progressBar_rdzen3 = new System.Windows.Forms.ProgressBar();
            this.progressBar_rdzen4 = new System.Windows.Forms.ProgressBar();
            this.label_dod_wentylatory = new System.Windows.Forms.Label();
            this.label_zuzycie_pamieci = new System.Windows.Forms.Label();
            this.label_temperatura = new System.Windows.Forms.Label();
            this.label_wykorzystanie_rdzeni = new System.Windows.Forms.Label();
            this.label_rdzen3 = new System.Windows.Forms.Label();
            this.label_rdzen4 = new System.Windows.Forms.Label();
            this.label_rdzen2 = new System.Windows.Forms.Label();
            this.label_rdzen1 = new System.Windows.Forms.Label();
            this.groupBox_kontrola = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_zmniejsz_pamiec = new System.Windows.Forms.Button();
            this.button_zmniejsz_rdzen1 = new System.Windows.Forms.Button();
            this.button_zmniejsz_rdzen2 = new System.Windows.Forms.Button();
            this.button_zmniejsz_rdzen3 = new System.Windows.Forms.Button();
            this.button_zmniejsz_rdzen4 = new System.Windows.Forms.Button();
            this.button_wlacz_wentylatory = new System.Windows.Forms.Button();
            this.groupBox_ostrzezenia = new System.Windows.Forms.GroupBox();
            this.label_ostrzezenie_temp = new System.Windows.Forms.Label();
            this.label_ostrzezenie_pamiec = new System.Windows.Forms.Label();
            this.label_ostrzezenie_rdzen = new System.Windows.Forms.Label();
            this.button_zamknij = new System.Windows.Forms.Button();
            this.timer_rdzen1 = new System.Windows.Forms.Timer(this.components);
            this.timer_zdarzenie_losowe = new System.Windows.Forms.Timer(this.components);
            this.groupBox_info.SuspendLayout();
            this.groupBox_obecnosc.SuspendLayout();
            this.groupBox_parametry.SuspendLayout();
            this.groupBox_kontrola.SuspendLayout();
            this.groupBox_ostrzezenia.SuspendLayout();
            this.SuspendLayout();
            // 
            // napis_stanowisko
            // 
            this.napis_stanowisko.AutoSize = true;
            this.napis_stanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napis_stanowisko.Location = new System.Drawing.Point(8, 9);
            this.napis_stanowisko.MinimumSize = new System.Drawing.Size(700, 30);
            this.napis_stanowisko.Name = "napis_stanowisko";
            this.napis_stanowisko.Size = new System.Drawing.Size(700, 30);
            this.napis_stanowisko.TabIndex = 0;
            this.napis_stanowisko.Text = "Stanowisko dyspozytorskie linii produkcyjnej";
            this.napis_stanowisko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_zalogowano_jako
            // 
            this.label_zalogowano_jako.AutoSize = true;
            this.label_zalogowano_jako.Location = new System.Drawing.Point(6, 22);
            this.label_zalogowano_jako.Name = "label_zalogowano_jako";
            this.label_zalogowano_jako.Size = new System.Drawing.Size(118, 16);
            this.label_zalogowano_jako.TabIndex = 1;
            this.label_zalogowano_jako.Text = "Zalogowano jako: ";
            // 
            // label_czas_data
            // 
            this.label_czas_data.AutoSize = true;
            this.label_czas_data.Location = new System.Drawing.Point(6, 42);
            this.label_czas_data.Name = "label_czas_data";
            this.label_czas_data.Size = new System.Drawing.Size(77, 16);
            this.label_czas_data.TabIndex = 2;
            this.label_czas_data.Text = "Czas i data:";
            // 
            // timer_aktualny_czas
            // 
            this.timer_aktualny_czas.Enabled = true;
            this.timer_aktualny_czas.Interval = 500;
            this.timer_aktualny_czas.Tick += new System.EventHandler(this.timer_czas);
            // 
            // groupBox_info
            // 
            this.groupBox_info.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_info.Controls.Add(this.label_zalogowano_jako);
            this.groupBox_info.Controls.Add(this.label_czas_data);
            this.groupBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_info.Location = new System.Drawing.Point(12, 60);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(346, 69);
            this.groupBox_info.TabIndex = 3;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Informacje";
            // 
            // groupBox_obecnosc
            // 
            this.groupBox_obecnosc.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox_obecnosc.Controls.Add(this.label_obecnosc);
            this.groupBox_obecnosc.Controls.Add(this.button1);
            this.groupBox_obecnosc.Controls.Add(this.textBox1);
            this.groupBox_obecnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_obecnosc.Location = new System.Drawing.Point(13, 135);
            this.groupBox_obecnosc.Name = "groupBox_obecnosc";
            this.groupBox_obecnosc.Size = new System.Drawing.Size(345, 132);
            this.groupBox_obecnosc.TabIndex = 4;
            this.groupBox_obecnosc.TabStop = false;
            this.groupBox_obecnosc.Text = "Potwierdzanie obecności";
            // 
            // label_obecnosc
            // 
            this.label_obecnosc.AutoSize = true;
            this.label_obecnosc.Location = new System.Drawing.Point(65, 98);
            this.label_obecnosc.Name = "label_obecnosc";
            this.label_obecnosc.Size = new System.Drawing.Size(0, 16);
            this.label_obecnosc.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(174, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Potwierdź obecność!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_potwierdz_obecnosc);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCoral;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(333, 70);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Jako dyspozytor musisz potwierdzać swoją obecność co minutę. Na wciśnięcie podświ" +
    "etlonego przyciusku masz 30 sekund. Po tym czasie zostaniesz wylogowany z system" +
    "u.";
            // 
            // timer_minuta
            // 
            this.timer_minuta.Enabled = true;
            this.timer_minuta.Interval = 1000;
            this.timer_minuta.Tick += new System.EventHandler(this.timer_minuta_Tick);
            // 
            // timer_obecnosc
            // 
            this.timer_obecnosc.Interval = 1000;
            this.timer_obecnosc.Tick += new System.EventHandler(this.timer_obecnosc_Tick);
            // 
            // groupBox_parametry
            // 
            this.groupBox_parametry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox_parametry.Controls.Add(this.textBox_temperatura);
            this.groupBox_parametry.Controls.Add(this.textBox_wentylatory);
            this.groupBox_parametry.Controls.Add(this.progressBar_procesor);
            this.groupBox_parametry.Controls.Add(this.progressBar_rdzen1);
            this.groupBox_parametry.Controls.Add(this.progressBar_rdzen2);
            this.groupBox_parametry.Controls.Add(this.progressBar_rdzen3);
            this.groupBox_parametry.Controls.Add(this.progressBar_rdzen4);
            this.groupBox_parametry.Controls.Add(this.label_dod_wentylatory);
            this.groupBox_parametry.Controls.Add(this.label_zuzycie_pamieci);
            this.groupBox_parametry.Controls.Add(this.label_temperatura);
            this.groupBox_parametry.Controls.Add(this.label_wykorzystanie_rdzeni);
            this.groupBox_parametry.Controls.Add(this.label_rdzen3);
            this.groupBox_parametry.Controls.Add(this.label_rdzen4);
            this.groupBox_parametry.Controls.Add(this.label_rdzen2);
            this.groupBox_parametry.Controls.Add(this.label_rdzen1);
            this.groupBox_parametry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox_parametry.Location = new System.Drawing.Point(365, 60);
            this.groupBox_parametry.Name = "groupBox_parametry";
            this.groupBox_parametry.Size = new System.Drawing.Size(343, 207);
            this.groupBox_parametry.TabIndex = 5;
            this.groupBox_parametry.TabStop = false;
            this.groupBox_parametry.Text = "Parametry elementów komputera linii produkcyjnej";
            // 
            // textBox_temperatura
            // 
            this.textBox_temperatura.BackColor = System.Drawing.Color.White;
            this.textBox_temperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_temperatura.Location = new System.Drawing.Point(182, 157);
            this.textBox_temperatura.Name = "textBox_temperatura";
            this.textBox_temperatura.ReadOnly = true;
            this.textBox_temperatura.Size = new System.Drawing.Size(100, 22);
            this.textBox_temperatura.TabIndex = 14;
            this.textBox_temperatura.Text = "normalna";
            this.textBox_temperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wentylatory
            // 
            this.textBox_wentylatory.BackColor = System.Drawing.Color.White;
            this.textBox_wentylatory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_wentylatory.Location = new System.Drawing.Point(182, 97);
            this.textBox_wentylatory.Name = "textBox_wentylatory";
            this.textBox_wentylatory.ReadOnly = true;
            this.textBox_wentylatory.Size = new System.Drawing.Size(100, 22);
            this.textBox_wentylatory.TabIndex = 13;
            this.textBox_wentylatory.Text = "wyłączone";
            this.textBox_wentylatory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar_procesor
            // 
            this.progressBar_procesor.BackColor = System.Drawing.Color.White;
            this.progressBar_procesor.Location = new System.Drawing.Point(182, 43);
            this.progressBar_procesor.Name = "progressBar_procesor";
            this.progressBar_procesor.Size = new System.Drawing.Size(100, 15);
            this.progressBar_procesor.TabIndex = 12;
            // 
            // progressBar_rdzen1
            // 
            this.progressBar_rdzen1.BackColor = System.Drawing.Color.White;
            this.progressBar_rdzen1.Location = new System.Drawing.Point(9, 72);
            this.progressBar_rdzen1.Name = "progressBar_rdzen1";
            this.progressBar_rdzen1.Size = new System.Drawing.Size(100, 15);
            this.progressBar_rdzen1.TabIndex = 11;
            // 
            // progressBar_rdzen2
            // 
            this.progressBar_rdzen2.BackColor = System.Drawing.Color.White;
            this.progressBar_rdzen2.Location = new System.Drawing.Point(9, 109);
            this.progressBar_rdzen2.Name = "progressBar_rdzen2";
            this.progressBar_rdzen2.Size = new System.Drawing.Size(100, 15);
            this.progressBar_rdzen2.TabIndex = 10;
            // 
            // progressBar_rdzen3
            // 
            this.progressBar_rdzen3.BackColor = System.Drawing.Color.White;
            this.progressBar_rdzen3.Location = new System.Drawing.Point(9, 145);
            this.progressBar_rdzen3.Name = "progressBar_rdzen3";
            this.progressBar_rdzen3.Size = new System.Drawing.Size(100, 15);
            this.progressBar_rdzen3.TabIndex = 9;
            // 
            // progressBar_rdzen4
            // 
            this.progressBar_rdzen4.BackColor = System.Drawing.Color.White;
            this.progressBar_rdzen4.Location = new System.Drawing.Point(9, 182);
            this.progressBar_rdzen4.Name = "progressBar_rdzen4";
            this.progressBar_rdzen4.Size = new System.Drawing.Size(100, 15);
            this.progressBar_rdzen4.TabIndex = 8;
            // 
            // label_dod_wentylatory
            // 
            this.label_dod_wentylatory.AutoSize = true;
            this.label_dod_wentylatory.Location = new System.Drawing.Point(179, 78);
            this.label_dod_wentylatory.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label_dod_wentylatory.Name = "label_dod_wentylatory";
            this.label_dod_wentylatory.Size = new System.Drawing.Size(150, 16);
            this.label_dod_wentylatory.TabIndex = 7;
            this.label_dod_wentylatory.Text = "Dodatkowe wentylatory:";
            // 
            // label_zuzycie_pamieci
            // 
            this.label_zuzycie_pamieci.AutoSize = true;
            this.label_zuzycie_pamieci.Location = new System.Drawing.Point(179, 22);
            this.label_zuzycie_pamieci.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label_zuzycie_pamieci.Name = "label_zuzycie_pamieci";
            this.label_zuzycie_pamieci.Size = new System.Drawing.Size(108, 16);
            this.label_zuzycie_pamieci.TabIndex = 6;
            this.label_zuzycie_pamieci.Text = "Zużycie pamięci:";
            // 
            // label_temperatura
            // 
            this.label_temperatura.AutoSize = true;
            this.label_temperatura.Location = new System.Drawing.Point(179, 134);
            this.label_temperatura.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label_temperatura.Name = "label_temperatura";
            this.label_temperatura.Size = new System.Drawing.Size(154, 16);
            this.label_temperatura.TabIndex = 5;
            this.label_temperatura.Text = "Temperatura procesora:";
            // 
            // label_wykorzystanie_rdzeni
            // 
            this.label_wykorzystanie_rdzeni.AutoSize = true;
            this.label_wykorzystanie_rdzeni.Location = new System.Drawing.Point(6, 22);
            this.label_wykorzystanie_rdzeni.Name = "label_wykorzystanie_rdzeni";
            this.label_wykorzystanie_rdzeni.Size = new System.Drawing.Size(138, 16);
            this.label_wykorzystanie_rdzeni.TabIndex = 4;
            this.label_wykorzystanie_rdzeni.Text = "Wykorzystanie rdzeni:";
            // 
            // label_rdzen3
            // 
            this.label_rdzen3.AutoSize = true;
            this.label_rdzen3.Location = new System.Drawing.Point(6, 127);
            this.label_rdzen3.Margin = new System.Windows.Forms.Padding(0);
            this.label_rdzen3.Name = "label_rdzen3";
            this.label_rdzen3.Size = new System.Drawing.Size(60, 16);
            this.label_rdzen3.TabIndex = 3;
            this.label_rdzen3.Text = "Rdzeń 3:";
            // 
            // label_rdzen4
            // 
            this.label_rdzen4.AutoSize = true;
            this.label_rdzen4.Location = new System.Drawing.Point(6, 163);
            this.label_rdzen4.Margin = new System.Windows.Forms.Padding(0);
            this.label_rdzen4.Name = "label_rdzen4";
            this.label_rdzen4.Size = new System.Drawing.Size(60, 16);
            this.label_rdzen4.TabIndex = 2;
            this.label_rdzen4.Text = "Rdzeń 4:";
            // 
            // label_rdzen2
            // 
            this.label_rdzen2.AutoSize = true;
            this.label_rdzen2.Location = new System.Drawing.Point(6, 90);
            this.label_rdzen2.Margin = new System.Windows.Forms.Padding(0);
            this.label_rdzen2.Name = "label_rdzen2";
            this.label_rdzen2.Size = new System.Drawing.Size(60, 16);
            this.label_rdzen2.TabIndex = 1;
            this.label_rdzen2.Text = "Rdzeń 2:";
            // 
            // label_rdzen1
            // 
            this.label_rdzen1.AutoSize = true;
            this.label_rdzen1.Location = new System.Drawing.Point(6, 53);
            this.label_rdzen1.Margin = new System.Windows.Forms.Padding(0);
            this.label_rdzen1.Name = "label_rdzen1";
            this.label_rdzen1.Size = new System.Drawing.Size(60, 16);
            this.label_rdzen1.TabIndex = 0;
            this.label_rdzen1.Text = "Rdzeń 1:";
            // 
            // groupBox_kontrola
            // 
            this.groupBox_kontrola.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox_kontrola.Controls.Add(this.label9);
            this.groupBox_kontrola.Controls.Add(this.button_zmniejsz_pamiec);
            this.groupBox_kontrola.Controls.Add(this.button_zmniejsz_rdzen1);
            this.groupBox_kontrola.Controls.Add(this.button_zmniejsz_rdzen2);
            this.groupBox_kontrola.Controls.Add(this.button_zmniejsz_rdzen3);
            this.groupBox_kontrola.Controls.Add(this.button_zmniejsz_rdzen4);
            this.groupBox_kontrola.Controls.Add(this.button_wlacz_wentylatory);
            this.groupBox_kontrola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox_kontrola.Location = new System.Drawing.Point(13, 273);
            this.groupBox_kontrola.Name = "groupBox_kontrola";
            this.groupBox_kontrola.Size = new System.Drawing.Size(461, 144);
            this.groupBox_kontrola.TabIndex = 6;
            this.groupBox_kontrola.TabStop = false;
            this.groupBox_kontrola.Text = "Kontrola parametrów";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Zmniejsz zużycie rdzenia:";
            // 
            // button_zmniejsz_pamiec
            // 
            this.button_zmniejsz_pamiec.Location = new System.Drawing.Point(288, 15);
            this.button_zmniejsz_pamiec.Name = "button_zmniejsz_pamiec";
            this.button_zmniejsz_pamiec.Size = new System.Drawing.Size(167, 51);
            this.button_zmniejsz_pamiec.TabIndex = 5;
            this.button_zmniejsz_pamiec.Text = "Zmniejsz zużycie pamięci procesora";
            this.button_zmniejsz_pamiec.UseVisualStyleBackColor = true;
            this.button_zmniejsz_pamiec.Click += new System.EventHandler(this.button_zmiensz_zuzycie);
            // 
            // button_zmniejsz_rdzen1
            // 
            this.button_zmniejsz_rdzen1.Location = new System.Drawing.Point(23, 57);
            this.button_zmniejsz_rdzen1.Name = "button_zmniejsz_rdzen1";
            this.button_zmniejsz_rdzen1.Size = new System.Drawing.Size(75, 23);
            this.button_zmniejsz_rdzen1.TabIndex = 4;
            this.button_zmniejsz_rdzen1.Text = "Rdzeń 1";
            this.button_zmniejsz_rdzen1.UseVisualStyleBackColor = true;
            this.button_zmniejsz_rdzen1.Click += new System.EventHandler(this.button_zmiensz_zuzycie);
            // 
            // button_zmniejsz_rdzen2
            // 
            this.button_zmniejsz_rdzen2.Location = new System.Drawing.Point(23, 86);
            this.button_zmniejsz_rdzen2.Name = "button_zmniejsz_rdzen2";
            this.button_zmniejsz_rdzen2.Size = new System.Drawing.Size(75, 23);
            this.button_zmniejsz_rdzen2.TabIndex = 3;
            this.button_zmniejsz_rdzen2.Text = "Rdzeń 2";
            this.button_zmniejsz_rdzen2.UseVisualStyleBackColor = true;
            this.button_zmniejsz_rdzen2.Click += new System.EventHandler(this.button_zmiensz_zuzycie);
            // 
            // button_zmniejsz_rdzen3
            // 
            this.button_zmniejsz_rdzen3.Location = new System.Drawing.Point(103, 57);
            this.button_zmniejsz_rdzen3.Name = "button_zmniejsz_rdzen3";
            this.button_zmniejsz_rdzen3.Size = new System.Drawing.Size(75, 23);
            this.button_zmniejsz_rdzen3.TabIndex = 2;
            this.button_zmniejsz_rdzen3.Text = "Rdzeń 3";
            this.button_zmniejsz_rdzen3.UseVisualStyleBackColor = true;
            this.button_zmniejsz_rdzen3.Click += new System.EventHandler(this.button_zmiensz_zuzycie);
            // 
            // button_zmniejsz_rdzen4
            // 
            this.button_zmniejsz_rdzen4.Location = new System.Drawing.Point(103, 86);
            this.button_zmniejsz_rdzen4.Name = "button_zmniejsz_rdzen4";
            this.button_zmniejsz_rdzen4.Size = new System.Drawing.Size(75, 23);
            this.button_zmniejsz_rdzen4.TabIndex = 1;
            this.button_zmniejsz_rdzen4.Text = "Rdzeń 4";
            this.button_zmniejsz_rdzen4.UseVisualStyleBackColor = true;
            this.button_zmniejsz_rdzen4.Click += new System.EventHandler(this.button_zmiensz_zuzycie);
            // 
            // button_wlacz_wentylatory
            // 
            this.button_wlacz_wentylatory.Enabled = false;
            this.button_wlacz_wentylatory.Location = new System.Drawing.Point(286, 86);
            this.button_wlacz_wentylatory.Name = "button_wlacz_wentylatory";
            this.button_wlacz_wentylatory.Size = new System.Drawing.Size(169, 51);
            this.button_wlacz_wentylatory.TabIndex = 0;
            this.button_wlacz_wentylatory.Text = "Włącz dodatkowe wentylatory";
            this.button_wlacz_wentylatory.UseVisualStyleBackColor = true;
            this.button_wlacz_wentylatory.Click += new System.EventHandler(this.button_wlacz_wentylatory_Click);
            // 
            // groupBox_ostrzezenia
            // 
            this.groupBox_ostrzezenia.BackColor = System.Drawing.Color.White;
            this.groupBox_ostrzezenia.Controls.Add(this.label_ostrzezenie_temp);
            this.groupBox_ostrzezenia.Controls.Add(this.label_ostrzezenie_pamiec);
            this.groupBox_ostrzezenia.Controls.Add(this.label_ostrzezenie_rdzen);
            this.groupBox_ostrzezenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_ostrzezenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox_ostrzezenia.Location = new System.Drawing.Point(480, 273);
            this.groupBox_ostrzezenia.Name = "groupBox_ostrzezenia";
            this.groupBox_ostrzezenia.Size = new System.Drawing.Size(228, 103);
            this.groupBox_ostrzezenia.TabIndex = 7;
            this.groupBox_ostrzezenia.TabStop = false;
            this.groupBox_ostrzezenia.Text = "OSTRZEŻENIA";
            // 
            // label_ostrzezenie_temp
            // 
            this.label_ostrzezenie_temp.AutoSize = true;
            this.label_ostrzezenie_temp.Location = new System.Drawing.Point(15, 72);
            this.label_ostrzezenie_temp.Name = "label_ostrzezenie_temp";
            this.label_ostrzezenie_temp.Size = new System.Drawing.Size(145, 16);
            this.label_ostrzezenie_temp.TabIndex = 2;
            this.label_ostrzezenie_temp.Text = "Temperatura: w normie";
            // 
            // label_ostrzezenie_pamiec
            // 
            this.label_ostrzezenie_pamiec.AutoSize = true;
            this.label_ostrzezenie_pamiec.Location = new System.Drawing.Point(15, 52);
            this.label_ostrzezenie_pamiec.Name = "label_ostrzezenie_pamiec";
            this.label_ostrzezenie_pamiec.Size = new System.Drawing.Size(164, 16);
            this.label_ostrzezenie_pamiec.TabIndex = 1;
            this.label_ostrzezenie_pamiec.Text = "Zużycie pamięci: w normie";
            // 
            // label_ostrzezenie_rdzen
            // 
            this.label_ostrzezenie_rdzen.AutoSize = true;
            this.label_ostrzezenie_rdzen.Location = new System.Drawing.Point(15, 32);
            this.label_ostrzezenie_rdzen.Name = "label_ostrzezenie_rdzen";
            this.label_ostrzezenie_rdzen.Size = new System.Drawing.Size(152, 16);
            this.label_ostrzezenie_rdzen.TabIndex = 0;
            this.label_ostrzezenie_rdzen.Text = "Zużycie rdzeni: w normie";
            // 
            // button_zamknij
            // 
            this.button_zamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button_zamknij.Location = new System.Drawing.Point(480, 382);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(228, 35);
            this.button_zamknij.TabIndex = 8;
            this.button_zamknij.Text = "Wyloguj i zamknij program";
            this.button_zamknij.UseVisualStyleBackColor = true;
            this.button_zamknij.Click += new System.EventHandler(this.button_zamknij_Click);
            // 
            // timer_rdzen1
            // 
            this.timer_rdzen1.Enabled = true;
            this.timer_rdzen1.Interval = 1000;
            this.timer_rdzen1.Tick += new System.EventHandler(this.timer_parametrow);
            // 
            // timer_zdarzenie_losowe
            // 
            this.timer_zdarzenie_losowe.Enabled = true;
            this.timer_zdarzenie_losowe.Interval = 10000;
            this.timer_zdarzenie_losowe.Tick += new System.EventHandler(this.timer_zdarzenie_losowe_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 429);
            this.Controls.Add(this.button_zamknij);
            this.Controls.Add(this.groupBox_ostrzezenia);
            this.Controls.Add(this.groupBox_kontrola);
            this.Controls.Add(this.groupBox_parametry);
            this.Controls.Add(this.groupBox_obecnosc);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.napis_stanowisko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanowisko dyspozytorskie";
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox_obecnosc.ResumeLayout(false);
            this.groupBox_obecnosc.PerformLayout();
            this.groupBox_parametry.ResumeLayout(false);
            this.groupBox_parametry.PerformLayout();
            this.groupBox_kontrola.ResumeLayout(false);
            this.groupBox_kontrola.PerformLayout();
            this.groupBox_ostrzezenia.ResumeLayout(false);
            this.groupBox_ostrzezenia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label napis_stanowisko;
        private System.Windows.Forms.Label label_zalogowano_jako;
        private System.Windows.Forms.Label label_czas_data;
        private System.Windows.Forms.Timer timer_aktualny_czas;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.GroupBox groupBox_obecnosc;
        private System.Windows.Forms.Label label_obecnosc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_minuta;
        private System.Windows.Forms.Timer timer_obecnosc;
        private System.Windows.Forms.GroupBox groupBox_parametry;
        private System.Windows.Forms.TextBox textBox_temperatura;
        private System.Windows.Forms.TextBox textBox_wentylatory;
        private System.Windows.Forms.ProgressBar progressBar_procesor;
        private System.Windows.Forms.ProgressBar progressBar_rdzen1;
        private System.Windows.Forms.ProgressBar progressBar_rdzen2;
        private System.Windows.Forms.ProgressBar progressBar_rdzen3;
        private System.Windows.Forms.ProgressBar progressBar_rdzen4;
        private System.Windows.Forms.Label label_dod_wentylatory;
        private System.Windows.Forms.Label label_zuzycie_pamieci;
        private System.Windows.Forms.Label label_temperatura;
        private System.Windows.Forms.Label label_wykorzystanie_rdzeni;
        private System.Windows.Forms.Label label_rdzen3;
        private System.Windows.Forms.Label label_rdzen4;
        private System.Windows.Forms.Label label_rdzen2;
        private System.Windows.Forms.Label label_rdzen1;
        private System.Windows.Forms.GroupBox groupBox_kontrola;
        private System.Windows.Forms.GroupBox groupBox_ostrzezenia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_zamknij;
        private System.Windows.Forms.Timer timer_rdzen1;
        private System.Windows.Forms.Button button_wlacz_wentylatory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_zmniejsz_pamiec;
        private System.Windows.Forms.Button button_zmniejsz_rdzen1;
        private System.Windows.Forms.Button button_zmniejsz_rdzen2;
        private System.Windows.Forms.Button button_zmniejsz_rdzen3;
        private System.Windows.Forms.Button button_zmniejsz_rdzen4;
        private System.Windows.Forms.Timer timer_zdarzenie_losowe;
        private System.Windows.Forms.Label label_ostrzezenie_temp;
        private System.Windows.Forms.Label label_ostrzezenie_pamiec;
        private System.Windows.Forms.Label label_ostrzezenie_rdzen;
    }
}