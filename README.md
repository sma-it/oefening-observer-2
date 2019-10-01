# Oefening 1

In oefening 1 staat een class `NumberKeeper`, die een getal kan onthouden en de nieuwe waarde dadelijk op het scherm toont. Het project bevat ook twee displays, die een inkomend getal op een andere manier (hexadecimaal of binair) kunnen tonen. Beiden zijn observers, maar de `NumberKeeper` is nog geen `subject`. Jouw taak:

- Zorg er voor dat de class `NumberKeeper` een subject wordt. 
- Pas `Program.cs` aan, zodat de twee displays zich  *subscriben* bij dit subject.

# Oefening 2

In de nieuwswereld bestaat er zoiets als agentschappen die nieuws doorgeven aan kranten. In dit voorbeeld hebben we als `NewsAgency` Belga, het belgische persagentschap. Er bestaat ook een class `NewsPaper`. We voorzien in het programma een `NewsAgency` *(Belga)* en twee `NewsPapers` *(Standaard en New York Times)*. Via het menu kan je drie soorten nieuws genereren: politiek, economisch of technisch. Het bericht mag je zelf verzinnen, zolang het geen fake news is!

## Opdracht 1
- De newspapers zijn observers, en zouden zich moeten abonneren bij een newsagency. Maar `NewsAgency` is geen subject. Daar zorg jij natuurlijk voor!
- Pas `Program.cs` aan, zodat de twee kranten zich  *subscriben* bij het news agency.

## Opdracht 2
- Op dit moment toont een krant het binnenkomende bericht gewoon op het scherm. Het is de bedoeling daar, voor het eigenlijke bericht, ook de categorie op het scherm verschijnt. Dat kan je doen door via de update functie die categorie mee te geven als parameter. En er is al een enum voorzien in het bestand `NewsTypes.cs`.

## Opdracht 3 (Strategy pattern!)
- Niet elke krant toont hetzelfde nieuws. De oefening bevat al een aantal filters. Als we nu van de `NewsPaper` class een base class maken, en afgeleide classes voorzien voor elke krant, dan kunnen we die allemaal ander nieuws laten publiceren. De nodige filters zijn al voorzien, maar je moet de base class `NewsPaper` aanpassen. En dan maak je 3 verschillende child classes: 
  - StandaardPaper (publiceert geen tech nieuws)
  - TimesPaper (publiceert alles)
  - Politico (publiceert enkel politiek nieuws)

Pas tot slot ook `Program.cs` aan zodat je de juiste classes gebruikt.

# Oefening 3 (Maak zelf eens iets!)
Deze oefening mag je helemaal zelf uitwerken. Je spiekt uiteraard zoveel mogelijk in de vorige oefeningen om te kijken wat je daar gedaan hebt.

- Maak een interface `IAnimal`. Die voorziet een functie `MakeSound()`. Daarna maak je de classes `Cat` en `Dog`. Die implementeren `IAnimal`, maar beiden zetten een eigen geluid op het scherm.
- Maak in `Program.cs` een List voor `IAnimal`. Voorzie twee menu opties om een kat of een hond toe te voegen aan de lijst.
- Voeg een menu optie toe *Spook Animal*. Daarin kies je een willekeurig dier uit de lijst en voer je de `MakeSound()` functie van dat dier uit. Als je niet meer weet hoe je een random element uit een lijst gebruikt, dan zoek je dat via google.

In het tweede deel van de oefening maak je van alle dieren subjects. Het is de bedoeling dat de observers die we zodadelijk maken *horen* wanneer een dier een geluid maakt.
- Begin met het maken van een interface `ISubject`. Zoek in de vorige oefeningen welke functies die moet bevatten.
- Implementeer deze interface in `Cat` en `Dog`. De functie `MakeSound` zal nu ook de observers moeten verwittigen dat het dier een geluid maakte.
- Maak ook een observer interface, `IObserver`. De update functie moet via een argument te weten komen wat voor een dier dit geluid maakte. (Enum, anyone?)
- Maak een class `Person` die een observer is. Bovendien zorg je dat je via de constructor een naam aan de persoon kan geven.
- In de update functie toon je op het scherm dat dat persoon een dier hoorde. Dat kan zo ongeveer (het hangt er van af wat voor enum je maakte):
  
```
void update(AnimalType type) {
  if (type == AnimalType.Dog) {
      Console.WriteLine(this.name + " heard a dog");
  } else {
      Console.WriteLine(this.Name + " heard a cat");
  }
}  
```

- Voeg nu in `Program.cs` drie personen toe:
```
Person catLover = new Person("Tom");
Person dogLover = new Person("Jerry");
Person animalLover = new Person("Terry");
```

- Telkens als je een nieuw dier toevoegt aan de lijst, voeg je Tom toe als observer wanneer het een kat is, Jerry wanneer het een hond is, en Terry in beide gevallen.

Als alles juist werkt, dan zou je nu bij het uitvoeren van de menu functie "Spook Animal" ook moeten zien wie het dier gehoord heeft.

## Extra Moeilijk
Geef bij het toevoegen van een nieuw dier, dat dier ook een naam. En die naam geef je ook door aan de observer. Op die manier kan je de tekst op het scherm verbeteren, tot zoiets: *Naam Observer* heard *Naam Dier* make a sound.


