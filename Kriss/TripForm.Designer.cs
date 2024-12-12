namespace CargoTransportationSystem
{
    partial class TripForm
    {
        private System.ComponentModel.IContainer components = null;

        // Очистка ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtTripDate = new System.Windows.Forms.TextBox();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.txtDriverIds = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTripDate = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.lblDriverIds = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTripDate
            // 
            this.txtTripDate.Location = new System.Drawing.Point(135, 32);
            this.txtTripDate.Name = "txtTripDate";
            this.txtTripDate.Size = new System.Drawing.Size(100, 22);
            this.txtTripDate.TabIndex = 0;
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(135, 68);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleId.TabIndex = 1;
            this.txtVehicleId.TextChanged += new System.EventHandler(this.txtVehicleId_TextChanged);
            // 
            // txtDriverIds
            // 
            this.txtDriverIds.Location = new System.Drawing.Point(135, 104);
            this.txtDriverIds.Name = "txtDriverIds";
            this.txtDriverIds.Size = new System.Drawing.Size(100, 22);
            this.txtDriverIds.TabIndex = 2;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(135, 140);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 22);
            this.txtOrderId.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить поездку";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTripDate
            // 
            this.lblTripDate.AutoSize = true;
            this.lblTripDate.Location = new System.Drawing.Point(12, 35);
            this.lblTripDate.Name = "lblTripDate";
            this.lblTripDate.Size = new System.Drawing.Size(100, 16);
            this.lblTripDate.TabIndex = 1;
            this.lblTripDate.Text = "Дата поездки:";
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.Location = new System.Drawing.Point(12, 71);
            this.lblVehicleId.Name = "lblVehicleId";
            this.lblVehicleId.Size = new System.Drawing.Size(191, 16);
            this.lblVehicleId.TabIndex = 2;
            this.lblVehicleId.Text = "ID Транспортного средства:";
            // 
            // lblDriverIds
            // 
            this.lblDriverIds.AutoSize = true;
            this.lblDriverIds.Location = new System.Drawing.Point(12, 107);
            this.lblDriverIds.Name = "lblDriverIds";
            this.lblDriverIds.Size = new System.Drawing.Size(98, 16);
            this.lblDriverIds.TabIndex = 3;
            this.lblDriverIds.Text = "ID Водителей:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(12, 143);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(74, 16);
            this.lblOrderId.TabIndex = 4;
            this.lblOrderId.Text = "ID Заказа:";
            // 
            // TripForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtDriverIds);
            this.Controls.Add(this.txtVehicleId);
            this.Controls.Add(this.txtTripDate);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblDriverIds);
            this.Controls.Add(this.lblVehicleId);
            this.Controls.Add(this.lblTripDate);
            this.Name = "TripForm";
            this.Text = "Форма поездки";
            this.Load += new System.EventHandler(this.TripForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTripDate;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.TextBox txtDriverIds;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Label lblTripDate;
        private System.Windows.Forms.Label lblVehicleId;
        private System.Windows.Forms.Label lblDriverIds;
        private System.Windows.Forms.Label lblOrderId;
    }
}
