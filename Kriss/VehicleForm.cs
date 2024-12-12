using System;
using System.Windows.Forms;

namespace CargoTransportationSystem
{
    public partial class VehicleForm : Form
    {
        // Конструктор формы
        public VehicleForm()
        {
            InitializeComponent(); // Этот метод должен быть сгенерирован автоматически
        }

        // Обработчик события для кнопки Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string numberPlate = txtNumberPlate.Text;
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string capacity = txtCapacity.Text;
            string purpose = txtPurpose.Text;
            string yearOfManufacture = txtYearOfManufacture.Text;
            string lastRepairYear = txtLastRepairYear.Text;
            string mileage = txtMileage.Text;

            // Здесь можно создать объект транспортного средства
            // Например, Vehicle vehicle = new Vehicle(numberPlate, brand, model, capacity, purpose, yearOfManufacture, lastRepairYear, mileage);

            // Просто выводим сообщение для проверки
            MessageBox.Show("Транспортное средство сохранено.");
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
