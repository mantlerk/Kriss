namespace TruckingSystem
{
    public class Driver
    {
        // Свойства
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; } // Это может быть необязательным, если у нас есть FirstName и LastName
        public string EmployeeId { get; set; }
        public int BirthYear { get; set; }
        public int Experience { get; set; }
        public string Category { get; set; }
        public string Class { get; set; }

        // Добавляем свойство FullName для получения полного имени
        public string FullName
        {
            get
            {
                // Возвращаем имя и фамилию, если они существуют
                return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) ? $"{FirstName} {LastName}" : Name;
            }
        }

        // Конструктор
        public Driver(string firstName, string lastName, string name, string employeeId, int birthYear, int experience, string category, string class_)
        {
            FirstName = firstName;
            LastName = lastName;
            Name = name; // Могут быть данные, если мы используем Name
            EmployeeId = employeeId;
            BirthYear = birthYear;
            Experience = experience;
            Category = category;
            Class = class_;
        }
    }
}
