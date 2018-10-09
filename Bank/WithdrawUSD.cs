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
    public partial class WithdrawUSD : MaterialForm
    {
        Tabungan user;
        Book history;
        public WithdrawUSD(ref Tabungan user, ref Book history)
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

        private void WithdrawUSD_Load(object sender, EventArgs e)
        {
            tfAmount.TextChanged +=
                new EventHandler(tfAmount_TextChanged);
        }

        private void withdrawUSDBtn_Click(object sender, EventArgs e)
        {
            if (tfAmount.Text == "")
            {
                labelMessage.Text = "Fill the blank!";
            }
            else
            {
                int amount = Convert.ToInt32(tfAmount.Text);
                
                bool status = user.getCashWithdrawalUSD(amount);
                if (status)
                {
                    DateTime time = DateTime.Today;
                    string success = "Successfully withdrawal USD " + amount + "!";
                    history.addHistory(time.ToString(), success);
                    this.Hide();
                    BankManjah add = new BankManjah(success);
                    add.Show();
                }
                else
                    labelMessage.Text = "Your balance is not enough!";
            }
        }

        private void tfAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            try
            {
                int amount = Convert.ToInt32(tfAmount.Text)*13000;
                
                labelUSDToIDR.Text = "USD to Rupiah: "+amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID"));
            }
            catch
            {
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
