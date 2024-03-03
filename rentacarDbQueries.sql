DROP TABLE Cars
DROP TABLE Brands
DROP TABLE Colors

CREATE TABLE Brands (
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Name NVARCHAR(100) NOT NULL
)

CREATE TABLE Colors (
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Cars (
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    BrandId INT FOREIGN KEY REFERENCES Brands(Id) NOT NULL,
    ColorId INT FOREIGN KEY REFERENCES Colors(Id) NOT NULL,
    ModelYear INT NOT NULL,
    DailyPrice FLOAT NOT NULL,
    Description NVARCHAR(255) NOT NULL
)

INSERT INTO Brands (Name) VALUES 
('Toyota'),
('Honda'),
('Ford'),
('Mercedes'),
('BMW'),
('TOGG'),
('Hyundai'),
('Fiat'),
('Renault'),
('Dacia')

INSERT INTO Colors (Name) VALUES 
('Red'),
('Blue'),
('Black'),
('Yellow'),
('Green'),
('Gray'),
('White')

INSERT INTO Cars (BrandId, ColorId, ModelYear, DailyPrice, Description) 
VALUES 
(1, 1, 2020, 150.00, 'Toyota Corolla'),
(2, 2, 2018, 200.00, 'Honda Civic'),
(3, 3, 2019, 180.00, 'Ford Focus'),
(4, 4, 2017, 250.00, 'Mercedes C-Class'),
(5, 5, 2019, 300.00, 'BMW 3 Series'),
(6, 6, 2022, 180.00, 'TOGG C-SUV'),
(7, 7, 2016, 150.00, 'Hyundai i20'),
(8, 1, 2015, 120.00, 'Fiat Egea'),
(9, 2, 2017, 130.00, 'Renault Megane'),
(10, 3, 2018, 110.00, 'Dacia Sandero'),
(1, 4, 2019, 200.00, 'Toyota Camry'),
(2, 5, 2020, 220.00, 'Honda Accord'),
(3, 6, 2021, 250.00, 'Ford Mustang'),
(4, 7, 2018, 280.00, 'Mercedes E-Class'),
(5, 1, 2016, 280.00, 'BMW 5 Series'),
(6, 2, 2023, 200.00, 'TOGG C-Hatchback'),
(7, 3, 2018, 150.00, 'Hyundai Tucson'),
(8, 4, 2019, 100.00, 'Fiat Panda'),
(9, 5, 2020, 120.00, 'Renault Captur'),
(10, 6, 2017, 90.00, 'Dacia Logan'),
(1, 7, 2021, 300.00, 'Toyota RAV4'),
(2, 1, 2016, 220.00, 'Honda CR-V'),
(3, 2, 2018, 250.00, 'Ford Explorer'),
(4, 3, 2019, 300.00, 'Mercedes GLE'),
(5, 4, 2020, 350.00, 'BMW X5'),
(6, 5, 2022, 230.00, 'TOGG C-Sedan'),
(7, 6, 2017, 170.00, 'Hyundai i30'),
(8, 7, 2018, 110.00, 'Fiat Tipo'),
(9, 1, 2019, 140.00, 'Renault Clio'),
(10, 2, 2020, 100.00, 'Dacia Duster'),
(1, 3, 2021, 320.00, 'Toyota Highlander'),
(2, 4, 2016, 250.00, 'Honda Jazz'),
(3, 5, 2018, 280.00, 'Ford Fusion'),
(4, 6, 2019, 320.00, 'Mercedes GLA'),
(5, 7, 2020, 380.00, 'BMW X3')