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
                //Console.WriteLine("1. Відображення усіх покупців.");
                //Console.WriteLine("2. Відображення email усіх покупців.");
                //Console.WriteLine("3. Відображення списку розділів.");
                //Console.WriteLine("4. Відображення списку акційних товарів.");
                //Console.WriteLine("5. Відображення усіх міст.");
                //Console.WriteLine("6. Відображення усіх країн.");
                //Console.WriteLine("7. Відображення усіх покупців з певного міста.");
                //Console.WriteLine("8. Відображення усіх покупців з певної країни.");
                //Console.WriteLine("9. Відображення усіх акцій для певної країни.");
                //Console.WriteLine("10. Вставка інформації про нових покупців.");
                //Console.WriteLine("11. Вставка нових країн.");
                //Console.WriteLine("12. Вставка інформації про нові розділи.");
                //Console.WriteLine("13. Вставка інформації про нові акційні товари.");
                //Console.WriteLine("14. Оновлення інформації про покупців.");

                //Console.WriteLine("15. Оновлення інформації про країни.");
                //Console.WriteLine("16. Оновлення інформації про розділи.");
                //Console.WriteLine("17. Оновлення інформації про акційні товари.");
                //Console.WriteLine("18. Видалення інформації про покупців.");
                //Console.WriteLine("19. Видалення інформації про країни.");
                //Console.WriteLine("20. Відображення списку міст певної країни.");
                //Console.WriteLine("21. Відображення списку покупців певного розділу.");
                //Console.WriteLine("22. Відображення списку акційних товарів певного розділу.");

                ////////////////////////////////
                ///
                Console.WriteLine("31.Відобразити кількість покупців у кожному місті.");
                Console.WriteLine("32.Відобразити кількість покупців у кожній країні.");
                Console.WriteLine("33.Відобразити кількість міст у кожній країні.");
                Console.WriteLine("34.Відобразити середню кількість міст по всіх країнах.");
                Console.WriteLine("35.Відобразити усі розділи, в яких зацікавлені певні покупці певної країни.");
                Console.WriteLine("36.Відобразити усі акційні товари певного розділу за вказаний проміжок часу.");
                Console.WriteLine("37.Відобразити усі акційні товари певного покупця.");
                Console.WriteLine("38.Відобразити Топ-3 країни за кількістю покупців.");
                Console.WriteLine("39.Показати найкращу країну за кількістю покупців.");
                Console.WriteLine("40.Показати Топ-3 міст за кількістю покупців.");
                Console.WriteLine("41.Показати найкраще місто за кількістю покупців.");


                Console.WriteLine("42.Показати Топ-3 найпопулярніших розділів розсилки.");
                Console.WriteLine("43.Показати Топ-3 найнепопулярніших розділів розсилки.");
                Console.WriteLine("44.Показати Топ-3 розділів розсилки за кількістю акційних товарів.");
                Console.WriteLine("45.Показати розділ розсилки з найбільшою кількістю акційних товарів.");
                Console.WriteLine("46.Показати Топ-3 розділів розсилки з найменшою кількістю акційних товарів.");
                Console.WriteLine("47.Відобразіть усі акційні товари, які мають три дні до кінця акції.");
                Console.WriteLine("48.Відобразіть усі акційні товари, в яких закінчився термін дії акції.");
                Console.WriteLine("49.Перенесіть усі товари, в яких закінчився термін дії акції, до\r\nтаблиці під назвою «Архів акцій».Збережена процедура.");
                Console.WriteLine("50.Відобразіть середній вік покупців по кожному розділу.");
                Console.WriteLine("51.Відобразіть середній вік покупця по кожному місту.");
                Console.WriteLine("52.Відобразіть середній вік покупця по кожній країні.");
                Console.WriteLine("53.Відобразіть найпопулярніший розділ для кожної статі.");
                Console.WriteLine("54.Відобразіть Топ-3 розділи для кожної статі.");
                Console.WriteLine("55.Відобразіть кількість покупців кожної статі.");
                Console.WriteLine("56.Відобразіть кількість покупців кожної статі з кожної країни.");





                Console.WriteLine("100. Вихід.");
                Console.Write("Выберіть дію (1-): ");
                string choice = Console.ReadLine();

                    switch (choice)
                    {
                    //case "1":
                    //    db.MultiString<Customers>(Constants.GetAllClients);
                    //    break;
                    //case "2":
                    //    db.MultiString<string>(Constants.GetEmails);
                    //    break;
                    //case "3":
                    //    db.MultiString<Section>(Constants.GetSection);
                    //    break;
                    //case "4":
                    //    db.MultiString<PromoGoods>(Constants.GetPromoGoods);
                    //    break;
                    //case "5":
                    //    db.MultiString<string>(Constants.GetCity);
                    //    break;
                    //case "6":
                    //    db.MultiString<Countrys>(Constants.GetCountry);
                    //    break;
                    //case "7":
                    //    var param7 = new { city ="Berlin"};
                    //    db.MultiString<Customers>(Constants.GetAllClientsFromCity, param7);
                    //    break;
                    //case "8":
                    //    var param8 = new { country = "Україна" };
                    //    db.MultiString<Customers>(Constants.GetAllClientsFromCountry, param8);
                    //    break;
                    //case "9":
                    //    var param9 = new { country = "Україна" };
                    //    db.MultiString<PromoGoods>(Constants.GetPromoGoodsFromCountry, param9);
                    //    break;
                    //case "10":
                    //    object[] param10 = { new { name = "John Doe", dateOfBirth="2000-01-01", gender = "Чоловіча", email = "jdoe@example.com", country="Німеччина", city="Hannover" } };
                    //    db.Execute(Constants.InsertCustomer, param10);
                    //    break;
                    //case "11":
                    //    object[] param11 = { new { name = "Китай"} };
                    //    db.Execute(Constants.InsertCountry, param11);
                    //    break;
                    //case "12":
                    //    var param12 = new { name = "Новий розділ" };
                    //    db.Execute(Constants.InsertSection, param12);
                    //    break;
                    //case "13":
                    //    object[] param13 = { new { section = "Новий розділ", name = "Новий товар", country = "Німеччина", start_date = "2021-01-01", end_date = "2021-01-31" } };
                    //    db.Execute(Constants.InsertPromoGoods, param13);
                    //    break;
                    //case "14":
                    //    object[] param14 = { new {id=10, name = "John Doe Update", dateOfBirth = "2000-01-01", gender = "Чоловіча", email = "jdoe@example.com", country = "Німеччина", city = "Hannover" } };
                    //    db.Execute(Constants.UpdateCustomer, param14);
                    //    break;
                    //case "15":
                    //    object[] param15 = { new { id= 1003, name = "Китай2" } };
                    //    db.Execute(Constants.UpdateCountry, param15);
                    //    break;
                    //case "16":
                    //    object[] param16 = { new { id = 1002, name = "Новий розділ2" } };
                    //    db.Execute(Constants.UpdateSection, param16);
                    //    break;
                    //case "17":
                    //    object[] param17 = { new { id = 1002, section = "Новий розділ3", name = "Новий товар3", country = "Німеччина", start_date = "2021-01-01", end_date = "2021-01-31" } };
                    //    db.Execute(Constants.UpdatePromoGoods, param17);
                    //    break;
                    //case "18":
                    //    object[] param18 = { new { id = 1007 } };
                    //    db.Execute(Constants.DeleteCustomer, param18);
                    //    break;
                    //case "19":
                    //    object[] param19 = { new { id = 1003 } };
                    //    db.Execute(Constants.DeleteCountry, param19);
                    //    break;
                    //case "20":
                    //    var param20 = new { country = "Україна" };
                    //    db.MultiString<string>(Constants.GetCityFromCountry, param20);
                    //    break;
                    //case "21":
                    //    var param21 = new { id = 1 };
                    //    db.MultiString<string>(Constants.GetSectionfromCustomer, param21);
                    //    break;
                    //case "22":
                    //    var param22 = new { section = "Новий розділ" };
                    //    db.MultiString<PromoGoods>(Constants.GetPromoGoodsFromSection, param22);
                    //    break;

                    case "31":
                        var results1 = db.MultiString(Constants.GetCountCustomersFromCity);
                        foreach (dynamic result in results1)
                        {
                            Console.WriteLine($"CityName: {result.CityName}, CustomerCount: {result.CustomerCount}");
                        }

                        break;
                    case "32":
                        var results2 = db.MultiString(Constants.GetCountCustomersFromCountry);
                        foreach (dynamic result in results2)
                        {
                            Console.WriteLine($"CountryName: {result.CountryName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "33":
                        var results = db.MultiString(Constants.GetCountCityFromCountry);
                        foreach (dynamic result in results)
                        {
                            Console.WriteLine($"CountryName: {result.CountryName}, CityCount: {result.CityCount}");
                        }
                        break;

                    case "34":
                        db.ExecuteScalar(Constants.GetAvgCountCityFromCountry);
                        break;

                    case "35":
                        var param35 = new { country = "Україна" };
                        db.MultiString<string>(Constants.GetSectionFromCountry, param35);
                        break;

                    case "36":
                        var param36 = new { section = "Новий розділ", start_date = "2021-01-01", end_date = "2021-01-31" };
                        db.MultiString<PromoGoods>(Constants.GetPromoGoodsFromSectionFromDate, param36);
                        break;

                    case "37":
                        var param37 = new { id = 1 };
                        db.MultiString<string>(Constants.GetPromoGoodsFromCustomer, param37);
                        break;

                    case "38":
                        var results38 = db.MultiString(Constants.GetTop3CountryByCustomers);
                        foreach (dynamic result in results38)
                        {
                            Console.WriteLine($"CountryName: {result.CountryName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "39":
                        var results39 = db.MultiString(Constants.GetBestCountryByCustomers);
                        foreach (dynamic result in results39)
                        {
                            Console.WriteLine($"CountryName: {result.CountryName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "40":
                        var results40 = db.MultiString(Constants.GetTop3CityByCustomers);
                        foreach (dynamic result in results40)
                        {
                            Console.WriteLine($"CityName: {result.CityName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "41":
                        var results41 = db.MultiString(Constants.GetBestCityByCustomers);
                        foreach (dynamic result in results41)
                        {
                            Console.WriteLine($"CityName: {result.CityName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "42":
                        var results42 = db.MultiString(Constants.Top3PopularSection);
                        foreach (dynamic result in results42)
                        {
                            Console.WriteLine($"SectionName: {result.SectionName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "43":
                        var results43 = db.MultiString(Constants.Top3UnpopularSection);
                        foreach (dynamic result in results43)
                        {
                            Console.WriteLine($"SectionName: {result.SectionName}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "44":
                        var results44 = db.MultiString(Constants.Top3SectionByPromoGoods);
                        foreach (dynamic result in results44)
                        {
                            Console.WriteLine($"SectionName: {result.SectionName}, PromoGoodsCount: {result.PromoGoodsCount}");
                        }
                        break;

                    case "45":
                        var results45 = db.MultiString(Constants.BestSectionByPromoGoods);
                        foreach (dynamic result in results45)
                        {
                            Console.WriteLine($"SectionName: {result.SectionName}, PromoGoodsCount: {result.PromoGoodsCount}");
                        }
                        break;

                    case "46":
                        var results46 = db.MultiString(Constants.Top3SectionByPromoGoods);
                        foreach (dynamic result in results46)
                        {
                            Console.WriteLine($"SectionName: {result.SectionName}, PromoGoodsCount: {result.PromoGoodsCount}");
                        }
                        break;

                    case "47":
                        var results47 = db.MultiString(Constants.GetPromoGoodsFor3days);
                        foreach (dynamic result in results47)
                        {
                            Console.WriteLine($"PromoGoodName: {result.PromoGoodName}, start_date: {result.start_date}, end_date: {result.end_date}");
                        }
                        break;

                    case "48":
                        var results48 = db.MultiString(Constants.GetPromoGoodsForToday);
                        foreach (dynamic result in results48)
                        {
                            Console.WriteLine($"PromoGoodName: {result.PromoGoodName}, start_date: {result.start_date}, end_date: {result.end_date}");
                        }
                        break;

                    case "49":
                        db.Execute(Constants.MoveExpiredPromoGoodsToArchive);
                        break;

                    case "50":
                        var results50 = db.MultiString(Constants.GetAvgAgeBySection);
                        foreach (dynamic result in results50)
                        {
                            Console.WriteLine($"SectionName: {result.SectionName}, AvgAge: {result.AvgAge}");
                        }
                        break;

                    case "51":
                        var results51 = db.MultiString(Constants.GetAvgAgeByCity);
                        foreach (dynamic result in results51)
                        {
                            Console.WriteLine($"CityName: {result.CityName}, AvgAge: {result.AvgAge}");
                        }
                        break;

                    case "52":
                        var results52 = db.MultiString(Constants.GetAvgAgeByCountry);
                        foreach (dynamic result in results52)
                        {
                            Console.WriteLine($"CountryName: {result.CountryName}, AvgAge: {result.AvgAge}");
                        }
                        break;

                    case "53":
                        var results53 = db.MultiString(Constants.GetBestSectionByGender);
                        foreach (dynamic result in results53)
                        {
                            Console.WriteLine($"Gender: {result.gender}, Section: {result.SectionName}, SubscriberCount: {result.SubscriberCount}");
                        }
                        break;

                    case "54":
                        var results54 = db.MultiString(Constants.GetTop3SectionByGender);
                        foreach (dynamic result in results54)
                        {
                            Console.WriteLine($"Gender: {result.gender}, Section: {result.SectionName}, SubscriberCount: {result.SubscriberCount}");
                        }
                        break;

                    case "55":
                        var results55 = db.MultiString(Constants.GetCountCustomersByGender);
                        foreach (dynamic result in results55)
                        {
                            Console.WriteLine($"Gender: {result.gender}, CustomerCount: {result.CustomerCount}");
                        }
                        break;

                    case "56":
                        var results56 = db.MultiString(Constants.GetCountCustomerByGenderByCountry);
                        foreach (dynamic result in results56)
                        {
                            Console.WriteLine($"Gender: {result.gender}, Country: {result.CountryName}, 1CustomerCount: {result.CustomerCount}");
                        }
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
