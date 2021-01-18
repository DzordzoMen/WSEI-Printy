# WSEI-Printy

## 1. Procedura Zbudowania aplikacji
* ### Back-end
  * ### Technologia
    * .Net Core 3.1
    * EntityFrameworkCore 3.1.10
    * EntityFrameworkCore Design 3.1.10
    * EntityFrameworkCore SqlServer 3.1.10
* ### Front-end
  * ### Technologia
    * Razor
    * Bootstrap
* ### Bazy Danych - SQL Server
  * ### Printers
    * Id - **[PrimaryKey]** Int
    * Name - String
    * Description - String
    * Email - String
    * PhoneNumber - String
  * ### PrintService
    * Id - **[PrimaryKey]** Int
    * PrinterId - **[ForeignKey]** Int
    * PrintSize - Int
    * PrintColor - Int
    * PrintMaterial - Int
    * Price - Decimal
  * ### Users
    * Id - **[PrimaryKey]** Int
    * Name - String
    * Surname - String
    * Email - String
    * Password - String
  * ### Orders
    * Id - **[PrimaryKey]** Int
    * UserId - **[ForeignKey]** Int
    * PrinterId - **[ForeignKey]** Int
    * UserFile - String
    * FileCopies - Int
* ### Klasy
  * ### User
    * Id - Klucz główny
    * Name
    * Surname
    * Email
    * Password
  * ### Printer
    * Id - Klucz główny
    * Name
    * Description
    * Email
    * PhoneNumber
    * Services - Lista `<PrinterService>`
  * ### PrinterService
    * Id - Klucz główny
    * PrintSize - Enum
    * PrintColor - Enum
    * PrintMaterial - Enum
    * Price
  * ### UserOrder
    * Id - Klucz głowny
    * UserId - Klucz obcy klasy _User_
    * PrinterId - Klucz obcy klasy _Printer_
    * UserFile
    * FileCopies
