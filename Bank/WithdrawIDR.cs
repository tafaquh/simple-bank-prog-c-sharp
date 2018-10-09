using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

using static Bank.BankManjah;
using static Bank.Tabungan;
using static Bank.Book;

namespace Bank
{
    public partial class WithdrawIDR : MaterialForm
    {
        Tabungan user;
        Book history;
        public WithdrawIDR(ref Tabungan user, ref Book history)
        {
            InitializeComponent();
            this.user = user;
            this.history = history;

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );
        }

        private void WithdrawIDR_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelNote_Click(object sender, EventArgs e)
        {

        }

        private void tfAmount_Click(object sender, EventArgs e)
        {

        }

        private void withdrawUSDBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(tfAmount.Text);

                bool status = user.getCashWithdrawalIDR(amount);
                if (status)
                {
                    DateTime time = DateTime.Today;
                    string success = "Successfully withdrawal IDR " + amount + "!";
                    history.addHistory(time.ToString(), success);
                    this.Hide();
                    BankManjah add = new BankManjah(success);
                    add.Show();
                }
                else
                    labelMessage.Text = "Your balance is not enough!";
            }
            catch
            {
                if (tfAmount.Text == "")
                {
                    labelMessage.Text = "Fill the blank!";
                }
                labelMessage.Text = "Make sure you fill with numbers!";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankManjah add = new BankManjah("");
            add.Show();
        }
    }
}
