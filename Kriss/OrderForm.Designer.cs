namespace CargoTransportationSystem
{
    partial class OrderForm
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
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtPickupAddress = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txtRouteLength = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            // Добавление меток для каждого текстового поля
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblPickupAddress = new System.Windows.Forms.Label();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblRouteLength = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(135, 32);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(100, 22);
            this.txtOrderDate.TabIndex = 0;

            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 35);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(117, 17);
            this.lblOrderDate.TabIndex = 1;
            this.lblOrderDate.Text = "Дата заказа:";

            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(135, 68);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 22);
            this.txtSender.TabIndex = 1;

            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(12, 71);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(117, 17);
            this.lblSender.TabIndex = 2;
            this.lblSender.Text = "Отправитель:";

            // 
            // txtPickupAddress
            // 
            this.txtPickupAddress.Location = new System.Drawing.Point(135, 104);
            this.txtPickupAddress.Name = "txtPickupAddress";
            this.txtPickupAddress.Size = new System.Drawing.Size(100, 22);
            this.txtPickupAddress.TabIndex = 2;

            // 
            // lblPickupAddress
            // 
            this.lblPickupAddress.AutoSize = true;
            this.lblPickupAddress.Location = new System.Drawing.Point(12, 107);
            this.lblPickupAddress.Name = "lblPickupAddress";
            this.lblPickupAddress.Size = new System.Drawing.Size(128, 17);
            this.lblPickupAddress.TabIndex = 3;
            this.lblPickupAddress.Text = "Адрес забора:";

            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(135, 140);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(100, 22);
            this.txtRecipient.TabIndex = 3;

            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(12, 143);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(115, 17);
            this.lblRecipient.TabIndex = 4;
            this.lblRecipient.Text = "Получатель:";

            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(135, 176);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(100, 22);
            this.txtDeliveryAddress.TabIndex = 4;

            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(12, 179);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(130, 17);
            this.lblDeliveryAddress.TabIndex = 5;
            this.lblDeliveryAddress.Text = "Адрес доставки:";

            // 
            // txtRouteLength
            // 
            this.txtRouteLength.Location = new System.Drawing.Point(135, 212);
            this.txtRouteLength.Name = "txtRouteLength";
            this.txtRouteLength.Size = new System.Drawing.Size(100, 22);
            this.txtRouteLength.TabIndex = 5;

            // 
            // lblRouteLength
            // 
            this.lblRouteLength.AutoSize = true;
            this.lblRouteLength.Location = new System.Drawing.Point(12, 215);
            this.lblRouteLength.Name = "lblRouteLength";
            this.lblRouteLength.Size = new System.Drawing.Size(118, 17);
            this.lblRouteLength.TabIndex = 6;
            this.lblRouteLength.Text = "Длина маршрута:";

            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(135, 248);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 22);
            this.txtCost.TabIndex = 6;

            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 251);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(59, 17);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Стоимость:";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить заказ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtRouteLength);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtPickupAddress);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblRouteLength);
            this.Controls.Add(this.lblDeliveryAddress);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.lblPickupAddress);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblOrderDate);
            this.Name = "OrderForm";
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtPickupAddress;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.TextBox txtRouteLength;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblPickupAddress;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label lblRouteLength;
        private System.Windows.Forms.Label lblCost;
    }
}
