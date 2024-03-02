DROP TABLE Cars
DROP TABLE Brands
DROP TABLE Colors

CREATE TABLE Brands (
    Id INT PRIMARY KEY NOT NULL,
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Colors (
    Id INT PRIMARY KEY NOT NULL,
    Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Cars (
    Id INT PRIMARY KEY NOT NULL,
    BrandId INT FOREIGN KEY REFERENCES Brands(Id) NOT NULL,
    ColorId INT FOREIGN KEY REFERENCES Colors(Id) NOT NULL,
    ModelYear INT NOT NULL,
    DailyPrice FLOAT NOT NULL,
    Description NVARCHAR(255) NOT NULL
);

INSERT INTO Brands (Id, Name) VALUES 
(1, 'Toyota'),
(2, 'Honda'),
(3, 'Ford'),
(4, 'Mercedes'),
(5, 'BMW'),
(6, 'TOGG'),
(7, 'Hyundai'),
(8, 'Fiat'),
(9, 'Renault'),
(10, 'Dacia')

INSERT INTO Colors (Id, Name) VALUES 
(1, 'Red'),
(2, 'Blue'),
(3, 'Black'),
(4, 'Yellow'),
(5, 'Green'),
(6, 'Gray'),
(7, 'White')

INSERT INTO Cars (Id, BrandId, ColorId, ModelYear, DailyPrice, Description) 
VALUES 
(1, 1, 1, 2020, 150.00, 'Toyota Corolla'),
(2, 2, 2, 2018, 200.00, 'Honda Civic'),
(3, 3, 3, 2019, 180.00, 'Ford Focus'),
(4, 4, 4, 2017, 250.00, 'Mercedes C-Class'),
(5, 5, 5, 2019, 300.00, 'BMW 3 Series'),
(6, 6, 6, 2022, 180.00, 'TOGG C-SUV'),
(7, 7, 7, 2016, 150.00, 'Hyundai i20'),
(8, 8, 1, 2015, 120.00, 'Fiat Egea'),
(9, 9, 2, 2017, 130.00, 'Renault Megane'),
(10, 10, 3, 2018, 110.00, 'Dacia Sandero'),
(11, 1, 4, 2019, 200.00, 'Toyota Camry'),
(12, 2, 5, 2020, 220.00, 'Honda Accord'),
(13, 3, 6, 2021, 250.00, 'Ford Mustang'),
(14, 4, 7, 2018, 280.00, 'Mercedes E-Class'),
(15, 5, 1, 2016, 280.00, 'BMW 5 Series'),
(16, 6, 2, 2023, 200.00, 'TOGG C-Hatchback'),
(17, 7, 3, 2018, 150.00, 'Hyundai Tucson'),
(18, 8, 4, 2019, 100.00, 'Fiat Panda'),
(19, 9, 5, 2020, 120.00, 'Renault Captur'),
(20, 10, 6, 2017, 90.00, 'Dacia Logan'),
(21, 1, 7, 2021, 300.00, 'Toyota RAV4'),
(22, 2, 1, 2016, 220.00, 'Honda CR-V'),
(23, 3, 2, 2018, 250.00, 'Ford Explorer'),
(24, 4, 3, 2019, 300.00, 'Mercedes GLE'),
(25, 5, 4, 2020, 350.00, 'BMW X5'),
(26, 6, 5, 2022, 230.00, 'TOGG C-Sedan'),
(27, 7, 6, 2017, 170.00, 'Hyundai i30'),
(28, 8, 7, 2018, 110.00, 'Fiat Tipo'),
(29, 9, 1, 2019, 140.00, 'Renault Clio'),
(30, 10, 2, 2020, 100.00, 'Dacia Duster'),
(31, 1, 3, 2021, 320.00, 'Toyota Highlander'),
(32, 2, 4, 2016, 250.00, 'Honda Jazz'),
(33, 3, 5, 2018, 280.00, 'Ford Fusion'),
(34, 4, 6, 2019, 320.00, 'Mercedes GLA'),
(35, 5, 7, 2020, 380.00, 'BMW X3');