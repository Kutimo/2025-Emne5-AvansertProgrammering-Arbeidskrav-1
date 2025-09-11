# To-Do List for REST API Bokhandel Project

## Krav

### Modell
- [x] Opprett en klasse kalt `Book` med følgende egenskaper:
    - [x] `Id` (int): En unik identifikator for boken.
    - [x] `Title` (string): Bokens tittel.
    - [x] `Author` (string): Forfatteren av boken.
    - [x] `PublicationYear` (int): Året boken ble publisert.
    - [x] `ISBN` (string): Den internasjonale standardboknummeret for 
      boken.
    - [x] `InStock` (int): Mengden av denne boken som er tilgjengelig i 
      bokhandelen.

### Database
- [x] Opprett en enkel database (SQL Server eller MySQL).
- [x] Lag en tabell som representerer `Book`.
- [x] Bruk ADO.NET for å koble til databasen og utføre CRUD-operasjoner.

### API Endepunkter
- [x] `GET /books` → Returnerer en liste over alle bøker.
- [x] `GET /books/{id}` → Returnerer en bok basert på ID.
- [x] `POST /books` → Legger til en ny bok.
- [x] `PUT /books/{id}` → Oppdaterer en eksisterende bok basert på ID.
- [x] `DELETE /books/{id}` → Sletter en bok basert på ID.

## Instruksjoner
- [x] Opprett en ny ASP.NET Core minimal API-applikasjon.
- [x] Design databasen og opprett den med MySQL script.
- [x] Implementer CRUD-operasjoner med ADO.NET.
- [x] Legg til de nødvendige endepunktene i APIet.
- [x] Test APIet med Postman, Swagger, IDE HTTP-verktøy eller nettleser.

## Dokumentasjon
- [x] Dokumenter forespørsler og svar med KI (hvis brukt).
- [x] Inkluder dette i `README.md` eller egen fil.
- [x] Alternativt: oppgi at KI ikke ble brukt.