<Query Kind="Statements" />

int[,] matrica = new int[5, 7];
int i = 1;
//Console.WriteLine(matrica.Length); //broj elemenata u totalu
//Console.WriteLine(matrica.GetLength(0)); //po dimenziji
//int p=7;
do{
	Console.WriteLine("Od kojeg dana u nedelji pocinju dani?");
	if (!(int.TryParse(Console.ReadLine(), out int izbor)))
		return;
	switch (izbor)
	{
		case 1: ponedeljak(); break;
		case 2: utorak(); break;
		case 3: sreda(); break;
		case 4: cetvrtak(); break;
		case 5: petak(); break;
		case 6: subota(); break;
		case 7: nedelja(); break;
	}}
	while (true);
	
	void ponedeljak()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{
				matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();

	}
	void utorak()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{   //if(red==0 & kol==0) matrica[red,kol]=0;
				if ((red == 0) & (kol == 0))
					matrica[red, kol] = 0;
				else matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();
	}
	void sreda()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{   //if(red==0 & kol==0) matrica[red,kol]=0;
				if ((red == 0) & (kol == 0))
					matrica[red, kol] = 0;
				else matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();
	}
	void cetvrtak()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{
				if ((red == 0) & ((kol == 2) || (kol == 1) || (kol == 0)))
					matrica[red, kol] = 0;
				else matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();
	}
	void petak()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{
				if ((red == 0) & ((kol == 3) || (kol == 2) || (kol == 1) || (kol == 0)))
					matrica[red, kol] = 0;
				else matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();
	}
	void subota()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{   //if(red==0 & kol==0) matrica[red,kol]=0;
				if ((red == 0) & ((kol == 4) || (kol == 3) || (kol == 2) || (kol == 1) || (kol == 0)))
					matrica[red, kol] = 0;
				else matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();
	}
	void nedelja()
	{
		for (int red = 0; red < matrica.GetLength(0); red++)
		{
			for (int kol = 0; kol < matrica.GetLength(1); kol++)
			{   //if(red==0 & kol==0) matrica[red,kol]=0;
				if ((red == 0) & ((kol == 5) || (kol == 4) || (kol == 3) || (kol == 2) || (kol == 1) || (kol == 0)))
					matrica[red, kol] = 0;
				else matrica[red, kol] = i++;
				if (i > 31) break;
			}
		}
		matrica.Dump();
	}