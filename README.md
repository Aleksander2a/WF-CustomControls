# Struktura projektu
Ważniejsze elementy
```text
|
|\
| README.md
|\
| TestApp - aplikacja testowa dla obu kontrolek
| |\
| | Migrations - katalog wygenerowany przez Entity Framework
| |\
| | BusinessLogic - katalog dostępu i operacji na danych
| |\
| | Data
|   |\
|   | Models - katalog z klasami reprezentującymi tabele w bazie danych
|   |\
|   | AppContext.cs - klasa dziedzicząca po DbContext (zawiera parametry połączenia z bazą danych)
|\
| WindowsFormsControlLibrary1 - kontrolka walidacji hasła, zadanie 1
|\
| WindowsFormsControlLibrary2 - kontrolka scheduler tygodniowy, zadanie 2
```
# Utworzenie lokalnej bazy danych
Przed pierwszym uruchomieniem nalezy stworzyc lokalna baze danych poprzez polecenia:
```
add-migration ControlsAppDB
```
```
update-database
```
