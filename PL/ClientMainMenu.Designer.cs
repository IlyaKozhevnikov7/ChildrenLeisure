namespace PL
{
    partial class ClientMainMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this._cashAmountLabel = new System.Windows.Forms.Label();
            this._replenishBalanceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Головне меню";
            // 
            // _cashAmountLabel
            // 
            this._cashAmountLabel.AutoSize = true;
            this._cashAmountLabel.Location = new System.Drawing.Point(189, 95);
            this._cashAmountLabel.Name = "_cashAmountLabel";
            this._cashAmountLabel.Size = new System.Drawing.Size(54, 15);
            this._cashAmountLabel.TabIndex = 2;
            this._cashAmountLabel.Text = "pipapupi";
            // 
            // _replenishBalanceButton
            // 
            this._replenishBalanceButton.Location = new System.Drawing.Point(45, 89);
            this._replenishBalanceButton.Name = "_replenishBalanceButton";
            this._replenishBalanceButton.Size = new System.Drawing.Size(131, 26);
            this._replenishBalanceButton.TabIndex = 3;
            this._replenishBalanceButton.Text = "Поповнити баланс";
            this._replenishBalanceButton.UseVisualStyleBackColor = true;
            this._replenishBalanceButton.Click += new System.EventHandler(this.OnClickReplenishBalanceButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Замовити програму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickMakeOfferButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Мої замовлення";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClickMyOffersButton);
            // 
            // ClientMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._replenishBalanceButton);
            this.Controls.Add(this._cashAmountLabel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label _cashAmountLabel;
        private Button _replenishBalanceButton;
        private Button button1;
        private Button button2;
    }
}