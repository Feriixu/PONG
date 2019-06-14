# PONG
PONG clone made with Windows Forms
## Contributors
* Felix S.
* Dilan D.
* Mike M.

## MACHBARKEITSANALYSE
### KOMPETENZEN
Unsere Gruppe besitzt alle nötigen Kompetenzen um das Projekt in vorgegebener Zeit zu realisieren. Dazu gehören:
* Objektorientiertes Programmieren (C#)
* XML Strukturen zur Speicherung von Highscores
* SFX Design mit FL Studio 12

## KOMPETENZVERTEILUNG

### Mike
* Objektorientiertes Programmieren (C#)
* SFX Design mit FL Studio 12

### Felix
* Objektorientiertes Programmieren (C#)
* XML Strukturen zur Speicherung von Highscores
* SFX Design mit FL Studio 12

### Dilan
* Objektorientiertes Programmieren (C#)

## SOFTWARE
+ Entwicklungsumgebung Visual Studio 2019
+ System.Drawing Library
+ Digital Audio Workstation FL Studio 12 

## HARDWARE
+ Windows PC 

## PERSONELLE UND ZEITLICHE RESSOURCEN
* Das Projekt wird bis spätestens 13.06.2019 fertiggestellt sein.

## PFLICHTENHEFT / PROJEKTBESCHREIBUNG
Es wird eine Anwendung für Windows erstellt. Das zu programmierende Spiel heißt „PONG“.
Folgende Funktionen müssen enthalten sein:
Auf dem Spielfeld sind ein Spieler links und der andere rechts. Jeder Spieler kontrolliert ein Paddel. Die Spieler müssen versuchen einen herumfliegenden Ball daran zu hindern hinter den eigenen Paddel zu fliegen. Die Paddel sind Rechtecke die sich nur vertikal bewegen können.
Der Ball prallt von der oberen und unteren Spielfeldbegrenzung ab, unterliegt keiner Gravitation.
Er fliegt weiter nach oben wenn der Paddel den Ball mit dem oberen Ende trifft und weiter nach unten wenn er am unteren Ende getroffen wird. 
Ein Einzel- und Mehrspielermodus ist vorgesehen. Optional wird eine verbesserte KI für einen besseren Gegenspieler eingebaut.

## SOFTWARE - DESIGN
### BENUTZERROLLEN
Da wir uns für das Projekt entschieden haben wird es nur den Anwender als Benutzer geben.

### GUI
#### HAUPTMENÜ
* Einzelspieler Button
* Mehrspieler Button
* Punkte / Endlos Modus Auswahl Buttons

#### SPIELFELD
* Schwarzer Hintergrund
* Paddel, Ball und Scores sind weiß
* Die Scores befinden sich in der oberen Mitte auf der Seite des entsprechenden Spielers

## TEST DOKUMENTATION
### BLACKBOX - TEST
Programm funktioniert. Bei Kontakt mit einem Paddel wird der Ball in die entgegengesetzte Richtung reflektiert. Trifft der Ball keinen Paddel, sondern eine linke oder rechte Wand erhält der Spieler, der den Ball in eine Wand gelenkt hat einen Punkt. Der Punktemodus & der Einzelspielermodus ist auch noch nicht implementiert. Bisher gibt es nur einen Bug der wäre, dass der Ball im Paddel hängen bleibt, wenn man ihn mit der oberen oder unteren Kante des Paddels trifft.
