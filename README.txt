Jag ska undersöka, dokumentera och förklara och rätta fel som ingår i koden

1. Catch is empty shoppinglist.cs

2. shoppinglist.cs
 När programmet startade och anropade load metoden flr att läsa in sparad data, kraschade det och gav felet "IndexOutOfRangeException".
Orsaken var att textfilen alltid sparades med en extra tom rad längst ner pga split('\n'). Det fanns ingen data i den tomma raden, vilket orsakade kraschen då det inte fanns någon namn eller data att hämta ut. 

lösning;
Jag löste detta genom att ta bort File.ReadAllText() och Split('\n') och lade istället till "string[] lines = File.ReadAllLines(path);" Denna meod är säkrare, läser filen rad för rad och hanterar radbrytningarna automatiskt.