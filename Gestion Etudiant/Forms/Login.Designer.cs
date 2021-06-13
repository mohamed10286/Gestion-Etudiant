
namespace Gestion_Etudiant.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.etudiant = new System.Windows.Forms.RadioButton();
            this.employe = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.suivant = new System.Windows.Forms.Button();
            this.motdepasseoublie = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.etudiant);
            this.panel1.Controls.Add(this.employe);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // etudiant
            // 
            this.etudiant.Checked = true;
            this.etudiant.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.etudiant.ForeColor = System.Drawing.Color.White;
            this.etudiant.Location = new System.Drawing.Point(31, 291);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(148, 35);
            this.etudiant.TabIndex = 2;
            this.etudiant.TabStop = true;
            this.etudiant.Text = "Etudiant";
            this.etudiant.UseVisualStyleBackColor = true;
            this.etudiant.CheckedChanged += new System.EventHandler(this.etudiant_CheckedChanged);
            // 
            // employe
            // 
            this.employe.Checked = true;
            this.employe.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.employe.ForeColor = System.Drawing.Color.White;
            this.employe.Location = new System.Drawing.Point(31, 250);
            this.employe.Name = "employe";
            this.employe.Size = new System.Drawing.Size(148, 35);
            this.employe.TabIndex = 1;
            this.employe.TabStop = true;
            this.employe.Text = "Employé";
            this.employe.UseVisualStyleBackColor = true;
            this.employe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_Etudiant.Properties.Resources.kisspng_general_paper_tuition_logo_academic_degree_graduat_diploma_certificate_5b564e3cc9c798_7412340015323827808265;
            this.pictureBox2.Location = new System.Drawing.Point(31, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.Location = new System.Drawing.Point(316, 92);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(408, 20);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(316, 157);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(408, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // suivant
            // 
            this.suivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.suivant.FlatAppearance.BorderSize = 0;
            this.suivant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.suivant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suivant.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.suivant.ForeColor = System.Drawing.Color.LightGray;
            this.suivant.Location = new System.Drawing.Point(316, 233);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(408, 40);
            this.suivant.TabIndex = 3;
            this.suivant.Text = "Suivant";
            this.suivant.UseVisualStyleBackColor = false;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // motdepasseoublie
            // 
            this.motdepasseoublie.AutoSize = true;
            this.motdepasseoublie.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdepasseoublie.LinkColor = System.Drawing.Color.DimGray;
            this.motdepasseoublie.Location = new System.Drawing.Point(411, 289);
            this.motdepasseoublie.Name = "motdepasseoublie";
            this.motdepasseoublie.Size = new System.Drawing.Size(222, 16);
            this.motdepasseoublie.TabIndex = 0;
            this.motdepasseoublie.TabStop = true;
            this.motdepasseoublie.Text = "Adresse e-mail / Mot de passe oubliée ?";
            this.motdepasseoublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.motdepasseoublie_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Etudiant.Properties.Resources.Minimize_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(733, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close
            // 
            this.close.Image = global::Gestion_Etudiant.Properties.Resources.Close_Icon;
            this.close.Location = new System.Drawing.Point(759, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 6;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.motdepasseoublie);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.97D;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.LinkLabel motdepasseoublie;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton employe;
        private System.Windows.Forms.RadioButton etudiant;
    }
}