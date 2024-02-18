# WinForms Food order app/ Aplikacija za naručivanje hrane
## Eng
This is an application that simulates ordering food from a restaurant. There are two types of users: client and admin. When starting the application, the user has the option to log in to an existing account or create a new one.
All data is serialized locally in binary files. The entire logic simulating the database operation is done manually. The client can filter their orders by date. The program is written in the Serbian language.

#### Administration - includes updating the following data:
- Restaurant - ID, name, address, contact phone;
- Dish - ID, name, weight, description, price, ID side dish, ID restaurant, extras;
- Side Dish - ID, side dish name, price;
- Extra - ID, extra name, price, weight;
- User - ID, name, surname, username, password, user type (admin/client);
- Reservation - ID, user ID, code, total price, ordered dishes.

#### Client:
- After logging in, a form opens listing all valid orders for the current date, as well as options for deleting, changing, and adding new orders. It is possible to view order details as needed;
- When adding an order, the client has the option to filter restaurants by the name of the dish. First, the restaurant is selected, and then dishes from the chosen restaurant;
- In the form for adding a new order, the client enters information about dishes, side dishes, and extras they want to order. One dish can have a maximum of 3 extras; extras are optional;
- There are dishes where a side dish is mandatory (e.g., if ordering pasta, a type of pasta must be selected) and others where it is not (e.g., ordering pizza);
- The field displaying the total order price for the selected criteria cannot be changed;
- After a successful order, the client is redirected to the initial form of the client application.




## Srb
Aplikacija koja simulira naručivanje hrane iz restorana. Postoje dva tipa korisnika, klijent i admin. Pri pokretanju aplikacije, korisnik ima mogućnost da se prijavi na već postojeći nalog ili da kreira novi.
Svi podaci su serijalizovani lokalno u binarnim fajlovima. Čitava logika koja simulira rad baze podataka je rađena ručno. Klijent ima mogućnost filtriranja svojih porudžbina po datumu. Program je napisan na srpskom jeziku.

#### Administracija - obuhvata ažuriranje sledećih podataka:
- Restoran - ID, naziv, adresa, kontakt telefon;
- Jelo - ID, naziv, gramaža, opis, cena, ID prilog, ID restoran, dodaci;
- Prilog - ID, naziv priloga, cena;
- Dodatak - ID, naziv dodatka, cena, gramaža;
- Korisnik - ID, ime, prezime, korisničko ime, lozinka, vrsta korisnika (admin/klijent);
- Rezervacija - ID, ID korisnik, šifra, ukupna cena, poručena jela.
#### Klijent:
- Nakon prijave, otvara se forma koja izlistava sve važeće porudžbine za tekući datum, kao i
opcije za njihovo brisanje, promenu i dodavanje nove. Moguće je videti detalje porudžbine po potrebi;
- Prilikom dodavanja porudžbine klijent ima mogućnost filtriranja restorana po nazivu jela.
Prvo se bira restoran, pa onda jela iz odabranog restorana;
- U formi za dodavanje nove porudžbine, klijent unosi podatke o jelima, prilozima i dodacima
koje hoće da poruči. Jedno jelo može imati maksimalno 3 dodatka; dodaci su proizvoljni;
- Postoje jela kod kojih je prilog obavezan (npr. ako se poručuje pasta, mora da se odabere tip makarona) i kod kojih nije (npr. poručuje se pizza);
- Polje koje prikazuje ukupnu cenu porudžbine za odabrane kriterijume se ne može menjati;
- Nakon uspešne porudžbine, klijent se preusmerava na početnu formu aplikacije za klijente.
