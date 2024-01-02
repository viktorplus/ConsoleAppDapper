using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    public class Constants
    {
        public const string ConnectionString = @"Data Source=HOMEDE\SQLEXPRESS;Initial Catalog=SPAM;Integrated Security=True;Encrypt=False";
        public const string GetAllClients = @"select * from Customers";
        public const string GetEmails = @"select email from Customers";
        public const string GetSection = @"select * from Section";
        public const string GetPromoGoods = @"select * from PromoGoods";

    }
}
/*--CREATE DATABASE SPAM;

USE SPAM;
-- Таблиця покупців
CREATE TABLE Customers (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    dateOfBirth DATE NOT NULL,
    gender NVARCHAR(10) NOT NULL,
    email NVARCHAR(255) UNIQUE NOT NULL,
    country NVARCHAR(255) NOT NULL,
    city NVARCHAR(255) NOT NULL
);

-- Таблиця розділів товарів
CREATE TABLE Section (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
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
	country NVARCHAR(255) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
	FOREIGN KEY (sectionId) REFERENCES Section(id)
);*/

/*--Таблиця покупців (Customers):



INSERT INTO Customers (name, dateOfBirth, gender, email, country, city)
VALUES 
    ('Іван Петров', '1990-01-15', 'Чоловіча', 'ivan@gmail.com', 'Україна', 'Київ'),
    ('Марія Сидорова', '1985-05-20', 'Жіноча', 'maria@gmail.com', 'Україна', 'Львів'),
    ('Олексій Іванов', '1993-09-10', 'Чоловіча', 'oleksiy@gmail.com', 'Україна', 'Харків'),
    ('Тетяна Коваленко', '1988-03-25', 'Жіноча', 'tetyana@gmail.com', 'Україна', 'Одеса'),
    ('Андрій Лисенко', '1995-11-08', 'Чоловіча', 'andriy@gmail.com', 'Україна', 'Дніпро'),
    ('Юлія Мельник', '1980-07-12', 'Жіноча', 'yulia@gmail.com', 'Україна', 'Запоріжжя'),
    ('Сергій Кузьменко', '1992-04-18', 'Чоловіча', 'sergiy@gmail.com', 'Україна', 'Івано-Франківськ'),
    ('Ольга Савченко', '1983-12-30', 'Жіноча', 'olga@gmail.com', 'Україна', 'Чернігів'),
    ('Дмитро Григоренко', '1987-08-05', 'Чоловіча', 'dmitro@gmail.com', 'Україна', 'Хмельницький'),
    ('Наталія Козлова', '1998-02-22', 'Жіноча', 'natalia@gmail.com', 'Україна', 'Луцьк');
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

INSERT INTO PromoGoods (sectionId, name, country, start_date, end_date)
VALUES 
    (1, 'Смартфон Samsung Galaxy', 'Україна', '2024-01-10', '2024-02-10'),
    (2, 'Куртка Levi\'s', 'Україна', '2024-02-15', '2024-03-15'),
    (3, 'Набір косметики Chanel', 'Франція', '2024-03-20', '2024-04-20'),
    (4, 'Кошик з продуктами', 'Україна', '2024-04-25', '2024-05-25'),
    (5, 'Диван-ліжко', 'Україна', '2024-05-30', '2024-06-30'),
    (6, 'Велосипед Merida', 'Тайвань', '2024-06-05', '2024-07-05'),
    (7, 'Книга "Майстер і Маргарита"', 'Росія', '2024-07-10', '2024-08-10'),
    (8, 'Електроінструмент DeWalt', 'США', '2024-08-15', '2024-09-15'),
    (9, 'Запчастини для авто', 'Україна', '2024-09-20', '2024-10-20'),
    (10, 'Набір подарунків', 'Україна', '2024-10-25', '2024-11-25');
*/