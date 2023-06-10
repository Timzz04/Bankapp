using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5T_PROG_PROJECT_BANKAPP
{
    public partial class AanmeldForm : Form
    {

        string filePath = "users.txt";
        public string username { get; private set; }
        public double balance { get; private set; }

        string password;

        public AanmeldForm()
        {
            InitializeComponent();
            BtnInloggen.Hide();
            label1.Hide();
            label2.Hide();
            TxtUsername.Hide();
            TxtPassword.Hide();
            LblText.Hide();
            LblRegistreren.Hide();


        }




        private void button1_Click(object sender, EventArgs e)
        {


            button1.Hide();
            BtnInloggen.Show();
            label1.Show();
            label2.Show();
            TxtUsername.Show();
            TxtPassword.Show();
            LblText.Show();
            LblRegistreren.Show();



        }

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            username = TxtUsername.Text;
            password = TxtPassword.Text;

            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Error: Geef aub een Username and Paswoord in.");
                return;

            }


            try
            {

                bool IsExisting = Checker(username, password);

                if (!IsExisting)
                {
                    MessageBox.Show("Error, U account bestaat niet ");

                }
                else
                {
                    //Ga naar de home page
                    MessageBox.Show("Success!");

                    this.Hide();
                    var mainScreen = new MainScreen();
                    mainScreen.Username = username;  // Set the Username property
                    mainScreen.Balance = balance;
                    mainScreen.Closed += (s, args) => this.Close();
                    mainScreen.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured : " + ex.Message);

            }


        }

        private bool Checker(string username, string password)
        {
            string[] users = File.ReadAllLines(filePath);

            foreach (string user in users)
            {
                string[] info = user.Split(';');

                if (info[0] == username && info[1] == password)  // Het eerste deel is de gebruikers naam (vandaar 0) Passwoord is het tweede deel vandaar 1
                {
                    balance = double.Parse(info[2]);
                    return true; // Dit account bestaat, return true

                }

            }

            return false;  // Als dit niet zo is bestaat dit account niet

        }

        private void LblRegistreren_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Closed += (s, args) =>
            {
                this.Show();
                this.Close();
            };
            this.Hide();
            register.Show();
        }
    }

}
