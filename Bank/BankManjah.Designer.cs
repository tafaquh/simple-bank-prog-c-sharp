namespace Bank
{
    partial class BankManjah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankManjah));
            this.addBBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbTafaquh = new System.Windows.Forms.PictureBox();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.witdrawUSDBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.withdrawIDRBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.historyBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbTafaquh)).BeginInit();
            this.SuspendLayout();
            // 
            // addBBtn
            // 
            this.addBBtn.Depth = 0;
            this.addBBtn.Location = new System.Drawing.Point(218, 275);
            this.addBBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBBtn.Name = "addBBtn";
            this.addBBtn.Primary = true;
            this.addBBtn.Size = new System.Drawing.Size(158, 62);
            this.addBBtn.TabIndex = 9;
            this.addBBtn.Text = "Add Balance";
            this.addBBtn.UseVisualStyleBackColor = true;
            this.addBBtn.Click += new System.EventHandler(this.addBBtn_Click);
            // 
            // pbTafaquh
            // 
            this.pbTafaquh.ErrorImage = null;
            this.pbTafaquh.Image = ((System.Drawing.Image)(resources.GetObject("pbTafaquh.Image")));
            this.pbTafaquh.Location = new System.Drawing.Point(101, 76);
            this.pbTafaquh.Name = "pbTafaquh";
            this.pbTafaquh.Size = new System.Drawing.Size(101, 111);
            this.pbTafaquh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTafaquh.TabIndex = 10;
            this.pbTafaquh.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(97, 199);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 19);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Tafaquh Fiddin";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(255, 150);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(88, 37);
            this.labelBalance.TabIndex = 12;
            this.labelBalance.Text = "Rp 0";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(257, 89);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(154, 25);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Your Balance";
            // 
            // witdrawUSDBtn
            // 
            this.witdrawUSDBtn.Depth = 0;
            this.witdrawUSDBtn.Location = new System.Drawing.Point(398, 275);
            this.witdrawUSDBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.witdrawUSDBtn.Name = "witdrawUSDBtn";
            this.witdrawUSDBtn.Primary = true;
            this.witdrawUSDBtn.Size = new System.Drawing.Size(158, 62);
            this.witdrawUSDBtn.TabIndex = 14;
            this.witdrawUSDBtn.Text = "Withdraw USD";
            this.witdrawUSDBtn.UseVisualStyleBackColor = true;
            this.witdrawUSDBtn.Click += new System.EventHandler(this.witdrawUSDBtn_Click);
            // 
            // withdrawIDRBtn
            // 
            this.withdrawIDRBtn.Depth = 0;
            this.withdrawIDRBtn.Location = new System.Drawing.Point(31, 275);
            this.withdrawIDRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.withdrawIDRBtn.Name = "withdrawIDRBtn";
            this.withdrawIDRBtn.Primary = true;
            this.withdrawIDRBtn.Size = new System.Drawing.Size(158, 62);
            this.withdrawIDRBtn.TabIndex = 15;
            this.withdrawIDRBtn.Text = "Withdraw IDR";
            this.withdrawIDRBtn.UseVisualStyleBackColor = true;
            this.withdrawIDRBtn.Click += new System.EventHandler(this.withdrawIDRBtn_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Lime;
            this.labelMessage.Location = new System.Drawing.Point(262, 217);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 16;
            // 
            // historyBtn
            // 
            this.historyBtn.Depth = 0;
            this.historyBtn.Location = new System.Drawing.Point(492, 76);
            this.historyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Primary = true;
            this.historyBtn.Size = new System.Drawing.Size(96, 21);
            this.historyBtn.TabIndex = 17;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // BankManjah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.withdrawIDRBtn);
            this.Controls.Add(this.witdrawUSDBtn);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pbTafaquh);
            this.Controls.Add(this.addBBtn);
            this.Name = "BankManjah";
            this.Text = "ATM Bank Manjah";
            this.Load += new System.EventHandler(this.BankManjah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTafaquh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton addBalanceBtn;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton addBBtn;
        private System.Windows.Forms.PictureBox pbTafaquh;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private System.Windows.Forms.Label labelBalance;
        private MaterialSkin.Controls.MaterialRaisedButton witdrawUSDBtn;
        private MaterialSkin.Controls.MaterialRaisedButton withdrawIDRBtn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMessage;
        private MaterialSkin.Controls.MaterialRaisedButton historyBtn;
    }
}

