namespace CargoTransportationSystem
{
    partial class DriverForm
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassportSeries = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            // Метки
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassportSeries = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(135, 32);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(111, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Полное имя:";

            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(135, 68);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(100, 22);
            this.txtLicenseNumber.TabIndex = 1;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 71);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(113, 17);
            this.lblLicenseNumber.TabIndex = 2;
            this.lblLicenseNumber.Text = "Номер лицензии:";

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(135, 104);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 107);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 17);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Номер тел.:";

            // 
            // txtPassportSeries
            // 
            this.txtPassportSeries.Location = new System.Drawing.Point(135, 140);
            this.txtPassportSeries.Name = "txtPassportSeries";
            this.txtPassportSeries.Size = new System.Drawing.Size(100, 22);
            this.txtPassportSeries.TabIndex = 3;
            // 
            // lblPassportSeries
            // 
            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.Location = new System.Drawing.Point(12, 143);
            this.lblPassportSeries.Name = "lblPassportSeries";
            this.lblPassportSeries.Size = new System.Drawing.Size(111, 17);
            this.lblPassportSeries.TabIndex = 4;
            this.lblPassportSeries.Text = "Серия паспорта:";

            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(135, 176);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPassportNumber.TabIndex = 4;
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(12, 179);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(117, 17);
            this.lblPassportNumber.TabIndex = 5;
            this.lblPassportNumber.Text = "Номер паспорта:";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // DriverForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtPassportSeries);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.lblPassportSeries);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLicenseNumber);
            this.Controls.Add(this.lblFullName);
            this.Name = "DriverForm";
            this.Text = "Форма Водителя";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassportSeries;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Button btnSave;

        // Метки
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassportSeries;
        private System.Windows.Forms.Label lblPassportNumber;
    }
}
