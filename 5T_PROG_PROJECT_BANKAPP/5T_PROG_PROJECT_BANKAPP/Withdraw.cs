using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _5T_PROG_PROJECT_BANKAPP
{
    public partial class Withdraw : Form
    {
        string filepath = "users.txt";
        string password;
        double hoeveelheid;
        private double balance;
        public Withdraw(double currentBalance)
        {
            InitializeComponent();
            balance = currentBalance;
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            password = TxtPassword.Text;
            hoeveelheid = Convert.ToDouble(TxtAmount.Text);

            bool isPasswordValid = Checker(password);

            if (isPasswordValid)
            {
                if (hoeveelheid > 0 && hoeveelheid <= balance)
                {
                    // Deduct the amount from the balance
                    balance -= hoeveelheid;

                    // Update the balance on the main form or wherever necessary
                    MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
                    mainScreen?.Invoke(new Action(() => mainScreen.NewBalance(balance)));

                    MessageBox.Show($"Withdrawal successful. Amount withdrawn: {hoeveelheid}");

                    // Update the balance in the users.txt file
                    TextUpdater(mainScreen.Username, password, balance);

                    // Close the withdrawal form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid withdrawal amount.");
                }
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }


        }
        public void TextUpdater(string username, string password, double newBalance)
        {
            string[] users = File.ReadAllLines(filepath);

            for (int i = 0; i < users.Length; i++)
            {
                string[] userInfo = users[i].Split(';');
                if (userInfo[0] == username && userInfo[1] == password)
                {
                    userInfo[2] = newBalance.ToString();
                    users[i] = string.Join(";", userInfo);
                    break;
                }
            }

            File.WriteAllLines(filepath, users);
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
