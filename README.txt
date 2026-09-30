Jag ska undersöka, dokumentera och förklara och rätta fel som ingår i koden

1. Catch is empty shoppinglist.cs

2. shoppinglist.cs
 När programmet startade och anropade load metoden flr att läsa in sparad data, kraschade det och gav felet "IndexOutOfRangeException".
Orsaken var att textfilen alltid sparades med en extra tom rad längst ner pga split('\n'). Det fanns ingen data i den tomma raden, vilket orsakade kraschen då det inte fanns någon namn eller data att hämta ut. 

lösning;
Jag löste detta genom att ta bort File.ReadAllText() och Split('\n') och lade istället till "string[] lines = File.ReadAllLines(path);" Denna meod är säkrare, läser filen rad för rad och hanterar radbrytningarna automatiskt.

3. Program.cs
När programmet bad om en siffra, och jag angav en siffra mindre än 1 eller högre än 5, eller när jag angav bokstäver istället för heltal, kraschade programmet och jag fick "Unhandled exception. System.FormatException". 
för att fixa detta, tog jag bort int.parse och lade till en while loop som fortsätter om man anger fel val tills man anger rätt.

4. Program.cs
Programmet kraschade när jag skrev in bokstäver istället för priset på en ny vara. Programmet accepterade också priser under 0 kr, vilket är omöjligt.

lösning: Jag tog bort int.parse och lade istället till int.tryparse() inuti en while loop. Koden verifierar nu att inmatningen är ett heltal. jag lade även till ('price<0'), vilket är ett vilkor att priset måste vara 0 eller högre. pga att det är en while loop, tvingas man lägga till korrekt inmatning.

