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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _5T_PROG_PROJECT_BANKAPP
{
    public partial class Register : Form
    {
        //Declarations
        string Username;
        string Password;
        double Balance;
        string FilePath = "users.txt";
        bool IsExisting = false;


        public Register()
        {
            InitializeComponent();
        }


        private void RegisterUser(string username, string password, double balance)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.Write(username + ";" + password + ";" + balance);
                    writer.WriteLine();
                    writer.Close();
                }

                MessageBox.Show("Registratie succesvol!");

                AanmeldForm aanmeldForm = new AanmeldForm();
                aanmeldForm.Closed += (s, args) => this.Close();
                aanmeldForm.Show();

                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij de registratie: " + ex.Message);
            }
        }

        private bool Checker(string username)
        {
            string[] users = File.ReadAllLines(FilePath);

            foreach (string user in users)
            {
                string[] userInfo = user.Split(';');
                if (userInfo[0] == username)
                {
                    return true;
                }
            }

            return false;

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Username = TxtUsername.Text;
            Password = TxtPassword.Text;
            Balance = double.Parse(TxtBalance.Text);

            IsExisting = Checker(Username);

            if (IsExisting)
            {
                MessageBox.Show("Deze gebruikersnaam bestaat al. Kies aub een nieuwe.");
                return;
            }

            RegisterUser(Username, Password, Balance);



        }
    }
}
