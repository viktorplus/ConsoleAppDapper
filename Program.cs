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
                //Console.WriteLine("13. Отобразить самую популярную многопользовательскую игру по количеству продаж.");
                //Console.WriteLine("14. Отобразить самую популярную игру по количеству продаж.");
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
                        db.Insert(Constants.InsertCustomer, param10);
                        break;
                    case "11":
                        object[] param11 = { new { name = "Китай"} };
                        db.Insert(Constants.InsertCountry, param11);
                        break;
                    case "12":
                        object[] param12 = { new { name = "Новий розділ" } };
                        db.Insert(Constants.InsertSection, param12);
                        break;
                    //case "13":
                    //    Linq.DisplayMostPopularMultiplayerGameBySales(db);
                    //    break;
                    //case "14":
                    //    Linq.DisplayMostPopularGameBySales(db);
                    //    break;

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
