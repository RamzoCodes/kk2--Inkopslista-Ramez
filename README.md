Jag ska undersöka, dokumentera och förklara och rätta fel som ingår i koden

## 1. 
Catch är tomt i shoppinglist, vilket orsakade att den inte fångade upp när listan inte sparades som önskat. Jag lade till (IOException) i den, vilket är en errorkod som förklarar vad problemet är, samt ett Console.Writeline() felmeddelande som har meddelat att listan inte kunde sparas. Jag använde mig av IOException för att den var det mest övergripande undantaget för denna specifika problemet, enligt google.

## 2. 
shoppinglist.cs
 När programmet startade och anropade load metoden flr att läsa in sparad data, kraschade det och gav felet "IndexOutOfRangeException".
Orsaken var att textfilen alltid sparades med en extra tom rad längst ner pga split('\n'). Det fanns ingen data i den tomma raden, vilket orsakade kraschen då det inte fanns någon namn eller data att hämta ut. 

lösning;
Jag löste detta genom att ta bort File.ReadAllText() och Split('\n') och lade istället till "string[] lines = File.ReadAllLines(path);" Denna meod är säkrare, läser filen rad för rad och hanterar radbrytningarna automatiskt.

## 3. 
Program.cs
När programmet bad om en siffra, och jag angav en siffra mindre än 1 eller högre än 5, eller när jag angav bokstäver istället för heltal, kraschade programmet och jag fick "Unhandled exception. System.FormatException". 
för att fixa detta, tog jag bort int.parse och lade till en while loop som fortsätter om man anger fel val tills man anger rätt.

## 4. 
Program.cs
Programmet kraschade när jag skrev in bokstäver istället för priset på en ny vara. Programmet accepterade också priser under 0 kr, vilket är omöjligt.

lösning: Jag tog bort int.parse och lade istället till int.tryparse() inuti en while loop. Koden verifierar nu att inmatningen är ett heltal. jag lade även till ('price<0'), vilket är ett vilkor att priset måste vara 0 eller högre. pga att det är en while loop, tvingas man lägga till korrekt inmatning.

## 5. 
När jag valde att ta bort en vara, kraschade systemet om jag matade in text istället för siffror eller nummer som inte fanns på listan, t.ex siffror mindre än 1 eller mer än antalet varor vi faktiskt hade.

För att åtgärda detta gjorde jag tbå saker, först inom ShoppingList.cs så skrev jag public int Count 
{ get { return items.Count; } 
} vilket gjorde att programmet skulle kunna läsa exakt hur många varor som fanns i listen just nu.

Sedan bytte jag int.Parse mot en while-loop med int.tryparse, och i loopens villkor lade jag även till gränskontroller (number < 1 || number > list.Count). Nu kontrollerar programmet att inmatningen är ett heltal, och ryms inom listans gränser. Den kraschar inte längre om jag anger fel inmatning, utan ber mig att försöka igen.

## 6. 
Jag ansåg att första varan inte räknades med i summan. för att fixa detta så bytte jag for (int i = 1; i < items.Count; i++) till for (int i = 0; i < items.Count; i++). alltså jag ändrade i=1 till i=0

## 7.
När jag sökte varan med små bokstäver, hittade inte programmet varan trots att den fanns (med en stor bokstav i början). Jag fixade det genom att lägga till .ToLower i if (item.Name == name) på båda sidorna. Nu kan jag mata in med både stora och små bokstäver och programmet kommer ändå hitta varan till mig.

## 8. 
Ett krav för att få godkänt var att kunna köra programmet utan items.txt utan att programmet kraschar. 
För att lösa detta lade jag till "if (!File.Exists(path)){ return;}" i början av load-metoden. Nu kollar programmet om items.txt existerar, om den inte finns, försöker inte programmet läsa in på textfilen pga return, och istället kör den med en tom lista.

## Designval
Jag valde att låta Add-metoden kasta ett undantag (InvalidOperationException) istället för att returnera false när den överskrider budgettaket.

Detta gjorde jag för att ett undantag ger en mycket högre säkerhet i programmet, eftersom programmet tvingas att hantera felet i en try-catch istället för att felet bara göms från användaren. 

Dessutom gav det mig mer flexibilitet att utforma felmeddelandet precis som jag ville, vilket var ett roligt sätt för mig att bygga upp mitt självförtroende kring att kasta och hantera exceptions, samt utvidga min kreativitet.

## Klassdiagram
![Mitt klassdiagram](Klassdiagram.png)