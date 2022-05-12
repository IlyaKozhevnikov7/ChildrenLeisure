namespace PL
{
    partial class OrderCreationMenu
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._checkoutButton = new System.Windows.Forms.Button();
            this._sumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть пропозицію";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Атракціони",
            "Казкові герої",
            "День народження",
            "Власна програма"});
            this.comboBox1.Location = new System.Drawing.Point(143, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.OnSelectedValueChanged);
            // 
            // _checkoutButton
            // 
            this._checkoutButton.Location = new System.Drawing.Point(12, 82);
            this._checkoutButton.Name = "_checkoutButton";
            this._checkoutButton.Size = new System.Drawing.Size(280, 23);
            this._checkoutButton.TabIndex = 2;
            this._checkoutButton.Text = "Замовити";
            this._checkoutButton.UseVisualStyleBackColor = true;
            this._checkoutButton.Click += new System.EventHandler(this.OnClickCheckoutButton);
            // 
            // _sumLabel
            // 
            this._sumLabel.AutoSize = true;
            this._sumLabel.Location = new System.Drawing.Point(112, 55);
            this._sumLabel.Name = "_sumLabel";
            this._sumLabel.Size = new System.Drawing.Size(0, 15);
            this._sumLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ціна: 999";
            // 
            // OrderCreationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._sumLabel);
            this.Controls.Add(this._checkoutButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderCreationMenu";
            this.Text = "OrderCreationMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button _checkoutButton;
        private Label _sumLabel;
        private Label label2;
    }
}