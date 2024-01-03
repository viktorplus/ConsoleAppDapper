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
                //Console.WriteLine("7. Отобразить самую популярную однопользовательскую игру по количеству продаж.");
                //Console.WriteLine("8. Отобразить самую популярную многопользовательскую игру по количеству продаж.");
                //Console.WriteLine("9. Отобразить самую популярную игру по количеству продаж.");
                //Console.WriteLine("10. Удалить игры с нулевым количеством продаж.");
                //Console.WriteLine("11. Удалить игры по количеству продаж.");
                //Console.WriteLine("12. Отобразить самую популярную однопользовательскую игру по количеству продаж.");
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
                    //case "7":
                    //    Linq.DisplayMostPopularSinglePlayerGameBySales(db);
                    //    break;
                    //case "8":
                    //    Linq.DisplayMostPopularMultiplayerGameBySales(db);
                    //    break;
                    //case "9":
                    //    Linq.DisplayMostPopularGameBySales(db);
                    //    break;
                    //case "10":
                    //    Linq.DeleteGamesWithZeroSales(db);
                    //    break;
                    //case "11":
                    //    Console.Write("Введите количество продаж: ");
                    //    if (int.TryParse(Console.ReadLine(), out int salesCount))
                    //    {
                    //        Linq.DeleteGamesBySales(db, salesCount);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Некорректный ввод для количества продаж.");
                    //    }
                    //    break;
                    //case "12":
                    //    Linq.DisplayMostPopularSinglePlayerGameBySales(db);
                    //    break;
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
