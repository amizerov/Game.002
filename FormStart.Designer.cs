namespace Game._002
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.lblInn = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblFirm = new System.Windows.Forms.Label();
            this.lblErrorValidate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(134, 307);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(326, 128);
            this.btnStart.TabIndex = 5;
            this.btnStart.Tag = "";
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(3, 3);
            this.txtINN.MaxLength = 10;
            this.txtINN.Name = "txtINN";
            this.txtINN.PlaceholderText = "inn";
            this.txtINN.Size = new System.Drawing.Size(221, 29);
            this.txtINN.TabIndex = 3;
            this.txtINN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINN_KeyPress);
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(3, 3);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.PlaceholderText = "nickname";
            this.txtNickname.Size = new System.Drawing.Size(221, 29);
            this.txtNickname.TabIndex = 2;
            this.txtNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(3, 3);
            this.txtCash.MaxLength = 6;
            this.txtCash.Name = "txtCash";
            this.txtCash.PlaceholderText = " $";
            this.txtCash.Size = new System.Drawing.Size(221, 29);
            this.txtCash.TabIndex = 4;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINN_KeyPress);
            // 
            // txtFirmName
            // 
            this.txtFirmName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirmName.Location = new System.Drawing.Point(3, 3);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.PlaceholderText = "firm name";
            this.txtFirmName.Size = new System.Drawing.Size(221, 29);
            this.txtFirmName.TabIndex = 1;
            this.txtFirmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInn
            // 
            this.lblInn.AutoSize = true;
            this.lblInn.Location = new System.Drawing.Point(60, 140);
            this.lblInn.Name = "lblInn";
            this.lblInn.Size = new System.Drawing.Size(140, 21);
            this.lblInn.TabIndex = 3;
            this.lblInn.Text = "Enter the Your INN";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(60, 90);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(156, 21);
            this.lblNickname.TabIndex = 3;
            this.lblNickname.Text = "Enter Your Nickname";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(60, 190);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(170, 21);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Enter Your Start Money";
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(60, 40);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(164, 21);
            this.lblFirm.TabIndex = 3;
            this.lblFirm.Text = "Enter Your Firm Name";
            // 
            // lblErrorValidate
            // 
            this.lblErrorValidate.AutoSize = true;
            this.lblErrorValidate.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorValidate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValidate.Location = new System.Drawing.Point(18, 254);
            this.lblErrorValidate.Name = "lblErrorValidate";
            this.lblErrorValidate.Size = new System.Drawing.Size(0, 45);
            this.lblErrorValidate.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtFirmName);
            this.panel1.Location = new System.Drawing.Point(236, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 35);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtCash);
            this.panel2.Location = new System.Drawing.Point(236, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 35);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtINN);
            this.panel3.Location = new System.Drawing.Point(236, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 35);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtNickname);
            this.panel4.Location = new System.Drawing.Point(236, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 35);
            this.panel4.TabIndex = 2;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 476);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrorValidate);
            this.Controls.Add(this.lblFirm);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblInn);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStart";
            this.Text = "Business Simulator Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private TextBox txtINN;
        private TextBox txtNickname;
        private TextBox txtCash;
        private TextBox txtFirmName;
        private Label lblInn;
        private Label lblNickname;
        private Label lblMoney;
        private Label lblFirm;
        private Label lblErrorValidate;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}