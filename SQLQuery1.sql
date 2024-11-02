CREATE TABLE Providers (
    ProviderId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL CHECK (LEN(Name) BETWEEN 3 AND 100),
    Address NVARCHAR(200) NOT NULL CHECK (LEN(Address) BETWEEN 5 AND 200),
    PhoneNumber NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) NOT NULL CHECK (Email LIKE '%@%.%')
);

-- Agregar una restricción para validar el formato de número de teléfono
ALTER TABLE Providers
ADD CONSTRAINT CK_Providers_PhoneNumber CHECK (PhoneNumber LIKE '[0-9]%');

-- Agregar una restricción para validar el formato de correo electrónico
ALTER TABLE Providers
ADD CONSTRAINT CK_Providers_EmailFormat CHECK (Email LIKE '%@%.%');