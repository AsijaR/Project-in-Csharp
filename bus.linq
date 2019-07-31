<Query Kind="Statements" />

//KARTA moze da se izda samo kad ima slobodnih mesta u autobusu
//AUTOBUSKA LINIJA- put kojim se bus krece
//svaki bus ima OGRANICEN broj mesta
//Kupovina karte/moze da ima povratna karta
//KARTA ima broj sedista

//Korsnik pita koju ce liniju da koristi, i da li hoce povratnu kartu
//daje mu cenu, kod karte(ako ima praznih mesta),

(int brojKarte, string linija, bool povratna)[] bus=new (int brojKarte, string linija,bool povratna)[0];
//kaze mi koji je broj karte, korisnici, i gde koji je putovao
string[] ruta = { "Park", "Muzej", "Autobuska", "Internacionalni" };
while (true)
{
	stampajMeni();
	string izbor = Console.ReadLine();
	if (izbor.ToLower().Equals("q"))
	{
		Console.WriteLine("\n Bye Bye");
		return;
	}
	if (!int.TryParse(izbor, out int odabir)) //ovde convertujem STRING u INT
	{
		Console.WriteLine("Greska pri unosu!");
		continue;
	}
	switch (odabir)
	{
		case 1:
			Karta(ref bus);
			break;
		case 2:
			PregledKorisnika(bus);
			break;
		case 3:
			Zarada(bus);
			break;
		default:
			Console.WriteLine("Nepostojeca opcija!");
			break;
	}
}
void stampajMeni()
{
Console.WriteLine(
	"\n1 -- Kupovina Karte\n" +
    "2 -- Pregled korisnika\n" +
    "3 -- Zarada\n" +
    "q -- Izlaz\n" +
    "_____________________\n");
	Console.Write("Izaberite: \n\n");
}
void PregledKorisnika((int brojKarte, string linija, bool povratna)[] kor)
{
	if (kor.Length == 0) {
		Console.WriteLine("U autobusu trenutno nema putnika");
		return;
		}
	foreach (var korisnik in kor)
	{
		
		Console.WriteLine($"{korisnik.brojKarte} --- {korisnik.linija} -- {korisnik.povratna}");
	}
}
int Zarada((int brojKarte, string linija, bool povratna)[] kor)
{   //(int brojKarte, string linija, bool povratna)[] korisnik=new(int brojKarte, string linija, bool povratna)[0];
	int dobit = 0;
	//int dobit=kor.Length;
	if (kor.Length == 0)
		Console.WriteLine("Nazalost, danas niste ostvarili nikakvu zaradu.");
	for (int i = 0; i < kor.Length; i++)
	{
		if (kor[i].povratna == true)
		 dobit+= 120;
		else dobit += 80;
	}

	Console.WriteLine($"Vasa zarada iznosi {dobit} dinara.");
return dobit;
}

void Karta(ref (int brojKarte, string linija, bool povratna)[] kor)
{
	Array.Resize(ref kor, kor.Length+1);
	if (kor.Length > 15) //Maximalan broj mesta je 15
		Console.WriteLine("Nazalost nema vise slobodnih mesta u autobusu. \\Molimo Vas sacekajte...");
	Console.WriteLine("Unesite gde zelite da putujete? ");
	string linija = Console.ReadLine().ToLower();
	kor[kor.Length-1].linija=linija;
	if (!mesto(linija))
		return;
	Console.WriteLine("Da li zelite povratnu kartu? \n1--Da\n2--Ne");
	string povratna = Console.ReadLine();
	if (!int.TryParse(povratna, out int odabir)) //ovde convertujem STRING u INT
	{
		Console.WriteLine("Greska pri unosu!");
		//continue;
		return;
	}
	if (odabir == 1)
	{
		kor[kor.Length-1].povratna = true;
		Console.Write("Cena Vase karte iznosi  120 din. \n Zelimo Vam srecno putovanje!");
	}
	else
	{
		kor[kor.Length-1].povratna = false;
		Console.Write("\n\nCena Vase karte iznosi  80 din. \n Zelimo Vam srecno putovanje!");
	}

	
	Random rnd = new Random();
	kor[kor.Length-1].brojKarte = rnd.Next(1, 16);
	Console.WriteLine($"\nBroj karte: {kor[kor.Length-1].brojKarte}\nDestinacija: {kor[kor.Length-1].linija}\nPovratna: {kor[kor.Length-1].povratna} ");
	
}
Boolean mesto(string odrediste)
{
	for (int i = 0; i < ruta.Length; i++)
	{
		if (odrediste == ruta[i].ToLower())
		{
			Console.WriteLine("Bus ce se uskoro naci na Vasoj lokaciji\n");
			return true;
		}
		else
		{
			Console.Write("Nazalost, bus ne prolazi Vasom lokacijom\n");
			return false;
		}
	}
	return false;
}