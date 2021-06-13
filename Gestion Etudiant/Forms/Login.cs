using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace Gestion_Etudiant.Forms
{
    public partial class Login : Form
    {
        bool btemploye;

        public Login()
        {
            InitializeComponent();
            btemploye = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.LightGray;
            }

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
                password.UseSystemPasswordChar = true;
            }

        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.Silver;
                password.UseSystemPasswordChar = false;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Silver;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void suivant_Click(object sender, EventArgs e)
        {
         
            if (btemploye == true)
            {
                bool reussi = false;
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                cs.DataSource = "(local)";
                cs.InitialCatalog = "Etudiants";
                cs.UserID = "sa";
                cs.Password = "sysadm";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = cs.ConnectionString;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Login";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (username.Text.Equals(Decrypt(reader.GetString(0))) && password.Text.Equals(Decrypt(reader.GetString(1))))
                    {
                        reussi = true;
                        

                    }


                }
                if (reussi == true)
                {
                    Form1 acceuil = new Form1();
                    acceuil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password Incorect", "Erreur");
                }

                con.Close();
            }
            else
            {
                bool reussi = false;
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                cs.DataSource = "(local)";
                cs.InitialCatalog = "Etudiants";
                cs.UserID = "sa";
                cs.Password = "sysadm";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = cs.ConnectionString;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM ETLogin";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (username.Text.Equals(Decrypt(reader.GetString(0))) && password.Text.Equals(Decrypt(reader.GetString(1))))
                    {
                        reussi = true;


                    }


                }
                if (reussi == true)
                {
                    Gestion_Etudiant.Menu acceuilET = new Gestion_Etudiant.Menu();
                    acceuilET.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password Incorect", "Erreur");
                }

                con.Close();
            }
            //Console.WriteLine(Encrypt("203"));
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btemploye = true;
        }

        private void etudiant_CheckedChanged(object sender, EventArgs e)
        {
            btemploye = false;
        }

        private void motdepasseoublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://google.com/");
            Process.Start(sInfo);

        }
    }
}
