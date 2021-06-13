using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Etudiant.Forms
{
    
    public partial class ListeET : Form
    {
        
        public ListeET()
        {
            InitializeComponent();
        
        }
      

        private void Liste_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'etudiantsDataSet.Liste'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeTableAdapter.Fill(this.etudiantsDataSet.Liste);
            LoadTheme();

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            nouveau.ForeColor = ThemeColor.SecondaryColor;
            // supprimer.ForeColor = ThemeColor.PrimaryColor;
            modifier.ForeColor = ThemeColor.SecondaryColor;
            supprimer.ForeColor = ThemeColor.SecondaryColor;
            dataGridView1.BackgroundColor= ThemeColor.SecondaryColor;
        }
        
        private void nouveau_Click(object sender, EventArgs e)
        {
        
          


            try
            {
                if ((nom.Text == "") || (prenom.Text == "")||(numero.Text==""))
                {
                    MessageBox.Show("Remplire les cases avant de cliquer ", "Erreur de Saisie");
                }

                else
                {
                    String n1 = nom.Text;
                    String p2 = prenom.Text;
                    int num2 = int.Parse(numero.Text);
                    String d2 = datenaissance.Value.ToString("dd/MM/yyyy");
                    listeTableAdapter.InsertQuery(n1, p2, num2, d2);
                    this.listeTableAdapter.Fill(this.etudiantsDataSet.Liste);
                    nom.ResetText();
                    prenom.ResetText();
                    datenaissance.ResetText();
                    numero.ResetText();
                    MessageBox.Show("Etudiant(e) Ajouté(e) avec succés  ", "Validation");

                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Etudiant(e) Déja Existe  ", "Attention");
                }
                else throw;
            }

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if ((nom.Text == "") || (prenom.Text == "") || (numero.Text == ""))
            {
                MessageBox.Show(" Double Cliquer sur une ligne avant ", "Erreur de Saisie");
            }
            else
            {

                listeTableAdapter.Delete(nom.Text, prenom.Text, int.Parse(numero.Text), datenaissance.Value);


                this.listeTableAdapter.Fill(this.etudiantsDataSet.Liste);
                MessageBox.Show("Etudiant(e) Supprimé(e) avec succés  ", "Validation");
                nom.ResetText();
                prenom.ResetText();
                datenaissance.ResetText();
                numero.ResetText();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            nom.Text = selectedRow.Cells[0].Value.ToString();
            prenom.Text = selectedRow.Cells[1].Value.ToString();
            numero.Text = selectedRow.Cells[2].Value.ToString();
            datenaissance.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if ((nom.Text == "") || (prenom.Text == "") || (numero.Text == ""))
            {
                MessageBox.Show(" Double Cliquer sur une ligne avant ", "Erreur de Saisie");
            }
            else
            {
                listeTableAdapter.UpdateQuery(nom.Text, prenom.Text, int.Parse(numero.Text), datenaissance.Text);
                this.listeTableAdapter.Fill(this.etudiantsDataSet.Liste);
                MessageBox.Show("Etudiant(e) Modifié (e)  ", "Attention");
            }
        }

        private void nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = (e.KeyChar >= 'A' && e.KeyChar <= 'Z')||(e.KeyChar >= 'a' && e.KeyChar <= 'z');
            bool isBackspace = e.KeyChar == '\b';
            bool space = (e.KeyChar == ' ');

            // If we get anything other than a digit or backspace, tell the rest of
            // the event processing logic to ignore this event
            if (!isDigit && !isBackspace && !space)
            {
                e.Handled = true;
            }

        }
        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            // If we get anything other than a digit or backspace, tell the rest of
            // the event processing logic to ignore this event
            if (!isDigit && !isBackspace)
            {
                e.Handled = true;
            }
        }

        private void prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z');
            bool isBackspace = e.KeyChar == '\b';
            bool space = (e.KeyChar == ' ');

            // If we get anything other than a digit or backspace, tell the rest of
            // the event processing logic to ignore this event
            if (!isDigit && !isBackspace && !space)
            {
                e.Handled = true;
            }
        }
    }
}
