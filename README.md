# WSEI-Printy

## 1. Opis Biznesowy
Aplikacja, która umożliwia drukowanie u osób prywatnych. Klienci którzy chcą coś wydrukować będą mogli się skontaktować z posiadaczami drukarek w aplikacji i wydrukować coś dla siebie.

## 2. Funkcjonalności
* ### Autoryzacja
  * Logowanie
    * Użytkownik jest w stanie zalogować się na wcześniej utworzone konto podając email i hasło
  * Rejestracja
    * Użytkownik jest w stanie utworzyć własne konto w aplikacji
* ### Moduł drukarek
  * Przeglądanie drukarek
    * Użytkownik ma możliwość przeglądania listy dostępnych drukarek dodanych przez innych użytkowników
    * Użytkownik ma możliwość przejścia do informacji o drukarce
  * Szczegóły drukarki
    * Użytkownik ma możliwość wybrać dodaną drukarkę i przejść do jej podstrony z informacjami
    * Użytkownik ma możliwość zrobienia zamówienie wybierając daną drukarkę
  * Dodawanie drukarki
    * **Wymaga autoryzacji**
    * Użytkownik ma możliwość dodania własnej drukarki i udostępnienia jej innym
  * Wybór drukarki i robienie zamówienia
    * **Wymaga autoryzacji**
    * Użytkownik jest w stanie dodać i wysłać pliki aby zostały wydrukowane przez innego użytkownika
* ### Zamówienia
  * Przeglądanie
    * **Wymaga autoryzacji**
    * Użytkownik jest w stanie przeglądać wcześniej wysłane dokumenty do wydrukowania
    * Użytkownik jest w stanie przejść do szczegółów drukarki u której wcześniej zrobić zamówienie

## 3. Procedura Zbudowania aplikacji
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
