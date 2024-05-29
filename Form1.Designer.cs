namespace Privilegije_korisnika
{
    partial class Form1
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
            this.ucitaj_Privilegiju = new System.Windows.Forms.Button();
            this.btndodaj_privilegiju = new System.Windows.Forms.Button();
            this.hasmanytomany = new System.Windows.Forms.Button();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnIzmeniKorisnika = new System.Windows.Forms.Button();
            this.btnDodajAdmin = new System.Windows.Forms.Button();
            this.btnDodajKoriscenjeFModula = new System.Windows.Forms.Button();
            this.btnVidiElement = new System.Windows.Forms.Button();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdOneToOne = new System.Windows.Forms.Button();
            this.cmdPrikazDodeli = new System.Windows.Forms.Button();
            this.btnStavkaMenija = new System.Windows.Forms.Button();
            this.cdmDodajDodelu = new System.Windows.Forms.Button();
            this.cmdPrikaziProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucitaj_Privilegiju
            // 
            this.ucitaj_Privilegiju.Location = new System.Drawing.Point(25, 26);
            this.ucitaj_Privilegiju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucitaj_Privilegiju.Name = "ucitaj_Privilegiju";
            this.ucitaj_Privilegiju.Size = new System.Drawing.Size(195, 23);
            this.ucitaj_Privilegiju.TabIndex = 0;
            this.ucitaj_Privilegiju.Text = "Ucitaj Privilegiju";
            this.ucitaj_Privilegiju.UseVisualStyleBackColor = true;
            this.ucitaj_Privilegiju.Click += new System.EventHandler(this.ucitaj_privilegije_Click);
            // 
            // btndodaj_privilegiju
            // 
            this.btndodaj_privilegiju.Location = new System.Drawing.Point(25, 55);
            this.btndodaj_privilegiju.Margin = new System.Windows.Forms.Padding(4);
            this.btndodaj_privilegiju.Name = "btndodaj_privilegiju";
            this.btndodaj_privilegiju.Size = new System.Drawing.Size(195, 28);
            this.btndodaj_privilegiju.TabIndex = 1;
            this.btndodaj_privilegiju.Text = "Dodaj privilegiju";
            this.btndodaj_privilegiju.UseVisualStyleBackColor = true;
            this.btndodaj_privilegiju.Click += new System.EventHandler(this.btndodaj_privilegiju_Click);
            // 
            // hasmanytomany
            // 
            this.hasmanytomany.Location = new System.Drawing.Point(25, 91);
            this.hasmanytomany.Margin = new System.Windows.Forms.Padding(4);
            this.hasmanytomany.Name = "hasmanytomany";
            this.hasmanytomany.Size = new System.Drawing.Size(195, 28);
            this.hasmanytomany.TabIndex = 3;
            this.hasmanytomany.Text = "Has Many To Many";
            this.hasmanytomany.UseVisualStyleBackColor = true;
            this.hasmanytomany.Click += new System.EventHandler(this.hasmanytomany_Click);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Location = new System.Drawing.Point(25, 127);
            this.btnDodajKorisnika.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(195, 28);
            this.btnDodajKorisnika.TabIndex = 4;
            this.btnDodajKorisnika.Text = "Dodaj Korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnIzmeniKorisnika
            // 
            this.btnIzmeniKorisnika.Location = new System.Drawing.Point(25, 162);
            this.btnIzmeniKorisnika.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniKorisnika.Name = "btnIzmeniKorisnika";
            this.btnIzmeniKorisnika.Size = new System.Drawing.Size(195, 28);
            this.btnIzmeniKorisnika.TabIndex = 5;
            this.btnIzmeniKorisnika.Text = "Izmeni korisnika";
            this.btnIzmeniKorisnika.UseVisualStyleBackColor = true;
            this.btnIzmeniKorisnika.Click += new System.EventHandler(this.btnIzmeniKorisnika_Click);
            // 
            // btnDodajAdmin
            // 
            this.btnDodajAdmin.Location = new System.Drawing.Point(25, 198);
            this.btnDodajAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajAdmin.Name = "btnDodajAdmin";
            this.btnDodajAdmin.Size = new System.Drawing.Size(195, 27);
            this.btnDodajAdmin.TabIndex = 6;
            this.btnDodajAdmin.Text = "Dodaj admin";
            this.btnDodajAdmin.UseVisualStyleBackColor = true;
            this.btnDodajAdmin.Click += new System.EventHandler(this.btnDodajAdmin_Click);
            // 
            // btnDodajKoriscenjeFModula
            // 
            this.btnDodajKoriscenjeFModula.Location = new System.Drawing.Point(25, 238);
            this.btnDodajKoriscenjeFModula.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKoriscenjeFModula.Name = "btnDodajKoriscenjeFModula";
            this.btnDodajKoriscenjeFModula.Size = new System.Drawing.Size(195, 28);
            this.btnDodajKoriscenjeFModula.TabIndex = 7;
            this.btnDodajKoriscenjeFModula.Text = "Kor F Mod";
            this.btnDodajKoriscenjeFModula.UseVisualStyleBackColor = true;
            this.btnDodajKoriscenjeFModula.Click += new System.EventHandler(this.btnDodajKoriscenjeFModula_Click);
            // 
            // btnVidiElement
            // 
            this.btnVidiElement.Location = new System.Drawing.Point(25, 274);
            this.btnVidiElement.Margin = new System.Windows.Forms.Padding(4);
            this.btnVidiElement.Name = "btnVidiElement";
            this.btnVidiElement.Size = new System.Drawing.Size(193, 27);
            this.btnVidiElement.TabIndex = 8;
            this.btnVidiElement.Text = "Dodaj Vidi Element";
            this.btnVidiElement.UseVisualStyleBackColor = true;
            this.btnVidiElement.Click += new System.EventHandler(this.btnVidiElement_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(25, 308);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(188, 31);
            this.cmdManyToOne.TabIndex = 9;
            this.cmdManyToOne.Text = "Many-to-One veza";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(28, 345);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(185, 30);
            this.cmdOneToMany.TabIndex = 10;
            this.cmdOneToMany.Text = "One-to-Many veza";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdOneToOne
            // 
            this.cmdOneToOne.Location = new System.Drawing.Point(28, 381);
            this.cmdOneToOne.Name = "cmdOneToOne";
            this.cmdOneToOne.Size = new System.Drawing.Size(194, 25);
            this.cmdOneToOne.TabIndex = 11;
            this.cmdOneToOne.Text = "One-to-One veza";
            this.cmdOneToOne.UseVisualStyleBackColor = true;
            this.cmdOneToOne.Click += new System.EventHandler(this.cmdOneToOne_Click);
            // 
            // cmdPrikazDodeli
            // 
            this.cmdPrikazDodeli.Location = new System.Drawing.Point(249, 26);
            this.cmdPrikazDodeli.Name = "cmdPrikazDodeli";
            this.cmdPrikazDodeli.Size = new System.Drawing.Size(196, 30);
            this.cmdPrikazDodeli.TabIndex = 12;
            this.cmdPrikazDodeli.Text = "Prikazi Dodeli";
            this.cmdPrikazDodeli.UseVisualStyleBackColor = true;
            this.cmdPrikazDodeli.Click += new System.EventHandler(this.cmdPrikazDodeli_Click);
            // 
            // btnStavkaMenija
            // 
            this.btnStavkaMenija.Location = new System.Drawing.Point(251, 62);
            this.btnStavkaMenija.Name = "btnStavkaMenija";
            this.btnStavkaMenija.Size = new System.Drawing.Size(193, 30);
            this.btnStavkaMenija.TabIndex = 13;
            this.btnStavkaMenija.Text = "Stavka menija";
            this.btnStavkaMenija.UseVisualStyleBackColor = true;
            this.btnStavkaMenija.Click += new System.EventHandler(this.btnStavkaMenija_Click);
            // 
            // cdmDodajDodelu
            // 
            this.cdmDodajDodelu.Location = new System.Drawing.Point(253, 102);
            this.cdmDodajDodelu.Name = "cdmDodajDodelu";
            this.cdmDodajDodelu.Size = new System.Drawing.Size(190, 25);
            this.cdmDodajDodelu.TabIndex = 14;
            this.cdmDodajDodelu.Text = "Dodaj dodelu";
            this.cdmDodajDodelu.UseVisualStyleBackColor = true;
            this.cdmDodajDodelu.Click += new System.EventHandler(this.cdmDodajDodelu_Click);
            // 
            // cmdPrikaziProfil
            // 
            this.cmdPrikaziProfil.Location = new System.Drawing.Point(251, 143);
            this.cmdPrikaziProfil.Name = "cmdPrikaziProfil";
            this.cmdPrikaziProfil.Size = new System.Drawing.Size(192, 30);
            this.cmdPrikaziProfil.TabIndex = 15;
            this.cmdPrikaziProfil.Text = "Prikazi profil";
            this.cmdPrikaziProfil.UseVisualStyleBackColor = true;
            this.cmdPrikaziProfil.Click += new System.EventHandler(this.cmdPrikaziProfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdPrikaziProfil);
            this.Controls.Add(this.cdmDodajDodelu);
            this.Controls.Add(this.btnStavkaMenija);
            this.Controls.Add(this.cmdPrikazDodeli);
            this.Controls.Add(this.cmdOneToOne);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.btnVidiElement);
            this.Controls.Add(this.btnDodajKoriscenjeFModula);
            this.Controls.Add(this.btnDodajAdmin);
            this.Controls.Add(this.btnIzmeniKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.hasmanytomany);
            this.Controls.Add(this.btndodaj_privilegiju);
            this.Controls.Add(this.ucitaj_Privilegiju);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucitaj_Privilegiju;
        private System.Windows.Forms.Button btndodaj_privilegiju;
        private System.Windows.Forms.Button hasmanytomany;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnIzmeniKorisnika;
        private System.Windows.Forms.Button btnDodajAdmin;
        private System.Windows.Forms.Button btnDodajKoriscenjeFModula;
        private System.Windows.Forms.Button btnVidiElement;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdOneToOne;
        private System.Windows.Forms.Button cmdPrikazDodeli;
        private System.Windows.Forms.Button btnStavkaMenija;
        private System.Windows.Forms.Button cdmDodajDodelu;
        private System.Windows.Forms.Button cmdPrikaziProfil;
    }
}

