
namespace Gestion_Etudiant.Forms.Vue_Etudiant
{
    partial class ListeET
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.matricule = new System.Windows.Forms.Label();
            this.datenaissance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.label3.Location = new System.Drawing.Point(27, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matricule :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.label4.Location = new System.Drawing.Point(27, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date de naissance :";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.nom.Location = new System.Drawing.Point(152, 27);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(0, 32);
            this.nom.TabIndex = 5;
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.prenom.Location = new System.Drawing.Point(222, 106);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(0, 32);
            this.prenom.TabIndex = 6;
            // 
            // matricule
            // 
            this.matricule.AutoSize = true;
            this.matricule.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.matricule.Location = new System.Drawing.Point(271, 192);
            this.matricule.Name = "matricule";
            this.matricule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.matricule.Size = new System.Drawing.Size(0, 32);
            this.matricule.TabIndex = 7;
            // 
            // datenaissance
            // 
            this.datenaissance.AutoSize = true;
            this.datenaissance.Font = new System.Drawing.Font("ROG Fonts", 20.25F);
            this.datenaissance.Location = new System.Drawing.Point(430, 296);
            this.datenaissance.Name = "datenaissance";
            this.datenaissance.Size = new System.Drawing.Size(0, 32);
            this.datenaissance.TabIndex = 8;
            // 
            // ListeET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datenaissance);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListeET";
            this.Text = "ListeET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label matricule;
        private System.Windows.Forms.Label datenaissance;
    }
}