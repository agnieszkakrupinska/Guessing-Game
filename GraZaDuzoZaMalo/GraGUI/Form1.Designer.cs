namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTextPropozycja = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.MaskedTextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.losowanieStart = new System.Windows.Forms.GroupBox();
            this.labelWynik = new System.Windows.Forms.Label();
            this.groupBoxStatystyki = new System.Windows.Forms.GroupBox();
            this.labelStatystyki2 = new System.Windows.Forms.Label();
            this.labelStatystyki1 = new System.Windows.Forms.Label();
            this.groupBoxLosuj.SuspendLayout();
            this.losowanieStart.SuspendLayout();
            this.groupBoxStatystyki.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(9, 8);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(67, 25);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresOd);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(9, 47);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLosuj.Size = new System.Drawing.Size(232, 102);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(157, 44);
            this.buttonWylosuj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(56, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Losuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(65, 68);
            this.textBoxZakresDo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(68, 20);
            this.textBoxZakresDo.TabIndex = 3;
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(5, 70);
            this.labelZakresDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(5, 27);
            this.labelZakresOd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(65, 27);
            this.textBoxZakresOd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(68, 20);
            this.textBoxZakresOd.TabIndex = 0;
            this.textBoxZakresOd.TextChanged += new System.EventHandler(this.textBoxZakresOd_TextChanged);
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(182, 8);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 25);
            this.buttonPrzerwij.TabIndex = 2;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // labelTextPropozycja
            // 
            this.labelTextPropozycja.AutoSize = true;
            this.labelTextPropozycja.Location = new System.Drawing.Point(2, 30);
            this.labelTextPropozycja.Name = "labelTextPropozycja";
            this.labelTextPropozycja.Size = new System.Drawing.Size(94, 13);
            this.labelTextPropozycja.TabIndex = 4;
            this.labelTextPropozycja.Text = "Podaj propozycję: ";
            this.labelTextPropozycja.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(100, 27);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(48, 20);
            this.textBoxPropozycja.TabIndex = 5;
            this.textBoxPropozycja.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxPropozycja_MaskInputRejected);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(154, 25);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(56, 23);
            this.buttonSprawdz.TabIndex = 6;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // losowanieStart
            // 
            this.losowanieStart.Controls.Add(this.labelWynik);
            this.losowanieStart.Controls.Add(this.labelTextPropozycja);
            this.losowanieStart.Controls.Add(this.buttonSprawdz);
            this.losowanieStart.Controls.Add(this.textBoxPropozycja);
            this.losowanieStart.Location = new System.Drawing.Point(12, 154);
            this.losowanieStart.Name = "losowanieStart";
            this.losowanieStart.Size = new System.Drawing.Size(229, 84);
            this.losowanieStart.TabIndex = 7;
            this.losowanieStart.TabStop = false;
            this.losowanieStart.Text = "Zaczęto losowanie!";
            this.losowanieStart.Visible = false;
            this.losowanieStart.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(2, 61);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(73, 13);
            this.labelWynik.TabIndex = 7;
            this.labelWynik.Text = "za dużo/mało";
            this.labelWynik.Visible = false;
            // 
            // groupBoxStatystyki
            // 
            this.groupBoxStatystyki.Controls.Add(this.labelStatystyki2);
            this.groupBoxStatystyki.Controls.Add(this.labelStatystyki1);
            this.groupBoxStatystyki.Location = new System.Drawing.Point(9, 244);
            this.groupBoxStatystyki.Name = "groupBoxStatystyki";
            this.groupBoxStatystyki.Size = new System.Drawing.Size(229, 100);
            this.groupBoxStatystyki.TabIndex = 9;
            this.groupBoxStatystyki.TabStop = false;
            this.groupBoxStatystyki.Text = "Statystyki";
            this.groupBoxStatystyki.Visible = false;
            // 
            // labelStatystyki2
            // 
            this.labelStatystyki2.AutoSize = true;
            this.labelStatystyki2.Location = new System.Drawing.Point(8, 45);
            this.labelStatystyki2.Name = "labelStatystyki2";
            this.labelStatystyki2.Size = new System.Drawing.Size(35, 13);
            this.labelStatystyki2.TabIndex = 1;
            this.labelStatystyki2.Text = "label1";
            // 
            // labelStatystyki1
            // 
            this.labelStatystyki1.AutoSize = true;
            this.labelStatystyki1.Location = new System.Drawing.Point(8, 20);
            this.labelStatystyki1.Name = "labelStatystyki1";
            this.labelStatystyki1.Size = new System.Drawing.Size(50, 13);
            this.labelStatystyki1.TabIndex = 0;
            this.labelStatystyki1.Text = "statystyki";
            this.labelStatystyki1.Click += new System.EventHandler(this.labelStatystyki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 368);
            this.Controls.Add(this.groupBoxStatystyki);
            this.Controls.Add(this.losowanieStart);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Gra Za Dużo Za Mało";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.losowanieStart.ResumeLayout(false);
            this.losowanieStart.PerformLayout();
            this.groupBoxStatystyki.ResumeLayout(false);
            this.groupBoxStatystyki.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTextPropozycja;
        private System.Windows.Forms.MaskedTextBox textBoxPropozycja;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.GroupBox losowanieStart;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.GroupBox groupBoxStatystyki;
        private System.Windows.Forms.Label labelStatystyki1;
        private System.Windows.Forms.Label labelStatystyki2;
    }
}
