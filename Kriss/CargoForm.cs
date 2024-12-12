using System;
using System.Windows.Forms;

namespace CargoTransportationSystem
{
    public partial class CargoForm : Form
    {
        // Элементы управления для ввода данных
        private TextBox txtCargoName;
        private TextBox txtUnit;
        private TextBox txtQuantity;
        private TextBox txtWeight;
        private TextBox txtInsuranceValue;
        private Button btnSave;

        // Метки
        private Label lblCargoName;
        private Label lblUnit;
        private Label lblQuantity;
        private Label lblWeight;
        private Label lblInsuranceValue;

        public CargoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string name = txtCargoName.Text;
            string unit = txtUnit.Text;
            int quantity = int.Parse(txtQuantity.Text);
            float weight = float.Parse(txtWeight.Text);
            float insuranceValue = float.Parse(txtInsuranceValue.Text);

            // Создаем объект груза
            Cargo cargo = new Cargo(name, unit, quantity, weight, insuranceValue);

            // Добавление груза в коллекцию (должно быть реализовано в основной логике)
            MessageBox.Show("Груз добавлен успешно.");
        }

        private void InitializeComponent()
        {
            this.txtCargoName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtInsuranceValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCargoName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblInsuranceValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCargoName
            // 
            this.txtCargoName.Location = new System.Drawing.Point(186, 7);
            this.txtCargoName.Name = "txtCargoName";
            this.txtCargoName.Size = new System.Drawing.Size(200, 22);
            this.txtCargoName.TabIndex = 0;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(186, 35);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(200, 22);
            this.txtUnit.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(186, 61);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(186, 87);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(200, 22);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtInsuranceValue
            // 
            this.txtInsuranceValue.Location = new System.Drawing.Point(186, 118);
            this.txtInsuranceValue.Name = "txtInsuranceValue";
            this.txtInsuranceValue.Size = new System.Drawing.Size(200, 22);
            this.txtInsuranceValue.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(338, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCargoName
            // 
            this.lblCargoName.AutoSize = true;
            this.lblCargoName.Location = new System.Drawing.Point(12, 13);
            this.lblCargoName.Name = "lblCargoName";
            this.lblCargoName.Size = new System.Drawing.Size(117, 16);
            this.lblCargoName.TabIndex = 0;
            this.lblCargoName.Text = "Название груза:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 41);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(144, 16);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Единица измерения:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 67);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(88, 16);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 93);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 16);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Вес (кг):";
            // 
            // lblInsuranceValue
            // 
            this.lblInsuranceValue.AutoSize = true;
            this.lblInsuranceValue.Location = new System.Drawing.Point(12, 124);
            this.lblInsuranceValue.Name = "lblInsuranceValue";
            this.lblInsuranceValue.Size = new System.Drawing.Size(150, 16);
            this.lblInsuranceValue.TabIndex = 4;
            this.lblInsuranceValue.Text = "Страховая стоимость:";
            // 
            // CargoForm
            // 
            this.ClientSize = new System.Drawing.Size(425, 251);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInsuranceValue);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtCargoName);
            this.Controls.Add(this.lblInsuranceValue);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblCargoName);
            this.Name = "CargoForm";
            this.Text = "Добавить Груз";
            this.Load += new System.EventHandler(this.CargoForm_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CargoForm_Load(object sender, EventArgs e)
        {
            // Инициализация компонентов, если необходимо
        }

        private void CargoForm_Load_1(object sender, EventArgs e)
        {
            // Дополнительные действия при загрузке формы
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargoForm_Load_2(object sender, EventArgs e)
        {

        }
    }
}
