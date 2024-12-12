using Newtonsoft.Json;
using System;
using System.Text.Json;
using System.Windows.Forms;
using TruckingSystem;
using System.IO;


namespace CargoTransportationSystem
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Получаем данные из полей
            string clientType = cmbClientType.SelectedItem?.ToString();
            string name = txtName.Text;
            string phone = txtPhone.Text;

            // Проверяем на заполненность обязательных полей
            if (string.IsNullOrEmpty(clientType) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // Создаем объект для сохранения
            var clientData = new
            {
                ClientType = clientType,
                Name = name,
                Phone = phone,
                PassportSeries = txtPassportSeries.Text,
                PassportNumber = txtPassportNumber.Text,
                PassportDate = txtPassportDate.Text,
                PassportIssuedBy = txtPassportIssuedBy.Text
            };

            // Указываем путь для сохранения JSON-файла
            string filePath = "client_data.json";

            try
            {
                // Сериализуем объект в JSON
                var jsonData = JsonConvert.SerializeObject(clientData, Formatting.Indented);

                // Сохраняем JSON в файл
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.cmbClientType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassportSeries = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtPassportDate = new System.Windows.Forms.TextBox();
            this.txtPassportIssuedBy = new System.Windows.Forms.TextBox();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtLegalAddress = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClientType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassportSeries = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblPassportDate = new System.Windows.Forms.Label();
            this.lblPassportIssuedBy = new System.Windows.Forms.Label();
            this.lblDirectorName = new System.Windows.Forms.Label();
            this.lblLegalAddress = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblInn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClientType
            // 
            this.cmbClientType.FormattingEnabled = true;
            this.cmbClientType.Items.AddRange(new object[] {
            "Индивидуальный",
            "Корпоративный"});
            this.cmbClientType.Location = new System.Drawing.Point(137, 31);
            this.cmbClientType.Name = "cmbClientType";
            this.cmbClientType.Size = new System.Drawing.Size(121, 24);
            this.cmbClientType.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 101);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtPassportSeries
            // 
            this.txtPassportSeries.Location = new System.Drawing.Point(137, 134);
            this.txtPassportSeries.Name = "txtPassportSeries";
            this.txtPassportSeries.Size = new System.Drawing.Size(100, 22);
            this.txtPassportSeries.TabIndex = 3;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(0, 0);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPassportNumber.TabIndex = 5;
            // 
            // txtPassportDate
            // 
            this.txtPassportDate.Location = new System.Drawing.Point(0, 0);
            this.txtPassportDate.Name = "txtPassportDate";
            this.txtPassportDate.Size = new System.Drawing.Size(100, 22);
            this.txtPassportDate.TabIndex = 7;
            // 
            // txtPassportIssuedBy
            // 
            this.txtPassportIssuedBy.Location = new System.Drawing.Point(0, 0);
            this.txtPassportIssuedBy.Name = "txtPassportIssuedBy";
            this.txtPassportIssuedBy.Size = new System.Drawing.Size(100, 22);
            this.txtPassportIssuedBy.TabIndex = 9;
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(0, 0);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(100, 22);
            this.txtDirectorName.TabIndex = 11;
            // 
            // txtLegalAddress
            // 
            this.txtLegalAddress.Location = new System.Drawing.Point(0, 0);
            this.txtLegalAddress.Name = "txtLegalAddress";
            this.txtLegalAddress.Size = new System.Drawing.Size(100, 22);
            this.txtLegalAddress.TabIndex = 13;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(0, 0);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(100, 22);
            this.txtBankName.TabIndex = 15;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Location = new System.Drawing.Point(0, 0);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(100, 22);
            this.txtBankAccount.TabIndex = 17;
            // 
            // txtInn
            // 
            this.txtInn.Location = new System.Drawing.Point(0, 0);
            this.txtInn.Name = "txtInn";
            this.txtInn.Size = new System.Drawing.Size(100, 22);
            this.txtInn.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(81, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Location = new System.Drawing.Point(12, 31);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(92, 16);
            this.lblClientType.TabIndex = 0;
            this.lblClientType.Text = "Тип клиента:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ФИО:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(122, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Номер телефона:";
            // 
            // lblPassportSeries
            // 
            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.Location = new System.Drawing.Point(12, 140);
            this.lblPassportSeries.Name = "lblPassportSeries";
            this.lblPassportSeries.Size = new System.Drawing.Size(115, 16);
            this.lblPassportSeries.TabIndex = 3;
            this.lblPassportSeries.Text = "Серия паспорта:";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.Location = new System.Drawing.Point(0, 0);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(100, 23);
            this.lblPassportNumber.TabIndex = 4;
            // 
            // lblPassportDate
            // 
            this.lblPassportDate.Location = new System.Drawing.Point(0, 0);
            this.lblPassportDate.Name = "lblPassportDate";
            this.lblPassportDate.Size = new System.Drawing.Size(100, 23);
            this.lblPassportDate.TabIndex = 6;
            // 
            // lblPassportIssuedBy
            // 
            this.lblPassportIssuedBy.Location = new System.Drawing.Point(0, 0);
            this.lblPassportIssuedBy.Name = "lblPassportIssuedBy";
            this.lblPassportIssuedBy.Size = new System.Drawing.Size(100, 23);
            this.lblPassportIssuedBy.TabIndex = 8;
            // 
            // lblDirectorName
            // 
            this.lblDirectorName.Location = new System.Drawing.Point(0, 0);
            this.lblDirectorName.Name = "lblDirectorName";
            this.lblDirectorName.Size = new System.Drawing.Size(100, 23);
            this.lblDirectorName.TabIndex = 10;
            // 
            // lblLegalAddress
            // 
            this.lblLegalAddress.Location = new System.Drawing.Point(0, 0);
            this.lblLegalAddress.Name = "lblLegalAddress";
            this.lblLegalAddress.Size = new System.Drawing.Size(100, 23);
            this.lblLegalAddress.TabIndex = 12;
            // 
            // lblBankName
            // 
            this.lblBankName.Location = new System.Drawing.Point(0, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(100, 23);
            this.lblBankName.TabIndex = 14;
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.Location = new System.Drawing.Point(0, 0);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(100, 23);
            this.lblBankAccount.TabIndex = 16;
            // 
            // lblInn
            // 
            this.lblInn.Location = new System.Drawing.Point(0, 0);
            this.lblInn.Name = "lblInn";
            this.lblInn.Size = new System.Drawing.Size(100, 23);
            this.lblInn.TabIndex = 18;
            // 
            // ClientForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.lblClientType);
            this.Controls.Add(this.cmbClientType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPassportSeries);
            this.Controls.Add(this.txtPassportSeries);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.lblPassportDate);
            this.Controls.Add(this.txtPassportDate);
            this.Controls.Add(this.lblPassportIssuedBy);
            this.Controls.Add(this.txtPassportIssuedBy);
            this.Controls.Add(this.lblDirectorName);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.lblLegalAddress);
            this.Controls.Add(this.txtLegalAddress);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.txtBankAccount);
            this.Controls.Add(this.lblInn);
            this.Controls.Add(this.txtInn);
            this.Controls.Add(this.btnSave);
            this.Name = "ClientForm";
            this.Text = "Анекта";
            this.Load += new System.EventHandler(this.ClientForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbClientType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassportSeries;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtPassportDate;
        private System.Windows.Forms.TextBox txtPassportIssuedBy;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.TextBox txtLegalAddress;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.TextBox txtInn;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassportSeries;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblPassportDate;
        private System.Windows.Forms.Label lblPassportIssuedBy;
        private System.Windows.Forms.Label lblDirectorName;
        private System.Windows.Forms.Label lblLegalAddress;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblInn;

        private void ClientForm_Load(object sender, EventArgs e)
        {
        }

        private void ClientForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
