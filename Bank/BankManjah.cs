using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Bank.Tabungan;
using static Bank.AddBalance;
using static Bank.WithdrawIDR;
using static Bank.WithdrawUSD;
using static Bank.UserBook;

namespace Bank
{
    public partial class BankManjah : MaterialForm
    {
        static Tabungan user = new Tabungan();
        static Book history = new Book();
        String message;
        public BankManjah()
        {
            generateForm();
        }

        public BankManjah(String message)
        {
            generateForm();

            if (message != "")
                this.message = message;
            else
                this.message = "";
        }

        private void BankManjah_Load(object sender, EventArgs e)
        {
            labelMessage.Text = this.message;
            labelBalance.Text = user.checkBalance().ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID"));
            pbTafaquh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void addBBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBalance add = new AddBalance(ref user, ref history);
            add.Show();
        }

        public void generateForm()
        {
            InitializeComponent();

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

        private void withdrawIDRBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawIDR add = new WithdrawIDR(ref user, ref history);
            add.Show();
        }

        private void witdrawUSDBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawUSD add = new WithdrawUSD(ref user, ref history);
            add.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBook add = new UserBook(ref history);
            add.Show();
        }
    }
}
