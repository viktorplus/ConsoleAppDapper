using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleAppDapper
{
    public class Constants
    {
        public const string ConnectionString = @"Data Source=HOMEDE\SQLEXPRESS;Initial Catalog=SPAM;Integrated Security=True;Encrypt=False";
        public const string GetAllClients = @"SELECT C.id, C.name, dateOfBirth, gender, email, Co.name AS Country, city FROM Customers C JOIN Сountry Co ON C.countryId = Co.id;";
        public const string GetEmails = @"select email from Customers";
        public const string GetSection = @"select * from Section"; 
        public const string GetPromoGoods = @"SELECT P.id, S.name AS Section, P.name, C.name AS Country, start_date, end_date FROM PromoGoods P JOIN Сountry C ON P.countryId = C.id JOIN Section S ON P.SectionId = S.id;";
        public const string GetCity = @"select city from Customers";
        public const string GetCountry = @"select * from Сountry";
        public const string GetAllClientsFromCity = @"SELECT C.id, C.name, dateOfBirth, gender, email, Co.name AS Country, city FROM Customers C JOIN Сountry Co ON C.countryId = Co.id WHERE city = @city;";
        public const string GetAllClientsFromCountry = @"SELECT C.id, C.name, dateOfBirth, gender, email, Co.name AS Country, city FROM Customers C JOIN Сountry Co ON C.countryId = Co.id WHERE Co.name = @country;";
        public const string GetPromoGoodsFromCountry = @"SELECT P.id, S.name AS Section, P.name, C.name AS Country, start_date, end_date FROM PromoGoods P JOIN Сountry C ON P.countryId = C.id JOIN Section S ON P.SectionId = S.id WHERE C.name = @country;";
        public const string InsertCustomer = @"INSERT INTO Customers (name, dateOfBirth, gender, email, countryId, city) VALUES (@name, @dateOfBirth, @gender, @email, (Select id from Сountry WHERE name= @country), @city);";
        public const string InsertCountry = @"insert into Сountry (name) values(@name)";
        public const string InsertSection = @"insert into Section (name) values(@name)";
        public const string InsertPromoGoods = @"INSERT INTO PromoGoods (sectionId, name, countryId, start_date, end_date) VALUES ((Select id from Section WHERE name= @section), @name, (Select id from Сountry WHERE name= @country), @start_date, @end_date);";
        public const string UpdateCustomer = @"update Customers set name = @name, dateOfBirth = @dateOfBirth, gender = @gender, email = @email, countryId = (Select id from Сountry WHERE name= @country), city=@city WHERE id=@id";
        public const string UpdateCountry = @"update Сountry set name = @name WHERE id=@id";
        public const string UpdateSection = @"update Section set name = @name WHERE id=@id";
        public const string UpdatePromoGoods = @"update PromoGoods set sectionId = (Select id from Section WHERE name= @section), name = @name, countryId = (Select id from Сountry WHERE name= @country), start_date = @start_date, end_date = @end_date WHERE id=@id";
        public const string DeleteCustomer = @"delete from Customers WHERE id=@id";
        public const string DeleteCountry = @"delete from Сountry WHERE id=@id";
        public const string DeleteSection = @"delete from Section WHERE id=@id";
        public const string DeletePromoGoods = @"delete from PromoGoods WHERE id=@id";
        public const string GetCityFromCountry = @"select city from Customers where countryId = (select id from Сountry where name = @country)";
        public const string GetSectionfromCustomer = @"SELECT Section.name AS SectionName FROM Subsribe JOIN Section ON Subsribe.sectionId = Section.id WHERE Subsribe.customerId = @Id";
        public const string GetPromoGoodsFromSection = @"SELECT * FROM PromoGoods P JOIN Section S ON P.sectionId = S.id WHERE S.name = @section";
        public const string GetCountCustomersFromCity = @"SELECT city AS CityName, COUNT(*) AS CustomerCount FROM Customers GROUP BY city;";
        public const string GetCountCustomersFromCountry = @"SELECT Сountry.name AS CountryName, COUNT(*) AS CustomerCount FROM Сountry JOIN Customers ON Сountry.id = Customers.countryId GROUP BY Сountry.name;";
        public const string GetCountCityFromCountry = @"SELECT Сountry.name AS CountryName, COUNT(DISTINCT city) AS CityCount FROM Customers JOIN Сountry ON Customers.countryId = Сountry.id GROUP BY Сountry.name;";
        public const string GetAvgCountCityFromCountry = @"SELECT AVG(CAST(CityCount AS FLOAT)) AS AverageCityCount FROM (SELECT countryId, COUNT(DISTINCT city) AS CityCount FROM Customers GROUP BY countryId) AS CityCounts;";
        public const string GetSectionFromCountry = @"SELECT Section.name AS SectionName FROM PromoGoods JOIN Section ON PromoGoods.sectionId = Section.id JOIN Сountry ON PromoGoods.countryId = Сountry.id WHERE Сountry.name = @country;";
        public const string GetPromoGoodsFromSectionFromDate = @"SELECT * FROM PromoGoods P JOIN Section S ON P.sectionId = S.id WHERE S.name = @section AND start_date >= @start_date AND end_date <= @end_date;";
        public const string GetPromoGoodsFromCustomer = @"SELECT P.name AS PromoGoodsName FROM PromoGoods P JOIN Subsribe S ON P.sectionId = S.sectionId WHERE S.customerId = @Id;";
        public const string GetTop3CountryByCustomers = @"SELECT TOP 3 Сountry.name AS CountryName, COUNT(*) AS CustomerCount FROM Сountry JOIN Customers ON Сountry.id = Customers.countryId GROUP BY Сountry.name ORDER BY CustomerCount DESC;";
        public const string GetBestCountryByCustomers = @"SELECT TOP 1 Сountry.name AS CountryName, COUNT(*) AS CustomerCount FROM Сountry JOIN Customers ON Сountry.id = Customers.countryId GROUP BY Сountry.name ORDER BY CustomerCount DESC;";
        public const string GetTop3CityByCustomers = @"SELECT TOP 3 city AS CityName, COUNT(*) AS CustomerCount FROM Customers GROUP BY city ORDER BY CustomerCount DESC;";
        public const string GetBestCityByCustomers = @"SELECT TOP 1 city AS CityName, COUNT(*) AS CustomerCount FROM Customers GROUP BY city ORDER BY CustomerCount DESC;";
        public const string Top3PopularSection = @"SELECT TOP 3 Section.name AS SectionName, COUNT(*) AS CustomerCount FROM Customers JOIN Subsribe ON Customers.id = Subsribe.customerId JOIN Section ON Subsribe.sectionId = Section.id GROUP BY Section.name ORDER BY CustomerCount DESC;";
        public const string Top3UnpopularSection = @"SELECT TOP 3 Section.name AS SectionName, COUNT(*) AS CustomerCount FROM Customers JOIN Subsribe ON Customers.id = Subsribe.customerId JOIN Section ON Subsribe.sectionId = Section.id GROUP BY Section.name ORDER BY CustomerCount ASC;";




        public const string GetPromoGoodsFor3days = @"SELECT id, name AS PromoGoodName, start_date, end_date FROM PromoGoods WHERE DATEDIFF(day, GETDATE(), end_date) = 3;";


    }
}
/*
 --CREATE DATABASE SPAM;

USE SPAM;
--CREATE DATABASE SPAM;

USE SPAM;
-- Таблиця розділів товарів
CREATE TABLE Section (
    id INT PRIMARY KEY IDENTITY(1,1


    name NVARCHAR(255) NOT NULL
);

-- Таблиця Країн
CREATE TABLE Сountry (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL
);

-- Таблиця покупців
CREATE TABLE Customers (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    dateOfBirth DATE NOT NULL,
    gender NVARCHAR(10) NOT NULL,
    email NVARCHAR(255) UNIQUE NOT NULL,
    countryId int NOT NULL,
    city NVARCHAR(255) NOT NULL
	FOREIGN KEY (countryId) REFERENCES Сountry(id)
);

-- Таблиця вподобань користувача
CREATE TABLE Subsribe (
    id INT PRIMARY KEY IDENTITY(1,1),
	customerId INT,
	sectionId INT,
	FOREIGN KEY (sectionId) REFERENCES Section(id),
	FOREIGN KEY (customerId) REFERENCES Customers(id)
);

-- Таблиця акційних товарів
CREATE TABLE PromoGoods (
    id INT PRIMARY KEY IDENTITY(1,1),
    sectionId INT,
	name NVARCHAR(255) NOT NULL,
	countryId int NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
	FOREIGN KEY (sectionId) REFERENCES Section(id),
	FOREIGN KEY (countryId) REFERENCES Сountry(id)
);
*/

/*
 --Таблиця країн (Сountry):

INSERT INTO Сountry (name)
VALUES 
    ('Україна'),
    ('Німеччина');

 --Таблиця покупців (Customers):

INSERT INTO Customers (name, dateOfBirth, gender, email, countryId, city)
VALUES 
    ('Іван Петров', '1990-01-15', 'Чоловіча', 'ivan@gmail.com', 1, 'Київ'),
    ('Марія Сидорова', '1985-05-20', 'Жіноча', 'maria@gmail.com', 1, 'Львів'),
    ('Олексій Іванов', '1993-09-10', 'Чоловіча', 'oleksiy@gmail.com', 2, 'Duselldorf'),
    ('Тетяна Коваленко', '1988-03-25', 'Жіноча', 'tetyana@gmail.com', 1, 'Одеса'),
    ('Андрій Лисенко', '1995-11-08', 'Чоловіча', 'andriy@gmail.com', 2, 'Munhen'),
    ('Юлія Мельник', '1980-07-12', 'Жіноча', 'yulia@gmail.com', 1, 'Berlin'),
    ('Сергій Кузьменко', '1992-04-18', 'Чоловіча', 'sergiy@gmail.com', 1, 'Івано-Франківськ'),
    ('Ольга Савченко', '1983-12-30', 'Жіноча', 'olga@gmail.com', 2, 'Berlin'),
    ('Дмитро Григоренко', '1987-08-05', 'Чоловіча', 'dmitro@gmail.com', 1, 'Хмельницький'),
    ('Наталія Козлова', '1998-02-22', 'Жіноча', 'natalia@gmail.com', 2, 'Berlin');
--Таблиця розділів товарів (Section):

INSERT INTO Section (name)
VALUES 
    ('Електроніка'),
    ('Одяг'),
    ('Косметика'),
    ('Їжа'),
    ('Меблі'),
    ('Спорт'),
    ('Книги'),
    ('Інструменти'),
    ('Автозапчастини'),
    ('Подарунки');
--Таблиця вподобань користувача (Subsribe):

INSERT INTO Subsribe (customerId, sectionId)
VALUES 
    (1, 3),
    (2, 1),
    (3, 5),
    (4, 2),
    (5, 6),
    (6, 4),
    (7, 7),
    (8, 9),
    (9, 8),
    (10, 10);
--Таблиця акційних товарів (PromoGoods):

INSERT INTO PromoGoods (sectionId, name, countryId, start_date, end_date)
VALUES 
    (1, 'Смартфон Samsung Galaxy', 1, '2024-01-10', '2024-02-10'),
    (2, 'Куртка Levis', 1, '2024-02-15', '2024-03-15'),
    (3, 'Набір косметики Chanel', 2, '2024-03-20', '2024-04-20'),
    (4, 'Кошик з продуктами', 1, '2024-04-25', '2024-05-25'),
    (5, 'Диван-ліжко', 1, '2024-05-30', '2024-06-30'),
    (6, 'Велосипед Merida', 2, '2024-06-05', '2024-07-05'),
    (7, 'Книга "Майстер і Маргарита"', 1, '2024-07-10', '2024-08-10'),
    (8, 'Електроінструмент DeWalt', 2, '2024-08-15', '2024-09-15'),
    (9, 'Запчастини для авто', 1, '2024-09-20', '2024-10-20'),
    (10, 'Набір подарунків', 1, '2024-10-25', '2024-11-25');
*/