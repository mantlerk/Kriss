using System;
using System.Windows.Forms;

namespace CargoTransportationSystem
{
    public partial class TripForm : Form
    {
        public TripForm()
        {
            InitializeComponent(); // Этот метод должен вызываться, он генерируется автоматически
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string tripDate = txtTripDate.Text;
            string vehicleId = txtVehicleId.Text;
            string driverIds = txtDriverIds.Text;
            string orderId = txtOrderId.Text;

            // Создаем объект рейса
            Trip trip = new Trip(tripDate, vehicleId, driverIds, orderId);

            // Добавление рейса в коллекцию (должно быть реализовано в основной логике)
            MessageBox.Show("Рейс добавлен успешно.");
        }

        private void TripForm_Load(object sender, EventArgs e)
        {

        }

        private void txtVehicleId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
