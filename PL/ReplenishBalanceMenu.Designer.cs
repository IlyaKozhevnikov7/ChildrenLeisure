namespace PL
{
    partial class ReplenishBalanceMenu
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
            this._moneyAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поповнити на суму";
            // 
            // _moneyAmountTextBox
            // 
            this._moneyAmountTextBox.Location = new System.Drawing.Point(133, 16);
            this._moneyAmountTextBox.Name = "_moneyAmountTextBox";
            this._moneyAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._moneyAmountTextBox.Size = new System.Drawing.Size(139, 23);
            this._moneyAmountTextBox.TabIndex = 1;
            this._moneyAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressesMoneyAmountTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Підтвердіть пароль";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Enabled = false;
            this._passwordTextBox.Location = new System.Drawing.Point(133, 47);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(139, 23);
            this._passwordTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поповнити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickTopUpCashButton);
            // 
            // ReplenishBalanceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 112);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._moneyAmountTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReplenishBalanceMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поповнення балансу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox _moneyAmountTextBox;
        private Label label2;
        private TextBox _passwordTextBox;
        private Button button1;
    }
}