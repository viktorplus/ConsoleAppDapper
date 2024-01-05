using Microsoft.Data.SqlClient;
using System.Text;

namespace ConsoleAppDapper
{
    //https://www.learndapper.com/dapper-query/selecting-multiple-rows
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SubscribeDB db = new SubscribeDB(Constants.ConnectionString);

            while (true)
            {
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Відображення усіх покупців.");
                Console.WriteLine("2. Відображення email усіх покупців.");
                Console.WriteLine("3. Відображення списку розділів.");
                Console.WriteLine("4. Відображення списку акційних товарів.");
                Console.WriteLine("5. Відображення усіх міст.");
                Console.WriteLine("6. Відображення усіх країн.");
                Console.WriteLine("7. Відображення усіх покупців з певного міста.");
                Console.WriteLine("8. Відображення усіх покупців з певної країни.");
                Console.WriteLine("9. Відображення усіх акцій для певної країни.");
                Console.WriteLine("10. Вставка інформації про нових покупців.");
                Console.WriteLine("11. Вставка нових країн.");
                Console.WriteLine("12. Вставка інформації про нові розділи.");
                Console.WriteLine("13. Вставка інформації про нові акційні товари.");
                Console.WriteLine("14. Оновлення інформації про покупців.");

                Console.WriteLine("15. Оновлення інформації про країни.");
                Console.WriteLine("16. Оновлення інформації про розділи.");
                Console.WriteLine("17. Оновлення інформації про акційні товари.");
                Console.WriteLine("18. Видалення інформації про покупців.");
                Console.WriteLine("19. Видалення інформації про країни.");
                Console.WriteLine("20. Відображення списку міст певної країни.");
                Console.WriteLine("21. Відображення списку покупців певного розділу.");



                Console.WriteLine("100. Вихід.");
                Console.Write("Выберіть дію (1-): ");
                string choice = Console.ReadLine();

                    switch (choice)
                    {
                    case "1":
                        db.MultiString<Customers>(Constants.GetAllClients);
                        break;
                    case "2":
                        db.MultiString<string>(Constants.GetEmails);
                        break;
                    case "3":
                        db.MultiString<Section>(Constants.GetSection);
                        break;
                    case "4":
                        db.MultiString<PromoGoods>(Constants.GetPromoGoods);
                        break;
                    case "5":
                        db.MultiString<string>(Constants.GetCity);
                        break;
                    case "6":
                        db.MultiString<Countrys>(Constants.GetCountry);
                        break;
                    case "7":
                        var param7 = new { city ="Berlin"};
                        db.MultiString<Customers>(Constants.GetAllClientsFromCity, param7);
                        break;
                    case "8":
                        var param8 = new { country = "Україна" };
                        db.MultiString<Customers>(Constants.GetAllClientsFromCountry, param8);
                        break;
                    case "9":
                        var param9 = new { country = "Україна" };
                        db.MultiString<PromoGoods>(Constants.GetPromoGoodsFromCountry, param9);
                        break;
                    case "10":
                        object[] param10 = { new { name = "John Doe", dateOfBirth="2000-01-01", gender = "Чоловіча", email = "jdoe@example.com", country="Німеччина", city="Hannover" } };
                        db.Execute(Constants.InsertCustomer, param10);
                        break;
                    case "11":
                        object[] param11 = { new { name = "Китай"} };
                        db.Execute(Constants.InsertCountry, param11);
                        break;
                    case "12":
                        var param12 = new { name = "Новий розділ" };
                        db.Execute(Constants.InsertSection, param12);
                        break;
                    case "13":
                        object[] param13 = { new { section = "Новий розділ", name = "Новий товар", country = "Німеччина", start_date = "2021-01-01", end_date = "2021-01-31" } };
                        db.Execute(Constants.InsertPromoGoods, param13);
                        break;
                    case "14":
                        object[] param14 = { new {id=10, name = "John Doe Update", dateOfBirth = "2000-01-01", gender = "Чоловіча", email = "jdoe@example.com", country = "Німеччина", city = "Hannover" } };
                        db.Execute(Constants.UpdateCustomer, param14);
                        break;
                    case "15":
                        object[] param15 = { new { id= 1003, name = "Китай2" } };
                        db.Execute(Constants.UpdateCountry, param15);
                        break;
                    case "16":
                        object[] param16 = { new { id = 1002, name = "Новий розділ2" } };
                        db.Execute(Constants.UpdateSection, param16);
                        break;
                    case "17":
                        object[] param17 = { new { id = 1002, section = "Новий розділ3", name = "Новий товар3", country = "Німеччина", start_date = "2021-01-01", end_date = "2021-01-31" } };
                        db.Execute(Constants.UpdatePromoGoods, param17);
                        break;
                    case "18":
                        object[] param18 = { new { id = 1007 } };
                        db.Execute(Constants.DeleteCustomer, param18);
                        break;
                    case "19":
                        object[] param19 = { new { id = 1003 } };
                        db.Execute(Constants.DeleteCountry, param19);
                        break;
                    case "20":
                        var param20 = new { country = "Україна" };
                        db.MultiString<string>(Constants.GetCityFromCountry, param20);
                        break;
                    case "21":
                        var param21 = new { id = 1 };
                        db.MultiString<string>(Constants.GetSectionfromCustomer, param21);
                        break;
                    case "22":
                        var param22 = new { section = "Новий розділ" };
                        db.MultiString<PromoGoods>(Constants.GetPromoGoodsFromSection, param22);
                        break;


                    case "100":
                            Console.WriteLine("До побачення!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Неверный выбор. Пожалуйста, выберите от 1 до 100.");
                            break;
                    }
            }
        }
    }
}
