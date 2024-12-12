namespace CargoTransportationSystem
{
    partial class VehicleForm
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
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.txtLastRepairYear = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            // Добавляем метки для каждого текстового поля
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblYearOfManufacture = new System.Windows.Forms.Label();
            this.lblLastRepairYear = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(135, 32);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(100, 22);
            this.txtNumberPlate.TabIndex = 0;
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Location = new System.Drawing.Point(12, 35);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(96, 13);
            this.lblNumberPlate.TabIndex = 1;
            this.lblNumberPlate.Text = "Номерной знак:";

            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(135, 68);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 71);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(58, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Марка авто:";

            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(135, 104);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 2;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 107);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Модель авто:";

            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(135, 140);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 22);
            this.txtCapacity.TabIndex = 3;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(12, 143);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(94, 13);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Грузоподъемность:";

            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(135, 176);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(100, 22);
            this.txtPurpose.TabIndex = 4;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(12, 179);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(78, 13);
            this.lblPurpose.TabIndex = 5;
            this.lblPurpose.Text = "Назначение:";

            // 
            // txtYearOfManufacture
            // 
            this.txtYearOfManufacture.Location = new System.Drawing.Point(135, 212);
            this.txtYearOfManufacture.Name = "txtYearOfManufacture";
            this.txtYearOfManufacture.Size = new System.Drawing.Size(100, 22);
            this.txtYearOfManufacture.TabIndex = 5;
            // 
            // lblYearOfManufacture
            // 
            this.lblYearOfManufacture.AutoSize = true;
            this.lblYearOfManufacture.Location = new System.Drawing.Point(12, 215);
            this.lblYearOfManufacture.Name = "lblYearOfManufacture";
            this.lblYearOfManufacture.Size = new System.Drawing.Size(124, 13);
            this.lblYearOfManufacture.TabIndex = 6;
            this.lblYearOfManufacture.Text = "Год выпуска авто:";

            // 
            // txtLastRepairYear
            // 
            this.txtLastRepairYear.Location = new System.Drawing.Point(135, 248);
            this.txtLastRepairYear.Name = "txtLastRepairYear";
            this.txtLastRepairYear.Size = new System.Drawing.Size(100, 22);
            this.txtLastRepairYear.TabIndex = 6;
            // 
            // lblLastRepairYear
            // 
            this.lblLastRepairYear.AutoSize = true;
            this.lblLastRepairYear.Location = new System.Drawing.Point(12, 251);
            this.lblLastRepairYear.Name = "lblLastRepairYear";
            this.lblLastRepairYear.Size = new System.Drawing.Size(132, 13);
            this.lblLastRepairYear.TabIndex = 7;
            this.lblLastRepairYear.Text = "Год последнего ремонта:";

            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(135, 284);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(100, 22);
            this.txtMileage.TabIndex = 7;
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(12, 287);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(98, 13);
            this.lblMileage.TabIndex = 8;
            this.lblMileage.Text = "Пробег (км):";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить авто";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // VehicleForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtLastRepairYear);
            this.Controls.Add(this.txtYearOfManufacture);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblLastRepairYear);
            this.Controls.Add(this.lblYearOfManufacture);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblNumberPlate);
            this.Name = "VehicleForm";
            this.Text = "Форма транспортного средства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.TextBox txtLastRepairYear;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblYearOfManufacture;
        private System.Windows.Forms.Label lblLastRepairYear;
        private System.Windows.Forms.Label lblMileage;
    }
}
