using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using TruckingSystem;

namespace CargoTransportationSystem
{
    public partial class MainForm : Form
    {
        // Списки для хранения данных
        private List<Client> clients = new List<Client>();
        private List<Order> orders = new List<Order>();
        private List<Vehicle> vehicles = new List<Vehicle>();
        private List<Driver> drivers = new List<Driver>();
        private List<Cargo> cargos = new List<Cargo>();
        private List<Trip> trips = new List<Trip>();

        // Элементы интерфейса
        private ListBox lstClients;
        private ListBox lstOrders;
        private ListBox lstVehicles;
        private ListBox lstDrivers;
        private ListBox lstCargos;
        private ListBox lstTrips;
        private Button btnAddClient, btnAddOrder, btnAddVehicle, btnAddDriver, btnAddCargo, btnAddTrip;

        public MainForm()
        {
            InitializeCustomComponents();  // Вызываем метод инициализации компонентов вручную
        }

        private void InitializeCustomComponents()
        {
            // Инициализация ListBox
            lstClients = new ListBox { Location = new System.Drawing.Point(150, 20), Size = new System.Drawing.Size(200, 150) };
            lstOrders = new ListBox { Location = new System.Drawing.Point(150, 180), Size = new System.Drawing.Size(200, 150) };
            lstVehicles = new ListBox { Location = new System.Drawing.Point(400, 20), Size = new System.Drawing.Size(200, 150) };
            lstDrivers = new ListBox { Location = new System.Drawing.Point(400, 180), Size = new System.Drawing.Size(200, 150) };
            lstCargos = new ListBox { Location = new System.Drawing.Point(650, 20), Size = new System.Drawing.Size(200, 150) };
            lstTrips = new ListBox { Location = new System.Drawing.Point(650, 180), Size = new System.Drawing.Size(200, 150) };

            // Инициализация кнопок
            btnAddClient = new Button { Text = "Добавить клиента", Location = new System.Drawing.Point(20, 20) };
            btnAddClient.Click += btnAddClient_Click;

            btnAddOrder = new Button { Text = "Добавить заказ", Location = new System.Drawing.Point(20, 60) };
            btnAddOrder.Click += btnAddOrder_Click;

            btnAddVehicle = new Button { Text = "Добавить транспортное средство", Location = new System.Drawing.Point(20, 100) };
            btnAddVehicle.Click += btnAddVehicle_Click;

            btnAddDriver = new Button { Text = "Добавить водителя", Location = new System.Drawing.Point(20, 140) };
            btnAddDriver.Click += btnAddDriver_Click;

            btnAddCargo = new Button { Text = "Добавить груз", Location = new System.Drawing.Point(20, 180) };
            btnAddCargo.Click += btnAddCargo_Click;

            btnAddTrip = new Button { Text = "Добавить рейс", Location = new System.Drawing.Point(20, 220) };
            btnAddTrip.Click += btnAddTrip_Click;

            // Добавление элементов в форму
            this.Controls.AddRange(new Control[]
            {
                btnAddClient, btnAddOrder, btnAddVehicle, btnAddDriver, btnAddCargo, btnAddTrip,
                lstClients, lstOrders, lstVehicles, lstDrivers, lstCargos, lstTrips
            });

            // Настройка размеров формы
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Text = "Система управления грузоперевозками";
        }

        // Методы для обработки кнопок добавления данных
        private void btnAddClient_Click(object sender, EventArgs e) => ShowAddForm<ClientForm>("клиента");
        private void btnAddOrder_Click(object sender, EventArgs e) => ShowAddForm<OrderForm>("заказа");
        private void btnAddVehicle_Click(object sender, EventArgs e) => ShowAddForm<VehicleForm>("транспортного средства");
        private void btnAddDriver_Click(object sender, EventArgs e) => ShowAddForm<DriverForm>("водителя");
        private void btnAddCargo_Click(object sender, EventArgs e) => ShowAddForm<CargoForm>("груза");
        private void btnAddTrip_Click(object sender, EventArgs e) => ShowAddForm<TripForm>("рейса");

        private void ShowAddForm<T>(string itemName) where T : Form, new()
        {
            var form = new T();
            form.ShowDialog();

            // В зависимости от типа T, обновляем соответствующий список
            if (typeof(T) == typeof(ClientForm))
                UpdateListBox(lstClients, clients, client => client.Name);
            else if (typeof(T) == typeof(OrderForm))
                UpdateListBox(lstOrders, orders, order => $"Заказ №{order.OrderId}");
            else if (typeof(T) == typeof(VehicleForm))
                UpdateListBox(lstVehicles, vehicles, vehicle => vehicle.NumberPlate);
            else if (typeof(T) == typeof(DriverForm))
                UpdateListBox(lstDrivers, drivers, driver => driver.FullName);
            else if (typeof(T) == typeof(CargoForm))
                UpdateListBox(lstCargos, cargos, cargo => cargo.Name);
            else if (typeof(T) == typeof(TripForm))
                UpdateListBox(lstTrips, trips, trip => $"Рейс №{trip.TripId}");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ResumeLayout(false);

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void UpdateListBox<T>(ListBox listBox, List<T> items, Func<T, string> itemToString)
        {
            listBox.Items.Clear();
            foreach (var item in items)
            {
                listBox.Items.Add(itemToString(item));  // Добавляем новый элемент в ListBox
            }
        }

        // Сохранение данных в JSON файл
        private void SaveClientsToJson()
        {
            string json = JsonConvert.SerializeObject(clients, Formatting.Indented);  // Сериализация в JSON
            File.WriteAllText("clients.json", json);  // Сохранение в файл
        }

        // Загрузка данных из JSON файла
        private void LoadClientsFromJson()
        {
            if (File.Exists("clients.json"))
            {
                string json = File.ReadAllText("clients.json");  // Чтение из файла
                clients = JsonConvert.DeserializeObject<List<Client>>(json);  // Десериализация в список клиентов
            }
        }

        // Событие для загрузки данных при старте формы (можно использовать для загрузки)
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadClientsFromJson();  // Загрузка данных клиентов
            UpdateListBox(lstClients, clients, client => client.Name);  // Обновление ListBox
        }

        // Структура Client (простой пример)
        public class Client
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public Client(string name, string address)
            {
                Name = name;
                Address = address;
            }
        }

        // Структуры Order, Vehicle, Driver и другие (добавьте их по аналогии)
    }
}
