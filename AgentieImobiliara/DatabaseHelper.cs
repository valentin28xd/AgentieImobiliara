using System;
using System.Data.SqlClient;
using System.Configuration;

namespace AgentieImobiliara
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AgentieImobiliaraConnectionString"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            CreateTables();
        }

        private static void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"
IF OBJECT_ID('Angajati', 'U') IS NULL
BEGIN
    CREATE TABLE Angajati (
        ID_Angajat INT IDENTITY(1,1) PRIMARY KEY,
        Nume NVARCHAR(50) NOT NULL,
        Prenume NVARCHAR(50) NOT NULL,
        CNP NVARCHAR(13),
        Adresa NVARCHAR(100),
        Telefon NVARCHAR(20),
        Email NVARCHAR(50),
        Data_Angajare DATE,
        Salariu_Baza DECIMAL(18,2)
    );
END";
                    command.ExecuteNonQuery();

                    command.CommandText = @"
IF OBJECT_ID('Clienti', 'U') IS NULL
BEGIN
    CREATE TABLE Clienti (
        ID_Client INT IDENTITY(1,1) PRIMARY KEY,
        Nume NVARCHAR(50) NOT NULL,
        Prenume NVARCHAR(50) NOT NULL,
        CNP NVARCHAR(13),
        Adresa NVARCHAR(100),
        Telefon NVARCHAR(20),
        Email NVARCHAR(50),
        Tip_Client NVARCHAR(20)
    );
END";
                    command.ExecuteNonQuery();

                    command.CommandText = @"
IF OBJECT_ID('Imobile', 'U') IS NULL
BEGIN
    CREATE TABLE Imobile (
        ID_Imobil INT IDENTITY(1,1) PRIMARY KEY,
        Tip NVARCHAR(50),
        Localitate NVARCHAR(50),
        Adresa NVARCHAR(100),
        Etaj INT,
        Suprafata FLOAT,
        Telefon NVARCHAR(20),
        Imbunatatiri NVARCHAR(200),
        Pret_Solicitat DECIMAL(18,2),
        Status NVARCHAR(20)
    );
END";
                    command.ExecuteNonQuery();

                    command.CommandText = @"
IF OBJECT_ID('Oferte', 'U') IS NULL
BEGIN
    CREATE TABLE Oferte (
        ID_Oferta INT IDENTITY(1,1) PRIMARY KEY,
        ID_Imobil INT,
        ID_Client INT,
        ID_Agent INT,
        Tip_Oferta NVARCHAR(20),
        Data_Adaugare DATE,
        Tarif_Luna DECIMAL(18,2),
        Numar_Luni_Minim INT,
        Numar_Luni_Maxim INT,
        FOREIGN KEY(ID_Imobil) REFERENCES Imobile(ID_Imobil),
        FOREIGN KEY(ID_Client) REFERENCES Clienti(ID_Client),
        FOREIGN KEY(ID_Agent) REFERENCES Angajati(ID_Angajat)
    );
END";
                    command.ExecuteNonQuery();

                    command.CommandText = @"
IF OBJECT_ID('Contracte', 'U') IS NULL
BEGIN
    CREATE TABLE Contracte (
        ID_Contract INT IDENTITY(1,1) PRIMARY KEY,
        ID_Oferta INT,
        ID_Client_Cumparator INT,
        ID_Agent INT,
        Data_Contract DATE,
        Valoare_Tranzactie DECIMAL(18,2),
        Comision_Firma DECIMAL(18,2),
        Comision_Agent DECIMAL(18,2),
        FOREIGN KEY(ID_Oferta) REFERENCES Oferte(ID_Oferta),
        FOREIGN KEY(ID_Client_Cumparator) REFERENCES Clienti(ID_Client),
        FOREIGN KEY(ID_Agent) REFERENCES Angajati(ID_Angajat)
    );
END";
                    command.ExecuteNonQuery();

                    command.CommandText = @"
IF OBJECT_ID('Salarii', 'U') IS NULL
BEGIN
    CREATE TABLE Salarii (
        ID_Plata INT IDENTITY(1,1) PRIMARY KEY,
        ID_Angajat INT,
        Luna INT,
        Anul INT,
        Salariu_Baza DECIMAL(18,2),
        Comisioane DECIMAL(18,2),
        Prime DECIMAL(18,2),
        Total_Plata DECIMAL(18,2),
        FOREIGN KEY(ID_Angajat) REFERENCES Angajati(ID_Angajat)
    );
END";
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
