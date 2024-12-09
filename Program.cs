namespace Praktika_14._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //  создаём пустой список с типом данных Contact
                var phoneBook = new List<Contact>();

                // добавляем контакты
                phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
                phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
                phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
                phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
                phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
                phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

                var people = phoneBook
                    .OrderBy(s => s.Name)
                    .ThenBy(s => s.LastName);

                foreach (var person in people)
                    Console.WriteLine(person.Name +" "+ person.LastName + " Номер:" + person.PhoneNumber + " Mail:" + person.Email);

            }
        }

        public class Contact // модель класса
        {
            public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
            {
                Name = name;
                LastName = lastName;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; }
            public String LastName { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
        }


    }
}
