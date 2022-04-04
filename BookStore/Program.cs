/*
 In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover 
chiedere all’utente nessun input) tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code") 
per poi stamparne una piccola sintesi fatta bene.
Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
- Titolo
- Autore
- ISBN
- Numero pagine
- Peso del libro
- Larghezza, Altezza e Profondità del libro
- Valutazione media
- Numero di recensioni
- se è disponibile in versione Kindle
- se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> 
indica di stampare l’informazione contenuta nella variabile.
Un esempio è il seguente:
——— IL LIBRO DI OGGI: <<titolo>> di <<autore>>——————-
Informazioni generiche:
ISBN: <<isbn>>
Numero delle pagine: <<numeroPagine>> pagine
Peso del libro: <<pesoLibro>> kg
Dimensioni del libro: <<larghezza>> cm x <<lunghezza>> cm x <<profondita>> cm
Informazioni Amazon:
Numero di recensioni: <<numeroRecensioni>> recensioni
Valutazione media: <<valutazioneMedia>> stelline
Kindle disponibile: Si o No
Copertina flessibile disponibile: Si o No
 */








string titolo = "Clean Code";
string autore = "Robert C. Martin, Dean Wampler";
long isbn = 9780132350884;
int numeroPagine = 431;
double pesoLibro = 0.700;
double larghezza = 17.7;
double lunghezza = 23.1;
double profondità = 2.54;
double valutazioneMedia = 4.7;
int numeroRecensioni = 3310;
string kindleDisponibile = "Si";
string copertinaFlessibile = "Si";



Console.WriteLine("—————- IL LIBRO DI OGGI: <<" + titolo + ">> di <<" + autore + ">>——————------------------");
Console.WriteLine("INFORMAZIONI GENERICHE:");
Console.WriteLine();
Console.WriteLine("ISBN: <<" + isbn + ">>");
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: << " + pesoLibro + ">> kg");
Console.WriteLine("Dimensioni del libro: <<" + larghezza + ">> cm x << " + lunghezza + ">> cm x <<" + profondità + ">> cm");
Console.WriteLine();
Console.WriteLine("INFORMAZIONI AMAZON:");
Console.WriteLine();
Console.WriteLine("Numero di recensioni: << " + numeroRecensioni + ">> recensioni");
Console.WriteLine("Valutazione media: <<" + valutazioneMedia + ">> stelline");
Console.WriteLine("Kindle disponibile: " + kindleDisponibile);
Console.WriteLine("Copertina flessibile disponibile: " + copertinaFlessibile);
