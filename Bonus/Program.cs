Console.Write("Inserisci titolo ");
string titolo = Console.ReadLine();

Console.Write("Inserisci autore ");
string autore = Console.ReadLine();

Console.Write("Inserisci codice ISBN ");
long isbn = long.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di pagine ");
int numeroPagine = int.Parse(Console.ReadLine());

Console.Write("Inserisci il peso del libro in kg ");
double pesoLibro = double.Parse(Console.ReadLine());

Console.Write("Inserisci la larghezza del libro in cm ");
double larghezza = double.Parse(Console.ReadLine());

Console.Write("Inserisci la lunghezza del libro in cm ");
double lunghezza = double.Parse(Console.ReadLine());

Console.Write("Inserisci la profondità del libro in cm ");
double profondità = double.Parse(Console.ReadLine());

Console.Write("Inserisci la valutazione media ");
double valutazioneMedia = double.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di recensioni ");
int numeroRecensioni = int.Parse(Console.ReadLine());

Console.Write("Il formato kindle è disponibile?");
string kindleDisponibile = Console.ReadLine();

Console.Write("Ha la copertina flessibile?");
string copertinaFlessibile = Console.ReadLine();















Console.WriteLine();
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
