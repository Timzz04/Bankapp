using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5T_PROG_PROJECT_BANKAPP
{
    public partial class Deposit : Form
    {

        string filepath = "users.txt";
        string password;
        double hoeveelheid;
        double balance;


        public Deposit()
        {
            InitializeComponent();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            password = TxtPassword.Text;
            hoeveelheid = Convert.ToDouble(TxtAmount.Text);

            bool isPasswordValid = Checker(password);

            if (isPasswordValid)
            {
                if (hoeveelheid > 0 && hoeveelheid <= balance)
                {
                    // Deduct the amount from the balance
                    balance += hoeveelheid;


                    //Ik roep de Mainscreen op 
                    MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;


                    //Ik Update de hoeveelheid 
                    mainScreen?.Invoke(new Action(() => mainScreen.NewBalance(balance)));

                    // Update the balance on the main form or wherever necessary

                    MessageBox.Show($"Deposit successful. Amount deposited: {hoeveelheid}");



                    // Close the withdrawal form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid deposit amount.");
                }
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }

        }

        private bool Checker(string password)
        {
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            string username = mainScreen.Username;

            string[] users = File.ReadAllLines(filepath);

            foreach (string user in users)
            {
                string[] info = user.Split(';');

                if (info[0] == username && info[1] == password)  // Het eerste deel is de gebruikersnaam (vandaar 0). Het wachtwoord is het tweede deel (vandaar 1).
                {
                    balance = double.Parse(info[2]);
                    return true; // Dit account bestaat, return true
                }
            }

            return false;  // Als dit niet het geval is, bestaat dit account niet
        }
    }
}
