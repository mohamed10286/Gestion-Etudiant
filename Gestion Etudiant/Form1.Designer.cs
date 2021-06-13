
namespace Gestion_Etudiant
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.closed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclosedchildform = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Etudiants = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.paneldesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.Etudiants);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 441);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellogo.Controls.Add(this.label2);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(214, 84);
            this.panellogo.TabIndex = 0;
            this.panellogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panellogo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mohamed Ben Kaddour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitle.Controls.Add(this.minimize);
            this.paneltitle.Controls.Add(this.maximize);
            this.paneltitle.Controls.Add(this.closed);
            this.paneltitle.Controls.Add(this.btnclosedchildform);
            this.paneltitle.Controls.Add(this.label1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(214, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(683, 84);
            this.paneltitle.TabIndex = 1;
            this.paneltitle.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitle_Paint);
            this.paneltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitle_MouseDown);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(578, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "O";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize.ForeColor = System.Drawing.Color.White;
            this.maximize.Location = new System.Drawing.Point(614, 3);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(30, 30);
            this.maximize.TabIndex = 3;
            this.maximize.Text = "O";
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // closed
            // 
            this.closed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closed.FlatAppearance.BorderSize = 0;
            this.closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closed.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed.ForeColor = System.Drawing.Color.White;
            this.closed.Location = new System.Drawing.Point(650, 3);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(30, 30);
            this.closed.TabIndex = 2;
            this.closed.Text = "O";
            this.closed.UseVisualStyleBackColor = true;
            this.closed.Click += new System.EventHandler(this.closed_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acceuil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // paneldesktop
            // 
            this.paneldesktop.Controls.Add(this.label3);
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(214, 84);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(683, 357);
            this.paneldesktop.TabIndex = 2;
            this.paneldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktop_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 158);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome \r\nBienvenue\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnclosedchildform
            // 
            this.btnclosedchildform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclosedchildform.FlatAppearance.BorderSize = 0;
            this.btnclosedchildform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosedchildform.Image = global::Gestion_Etudiant.Properties.Resources.cross_out__2_;
            this.btnclosedchildform.Location = new System.Drawing.Point(0, 0);
            this.btnclosedchildform.Name = "btnclosedchildform";
            this.btnclosedchildform.Size = new System.Drawing.Size(104, 84);
            this.btnclosedchildform.TabIndex = 1;
            this.btnclosedchildform.UseVisualStyleBackColor = true;
            this.btnclosedchildform.Click += new System.EventHandler(this.btnclosedchildform_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Gestion_Etudiant.Properties.Resources.calendar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(0, 285);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 94);
            this.button3.TabIndex = 3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Gestion_Etudiant.Properties.Resources.tester;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(0, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 99);
            this.button2.TabIndex = 2;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Etudiants
            // 
            this.Etudiants.BackgroundImage = global::Gestion_Etudiant.Properties.Resources.graduated__4_;
            this.Etudiants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Etudiants.Dock = System.Windows.Forms.DockStyle.Top;
            this.Etudiants.FlatAppearance.BorderSize = 0;
            this.Etudiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Etudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Etudiants.ForeColor = System.Drawing.Color.White;
            this.Etudiants.Location = new System.Drawing.Point(0, 84);
            this.Etudiants.Margin = new System.Windows.Forms.Padding(10);
            this.Etudiants.Name = "Etudiants";
            this.Etudiants.Size = new System.Drawing.Size(214, 102);
            this.Etudiants.TabIndex = 1;
            this.Etudiants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Etudiants.UseVisualStyleBackColor = true;
            this.Etudiants.Click += new System.EventHandler(this.Etudiants_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 441);
            this.ControlBox = false;
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Menu";
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.paneldesktop.ResumeLayout(false);
            this.paneldesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Etudiants;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paneldesktop;
        private System.Windows.Forms.Button btnclosedchildform;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button closed;
        private System.Windows.Forms.Label label3;
    }
}

