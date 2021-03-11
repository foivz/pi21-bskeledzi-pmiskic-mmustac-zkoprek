# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta - Iznajmljivanje automobila


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Boris Skeledžija | bskeledzi@foi.hr | 0016140129 | FalzoNe007
Petar Miškić | pmiskic@foi.hr | 0016140059 | pmiskic
Mateo Mustać | mmustac@foi.hr | 0016138017 | mmustac332
Zvonimir Koprek | zkoprek@foi.hr | 0016135996 | zkoprek

## Opis domene
Domena aplikacije je tvrtka koja iznajmljuje automobile. Ova aplikacija omogućava iznajmljivanje automobila kupcu, odabir automobila te njegovih karakteristika, odabir lokacije na kojoj će se pokupiti automobil, naručivanje same rezervacije gdje kupac specificira lokaciju, datum, tip automobila koji želi i sl. Isto tako, kupac može uzeti osiguranje, ali i ne mora ako već ima osiguranje na svoju tvrtku ili kreditnu karticu. Središte aplikacijske domene je iznajmljivanje automobila na koji se vežu entiteti poput kupac, automobil i lokacija.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava zaposlenika, admina ili kupca |Prije korištenja aplikacije se korisnik treba prijaviti kao zaposlenik, admin ili pristupiti kao kupac.| Boris Skeledžija
F02 | Pregled automobila |Potencijalni kupac pregledava sve automobile dostupne za rezervaciju u željenom terminu. | Zvonimir Koprek
F03 | Pregled tipa opreme automobila | Kupac pregledava dostupne tipove opreme te samu opremu za svaki tip. | Petar Miškić
F04 | Iznajmljivanje osiguranja | Kupac može iznajmiti osiguranje u slučaju ako ga nema. | Mateo Mustać
F05 | Pregled troškova i dodatnih troškova | Kupac vidi koliki su troškovi za rezervaciju, iznajmljivanje te ostalo. | Petar Miškić
F06 | Odabir grada te lokacije | Od ponuđenih gradova i lokacija u njima kupac odabire. | Boris Skeledžija
F07 | Dodavanje i brisanje zaposlenika | Admin ima mogućnost dodavanja ili brisanja zaposlenika. | Mateo Mustać
F08 | Obavijesti | Zaposlenik dobiva obavijesti o prijavi kvara, rezervaciji, upitima i sl. Kada zaposlenik potvrdi rezervaciju, kupac prima obavijest o uspješnoj rezervaciji.  | Petar Miškić
F09 | Upiti | Kupac može slati upite o lokacijama, rezervaciji, bilo čemu što ga zanima. Na upite odgovara zaposlenik. | Boris Skeledžija
F10 | Način plaćanja | Kupac odabire način plaćanja. | Zvonimir Koprek
F11 | Upis podataka o dolasku | Kupac upisuje podatke i termin svog dolaska. | Mateo Mustać
F12 | Evidencija | Admin/Zaposlenik imaju mogućnost pregleda automobila, opreme, tj. cijelog sustava. | Zvonimir Koprek


## Tehnologije i oprema
.NET Framework/Core, GitHub, GitHub Classroom, Word, MySQL, Draw.io, Visual Paradigm, C#
