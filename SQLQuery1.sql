CREATE TABLE [dbo].[Contracte]
(
    [ID_Contract] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [ID_Oferta] INT NOT NULL,
    [ID_Client_Cumparator] INT NOT NULL,
    [Data_Contract] DATE NOT NULL,
    [Valoare_Tranzactie] DECIMAL(18,2) NOT NULL,
    [Comision_Agent] DECIMAL(18,2) NOT NULL,
    FOREIGN KEY ([ID_Oferta]) REFERENCES [Oferte]([ID_Oferta]),
    FOREIGN KEY ([ID_Client_Cumparator]) REFERENCES [Clienti]([ID_Client])
);