using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _5T_PROG_PROJECT_BANKAPP
{
    public partial class MainScreen : Form
    {

        //Ik importeer dit voor het formulier rond te maken.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        //Declaraties
        private string filepath = "users.txt";
        private string username;
        private string password;
        private double balance;

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                LblUsername.Text = username;
            }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                LblBalance.Text = balance.ToString();
            }
        }


        public MainScreen()
        {
            InitializeComponent();
            //Hier zeg ik dat wanner de form laad het ronde edges moet heben
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));


        }

        

        public void NewBalance(double newBalance)
        {

            balance = newBalance;
            LblBalance.Text = balance.ToString();



        }


   

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {


        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw(balance);
            withdraw.ShowDialog();

        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit=new Deposit();
            deposit.ShowDialog();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            AanmeldForm aanmeldForm = new AanmeldForm();
            Username = string.Empty;
            password = string.Empty;
            Balance = 0.0;
            aanmeldForm.Show();
            Hide();

        }
    }
}
