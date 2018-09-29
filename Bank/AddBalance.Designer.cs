namespace Bank
{
    partial class AddBalance
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
            this.label1 = new System.Windows.Forms.Label();
            this.tfAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addMoney = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.backBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add your balance";
            // 
            // tfAmount
            // 
            this.tfAmount.Depth = 0;
            this.tfAmount.Hint = "";
            this.tfAmount.Location = new System.Drawing.Point(172, 187);
            this.tfAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfAmount.Name = "tfAmount";
            this.tfAmount.PasswordChar = '\0';
            this.tfAmount.SelectedText = "";
            this.tfAmount.SelectionLength = 0;
            this.tfAmount.SelectionStart = 0;
            this.tfAmount.Size = new System.Drawing.Size(295, 23);
            this.tfAmount.TabIndex = 3;
            this.tfAmount.UseSystemPasswordChar = false;
            // 
            // addMoney
            // 
            this.addMoney.Depth = 0;
            this.addMoney.Location = new System.Drawing.Point(210, 262);
            this.addMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.addMoney.Name = "addMoney";
            this.addMoney.Primary = true;
            this.addMoney.Size = new System.Drawing.Size(148, 38);
            this.addMoney.TabIndex = 4;
            this.addMoney.Text = "Add";
            this.addMoney.UseVisualStyleBackColor = true;
            this.addMoney.Click += new System.EventHandler(this.addMoney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMessage.Location = new System.Drawing.Point(168, 228);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 20);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.Depth = 0;
            this.backBtn.Location = new System.Drawing.Point(523, 80);
            this.backBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn.Name = "backBtn";
            this.backBtn.Primary = true;
            this.backBtn.Size = new System.Drawing.Size(49, 23);
            this.backBtn.TabIndex = 21;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addMoney);
            this.Controls.Add(this.tfAmount);
            this.Controls.Add(this.label1);
            this.Name = "AddBalance";
            this.Text = "AddBalance";
            this.Load += new System.EventHandler(this.AddBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfAmount;
        private MaterialSkin.Controls.MaterialRaisedButton addMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMessage;
        private MaterialSkin.Controls.MaterialRaisedButton backBtn;
    }
}