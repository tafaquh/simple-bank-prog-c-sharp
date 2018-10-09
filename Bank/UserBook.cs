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
using static Bank.Book;

namespace Bank
{
    public partial class UserBook : MaterialForm
    {
        Book histories;
        public UserBook(ref Book histories)
        {
            InitializeComponent();
            this.histories = histories;

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

        private void UserBook_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = histories.getBook();
        }
    }
}
