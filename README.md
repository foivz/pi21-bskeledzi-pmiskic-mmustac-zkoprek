Iznajmljivanje automobila


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Boris Skeledžija | bskeledzi@foi.hr | 0016140129 | FalzoNe007
Petar Miškić | pmiskic@foi.hr | 0016140059 | pmiskic
Mateo Mustać | mmustac@foi.hr | 0016138017 | mmustac332
Zvonimir Koprek | zkoprek@foi.hr | 0016135996 | zkoprek

## Opis domene
Domena aplikacije je prodaja aplikacije u više različitih tvrtki koje se bave iznajmljivanjem automobila. Ova aplikacija omogućava iznajmljivanje automobila kupcu, odabir automobila te njegovih karakteristika, odabir lokacije na kojoj će se pokupiti automobil, naručivanje same rezervacije gdje kupac specificira lokaciju, datum, tip automobila koji želi i sl. Isto tako, kupac može uzeti osiguranje, ali i ne mora ako već ima osiguranje na svoju tvrtku ili kreditnu karticu. Središte aplikacijske domene je iznajmljivanje automobila na koji se vežu entiteti poput kupac, automobil i lokacija.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava zaposlenika, admina ili kupca |Prije korištenja aplikacije se korisnik treba prijaviti kao zaposlenik, admin ili pristupiti kao kupac.| Boris Skeledžija
F02 | Iznajmljivanje automobila |Potencijalni kupac pregledava sve automobile dostupne za rezervaciju u željenom terminu.Kupac vidi koliki su troškovi za rezervaciju, iznajmljivanje te ostalo. Od ponuđenih gradova i lokacija u njima kupac odabire. | Petar Miškić
F03 | Dodavanje i brisanje zaposlenika, lokacija, automobila | Admin ima mogućnost dodavanja ili brisanja zaposlenika, lokacija, automobila te upravljanjima ovlastima i ulogama u aplikaciji | Mateo Mustać
F04 | Obavijesti | Zaposlenik dobiva obavijesti o prijavi kvara, rezervaciji, upitima i sl. Kada zaposlenik potvrdi rezervaciju, kupac prima obavijest o uspješnoj rezervaciji. Moguće je i kad je aplikacija ugašena.  | Petar Miškić
F05 | Upiti | Kupac može slati upite o lokacijama, rezervaciji, bilo čemu što ga zanima. Na upite odgovara zaposlenik. Obavijesti se dobivaju i kad je aplikacija ugašena | Boris Skeledžija
F06 | Način plaćanja | Kupac odabire način plaćanja, ima opciju slanja podataka o plaćanju na e-mail u obliku PDF-a. Postoji i dodatak 2D QR-Code. | Zvonimir Koprek
F07 | Upis podataka o dolasku | Kupac upisuje podatke i termin svog dolaska. Kupac dobiva obavijest dan prije dolaska rezervacije. | Mateo Mustać
F08 | Evidencija | Admin/Zaposlenik imaju mogućnost pregleda automobila, lokacija, zaposlenika. | Zvonimir Koprek
F09 | Pregled statistike | Zaposlenici mogu vidjeti statistiku sa grafovima i tablicama. Izvješće se može izvesti u PDF-u. | Skeledžija


## Tehnologije i oprema
.NET Framework/Core, GitHub, GitHub Classroom, Word, MSSQL, Draw.io, Visual Paradigm, C#, Windows Servisi.
