namespace Bank
{
    partial class WithdrawIDR
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
            this.withdrawUSDBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelNote = new System.Windows.Forms.Label();
            this.tfAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.backBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // withdrawUSDBtn
            // 
            this.withdrawUSDBtn.Depth = 0;
            this.withdrawUSDBtn.Location = new System.Drawing.Point(221, 281);
            this.withdrawUSDBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.withdrawUSDBtn.Name = "withdrawUSDBtn";
            this.withdrawUSDBtn.Primary = true;
            this.withdrawUSDBtn.Size = new System.Drawing.Size(128, 30);
            this.withdrawUSDBtn.TabIndex = 21;
            this.withdrawUSDBtn.Text = "WITHDRAW";
            this.withdrawUSDBtn.UseVisualStyleBackColor = true;
            this.withdrawUSDBtn.Click += new System.EventHandler(this.withdrawUSDBtn_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(132, 192);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(34, 24);
            this.labelNote.TabIndex = 20;
            this.labelNote.Text = "Rp";
            this.labelNote.Click += new System.EventHandler(this.labelNote_Click);
            // 
            // tfAmount
            // 
            this.tfAmount.Depth = 0;
            this.tfAmount.Hint = "";
            this.tfAmount.Location = new System.Drawing.Point(198, 193);
            this.tfAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfAmount.Name = "tfAmount";
            this.tfAmount.PasswordChar = '\0';
            this.tfAmount.SelectedText = "";
            this.tfAmount.SelectionLength = 0;
            this.tfAmount.SelectionStart = 0;
            this.tfAmount.Size = new System.Drawing.Size(247, 23);
            this.tfAmount.TabIndex = 19;
            this.tfAmount.UseSystemPasswordChar = false;
            this.tfAmount.Click += new System.EventHandler(this.tfAmount_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(88, 119);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(417, 33);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "WithDraw Indonesian Rupiah";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(211, 243);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 22;
            // 
            // backBtn
            // 
            this.backBtn.Depth = 0;
            this.backBtn.Location = new System.Drawing.Point(539, 75);
            this.backBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn.Name = "backBtn";
            this.backBtn.Primary = true;
            this.backBtn.Size = new System.Drawing.Size(49, 23);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // WithdrawIDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.withdrawUSDBtn);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.tfAmount);
            this.Controls.Add(this.labelTitle);
            this.Name = "WithdrawIDR";
            this.Text = "WithdrawIDR";
            this.Load += new System.EventHandler(this.WithdrawIDR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton withdrawUSDBtn;
        private System.Windows.Forms.Label labelNote;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfAmount;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMessage;
        private MaterialSkin.Controls.MaterialRaisedButton backBtn;
    }
}