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

using static Bank.Tabungan;
using static Bank.BankManjah;

namespace Bank
{
    public partial class AddBalance : MaterialForm
    {
        Tabungan user;
        public AddBalance(ref Tabungan user)
        {
            InitializeComponent();
            this.user = user;

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

        private void AddBalance_Load(object sender, EventArgs e)
        {
           
        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(tfAmount.Text);

                bool status = user.addBalance(amount);
                if (status)
                {
                    this.Hide();
                    BankManjah add = new BankManjah("Successfully added Rp "+amount+" to your account!");
                    add.Show();
                }
                else
                    labelMessage.Text = "Your balance is not enough!";
            }
            catch
            {
                if (tfAmount.Text=="")
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
