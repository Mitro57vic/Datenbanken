# Datenbanken

# Projekt-Dokumentation



Filip Mitrovic, Filip Kritzner Raul Gilardoni und Lennard Bühler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   17.05.24    | 0.0.1   |Wir haben besprochen was wir Programmieren möchten in diesem Projekt und haben ein Github Repository erstellt. |
|  24.05.24    | 0.0.2   |Wir haben uns für ein Projekt mit Datenbanken entschieden und haben geplant wie wir dieses Projekt umsetzen möchten. Projektdokumentation wurde erweitert. |
|   31.05.24    | 0.1.0   |Umsetzung begonnen und Projektdoku erweitert |


## 1 Informieren

### 1.1 Ihr Projekt


Dieses Projekt zielt darauf ab, eine einfache Benutzer- und Notizverwaltungsanwendung zu entwickeln, die MongoDB als NoSQL-Datenbank verwendet. Benutzer können Profile erstellen, aktualisieren und löschen sowie Notizen hinzufügen, anzeigen, bearbeiten und entfernen. MongoDB Compass wird genutzt, um die Datenbank zu verwalten und zu überwachen. Zu den Hauptfunktionen gehören das Erstellen und Verwalten von Daten in MongoDB, das Durchführen von Backups und Wiederherstellungen sowie das Erstellen von Indizes zur Leistungsverbesserung. Darüber hinaus ermöglicht das Projekt die Nutzung von Volltextsuche und die Visualisierung der Datenstruktur. Das Ziel ist es, eine flexible und skalierbare Lösung bereitzustellen, die eine einfache Handhabung und effiziente Datenverwaltung bietet.



### 1.2 User Stories


| US-№ | Verbindlichkeit | Typ           | Beschreibung                                                                                           |
| ---- | --------------- | ------------- | ------------------------------------------------------------------------------------------------------ |
| 1    | muss            | funktional    | Als Benutzer möchte ich ein neues Profil in MongoDB erstellen können, damit ich meine Daten in der Anwendung speichern kann. |
| 2    | muss            | funktional    | Als Benutzer möchte ich mein Profil in MongoDB aktualisieren können, damit ich meine persönlichen Informationen ändern kann. |
| 3    | muss            | funktional    | Als Benutzer möchte ich mein Profil aus MongoDB löschen können, damit meine Daten nicht mehr in der Anwendung gespeichert sind. |
| 4    | muss            | funktional    | Als Benutzer möchte ich eine neue Notiz in MongoDB erstellen können, damit ich wichtige Informationen speichern kann. |
| 5    | muss            | funktional    | Als Benutzer möchte ich meine Notizen aus MongoDB anzeigen können, damit ich auf meine gespeicherten Informationen zugreifen kann. |
| 6    | muss            | funktional    | Als Benutzer möchte ich meine Notizen in MongoDB aktualisieren können, damit ich Änderungen vornehmen kann. |
| 7    | muss            | funktional    | Als Benutzer möchte ich meine Notizen aus MongoDB löschen können, damit ich nicht mehr benötigte Informationen entfernen kann. |
| 8    | kann            | funktional    | Als Benutzer möchte ich in meinen Notizen in MongoDB suchen können, damit ich bestimmte Informationen schnell finden kann. |
| 9    | muss            | funktional    | Als Administrator möchte ich in MongoDB Compass Benutzerprofile und Notizen sichern können, damit ich Datenverluste verhindern kann. |
| 10   | kann            | funktional    | Als Administrator möchte ich in MongoDB Compass Benutzerprofile und Notizen wiederherstellen können, damit ich im Notfall Daten wiederherstellen kann. |
| 11   | kann            | funktional    | Als Administrator möchte ich in MongoDB Compass Indizes auf bestimmten Feldern erstellen können, damit Abfragen schneller und effizienter durchgeführt werden können. |
| 12   | kann            | funktional    | Als Entwickler möchte ich in MongoDB Compass die Datenstruktur und -beziehungen visuell erkunden können, damit ich ein besseres Verständnis der gespeicherten Daten erhalte. |
| 13   | kann            | funktional    | Als Administrator möchte ich in MongoDB Compass die Leistung der Datenbank überwachen können, damit ich Engpässe identifizieren und beheben kann. |











### 1.3 Testfälle


| TC-№ | Ausgangslage               | Eingabe                                 | Erwartete Ausgabe                                                      |
| ---- | -------------------------- | --------------------------------------- | ---------------------------------------------------------------------- |
| 1.1  | Programm wird geöffnet     | Benutzer wählt "Neues Profil erstellen" und gibt Daten ein | Neues Profil wird in MongoDB erstellt und eine Bestätigung wird angezeigt |
| 2.1  | Profil existiert in MongoDB| Benutzer wählt "Profil aktualisieren" und gibt neue Daten ein | Profil wird mit neuen Daten aktualisiert und eine Bestätigung wird angezeigt |
| 3.1  | Profil existiert in MongoDB| Benutzer wählt "Profil löschen"         | Profil wird aus MongoDB gelöscht und eine Bestätigung wird angezeigt   |
| 4.1  | Programm wird geöffnet     | Benutzer wählt "Neue Notiz erstellen" und gibt Notiz ein | Neue Notiz wird in MongoDB erstellt und eine Bestätigung wird angezeigt |
| 5.1  | Notizen existieren in MongoDB | Benutzer wählt "Notizen anzeigen"      | Alle Notizen werden aus MongoDB abgerufen und angezeigt                |
| 6.1  | Notiz existiert in MongoDB | Benutzer wählt "Notiz aktualisieren" und gibt neue Daten ein | Notiz wird mit neuen Daten aktualisiert und eine Bestätigung wird angezeigt |
| 7.1  | Notiz existiert in MongoDB | Benutzer wählt "Notiz löschen"          | Notiz wird aus MongoDB gelöscht und eine Bestätigung wird angezeigt    |
| 8.1  | Notizen existieren in MongoDB | Benutzer gibt Suchbegriff ein         | Suchergebnisse werden angezeigt und enthalten relevante Notizen        |
| 9.1  | MongoDB Compass ist geöffnet | Administrator wählt "Backup erstellen" | Backup wird erstellt und eine Bestätigung wird angezeigt               |
| 10.1 | MongoDB Compass ist geöffnet | Administrator wählt "Daten wiederherstellen" und gibt Backup-Datei an | Daten werden wiederhergestellt und eine Bestätigung wird angezeigt     |
| 11.1 | MongoDB Compass ist geöffnet | Administrator wählt "Index erstellen" und gibt Feld an | Index wird erstellt und eine Bestätigung wird angezeigt                |
| 12.1 | MongoDB Compass ist geöffnet | Entwickler wählt Datenstruktur-Explorer | Datenstruktur und -beziehungen werden visuell dargestellt               |
| 13.1 | MongoDB Compass ist geöffnet | Administrator wählt "Leistungsüberwachung" | Leistungsmetriken der Datenbank werden angezeigt                        |



### 1.4 Diagramme



## 2 Planen






| AP-№  | Zuständig   | Beschreibung                                                            | geplante Zeit |
| ----- | ----------- | ----------------------------------------------------------------------- | ------------- |
| 1.1  | Bühler  | MongoDB-Schema für Profile definieren                                    | 45 Minuten    |
| 1.2  | Gilardoni  | MongoDB-Schema für Notizen definieren                                    | 45 Minuten    |
| 2.1  | Mitrovic | CRUD-Funktion für Profil-Erstellung in MongoDB implementieren            | 45 Minuten    |
| 2.2  | Mitrovic  | CRUD-Funktion für Profil-Aktualisierung in MongoDB implementieren        | 45 Minuten    |
| 2.3  | Mitrovic  | CRUD-Funktion für Profil-Löschung in MongoDB implementieren              | 45 Minuten    |
| 2.4  | Kritzner  | CRUD-Funktion für Notiz-Erstellung in MongoDB implementieren             | 45 Minuten    |
| 2.5  | Kritzner  | CRUD-Funktion für Notiz-Aktualisierung in MongoDB implementieren         | 45 Minuten    |
| 2.6  | Kritzner  | CRUD-Funktion für Notiz-Löschung in MongoDB implementieren               | 45 Minuten    |
| 3.1  | Gilardoni  | Funktion zur Anzeige aller Notizen in MongoDB implementieren             | 45 Minuten    |
| 4.1  | Gilardoni | Volltextsuche für Notizen in MongoDB implementieren                      | 45 Minuten    |
| 5.1  | Bühler      | Backup in MongoDB Compass einrichten                                     | 45 Minuten    |
| 5.2  | Bühler       | Datenwiederherstellung in MongoDB Compass einrichten                     | 45 Minuten    |



## 3 Entscheiden

Wir haben uns entschieden einen Timer einzubauen, da uns dies schon im letzten Projekt gut gelungen ist und es praktisch ist für unser Spiel.

Wir haben uns entschieden ein System einzubauen, dass bei 10 erzielten Punkten das Spiel beendet, damit das Spiel auch ein Punktlimit besitzt.


## 4 Realisieren

Hier ist die Realisieren-Tabelle mit variierenden Zeiten für die tatsächliche Ausführung:

### Realisieren

| AP-№ | Datum       | Zuständig  | geplante Zeit | tatsächliche Zeit |
| ---- | ----------- | ---------- | ------------- | ----------------- |
| 1.1  | 07.06.2024  | Bühler     | 45 Minuten    | 60 Minuten        |
| 1.2  | 07.06.2024  | Gilardoni  | 45 Minuten    | 30 Minuten        |
| 2.1  | 07.06.2024  | Mitrovic   | 45 Minuten    | 45 Minuten        |
| 2.2  | 07.06.2024  | Mitrovic   | 45 Minuten    | 60 Minuten        |
| 2.3  | 07.06.2024  | Mitrovic   | 45 Minuten    | 30 Minuten        |
| 2.4  | 14.06.2024  | Kritzner   | 45 Minuten    | 45 Minuten        |
| 2.5  | 14.06.2024  | Kritzner   | 45 Minuten    | 60 Minuten        |
| 2.6  | 14.06.2024  | Kritzner   | 45 Minuten    | 30 Minuten        |
| 3.1  | 14.06.2024  | Gilardoni  | 45 Minuten    | 45 Minuten        |
| 4.1  | 14.06.2024  | Gilardoni  | 45 Minuten    | 30 Minuten        |
| 5.1  | 14.06.2024  | Bühler     | 45 Minuten    | 60 Minuten        |
| 5.2  | 14.06.2024  | Bühler     | 45 Minuten    | 55 Minuten        |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |      |     Funktioniert      |       |


`Fazit:`

Die wichtigsten Teile des Programmes sind mit Erfolg ausgegangen, somit ist unser Programm spielbar. Doch Leider konnten wir wegen geringer Zeit nicht alle unsere Wünsche für das Programm erfüllen.

## 6 Auswerten

