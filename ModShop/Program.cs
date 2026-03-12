class Program
{
    public static string regione = string.Empty;
    public static void Main()
    {
        SceltaRegione();

        bool flag = true;
        while (flag) {
            ConsoleKeyInfo scelta;

            do {
                Console.Clear();
                Console.WriteLine(new string('=', 15) + " Termimale di ModShop " + new string('=', 15));
                Console.WriteLine("\nSeleziona:\n1. Acquista (Fumetto)\n" 
                    + "2. Acquista (Gadget)\n3. Acquista (Oggetto Digitale)\n4. (Esci)");
                scelta = Console.ReadKey(true)!;
            } while (scelta.Key is < ConsoleKey.D1 or > ConsoleKey.D4);

            switch (scelta.Key)
            {
                case >= ConsoleKey.D1 and <= ConsoleKey.D3:
                    Console.Clear();
                    switch (scelta.Key) {
                        case ConsoleKey.D1: AcquistaFumetto(); break;
                        case ConsoleKey.D2: AcquistaGadget(); break;
                        case ConsoleKey.D3: AcquistaOggettoDigitale(); break;
                    }
                    //Console.Clear();
                    ContinueAndClear();
                    break;
                case ConsoleKey.D4:
                    flag = false;
                    //Console.Clear();
                    Console.WriteLine("Sessione conclusa.");
                    ContinueAndClear();
                    break;
            }
        }
    }

    public static void SceltaRegione() {
        ConsoleKeyInfo scelta;

        do {
            Console.Clear();
            Console.WriteLine("Benvenuto nel sistema!\n\nIndica la tua regione di provenienza:\n1. EU\n2. US");
            scelta = Console.ReadKey(true);
        } while (scelta.Key is < ConsoleKey.D1 or > ConsoleKey.D2);
        
        regione = scelta.Key switch { ConsoleKey.D1 => "EU", ConsoleKey.D2 => "US", _ => string.Empty };

        Console.Clear();
        Console.WriteLine("Regione selezionata. Accesso validato!");
        ContinueAndClear();
    }

    public static void AcquistaFumetto()
    {
        //ICatalogo oggetto = CatalogoFactory("FUMETTO");
        bool flag = true;
        while (flag) 
        {
            int scelta;
            do {
                Console.Clear();
                Console.WriteLine("--- CATALOGO FUMETTI ---");
                Console.WriteLine($"1. Spider-Man: Blue - {(regione is "EU" ? '€' : '$')}15.00\n" +
                    $"2. Superman (Ed. Deluxe) - {(regione is "EU" ? '€' : '$')}35.00\n" +
                    $"3. Justice League Vol. 1 - {(regione is "EU" ? '€' : '$')}5.00\n" +
                    $"4. Batman: Il Ritorno del Cavaliere Oscuro - {(regione is "EU" ? '€' : '$')}20.00\n" +
                    $"5. Flash Vol. 100 - {(regione is "EU" ? '€' : '$')}4.30");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 5);
            //oggetto = DecoratorFatory.Decora(oggetto);
            ContinueOrNot(ref flag);
        }

    }
    public static void AcquistaGadget()
    {
        //ICatalogo oggetto = CatalogoFactory("GADGET");
        bool flag = true;
        while (flag) 
        {
            int scelta;
            do {
                Console.WriteLine("--- CATALOGO GADGET ---");
                Console.WriteLine($"1. Funko Pop! Iron Man - {(regione is "EU" ? '€' : '$')}12.90\n" +
                $"2. Portachiavi Zelda (Triforza) - {(regione is "EU" ? '€' : '$')}6.50\n" +
                $"3. Tazza Termica Pac-Man - {(regione is "EU" ? '€' : '$')}14.00\n" +
                $"4. Poster Arrotolato One Piece - {(regione is "EU" ? '€' : '$')}9.90\n" +
                $"5. Action Figure Goku SSJ - {(regione is "EU" ? '€' : '$')}45.00");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 5);
            
            //oggetto = DecoratorFatory.Decora(oggetto);
            ContinueOrNot(ref flag);
            PaymentMethod(/*oggetto*/);
        }
    }
    public static void AcquistaOggettoDigitale()
    {
        //ICatalogo oggetto = CatalogoFactory("DIGITALE");
        bool flag = true;
        while (flag)
        {
            int scelta;
            do { 
                Console.WriteLine("--- CONTENUTI DIGITALI ---");
                Console.WriteLine($"1. Wallpaper Collezione Artistica - {(regione is "EU" ? '€' : '$')}1.99\n" +
                $"2. Colonna Sonora Originale - {(regione is "EU" ? '€' : '$')}9.99\n" +
                $"3. Artbook Digitale (PDF) - {(regione is "EU" ? '€' : '$')}12.50\n" +
                $"4. Skin Esclusiva 'Pixel Hero' - {(regione is "EU" ? '€' : '$')}4.99\n" +
                $"5. Abbonamento Premium 1 Mese - {(regione is "EU" ? '€' : '$')}7.00");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 5);
            
            //oggetto = DecoratorFatory.Decora(oggetto);
            ContinueOrNot(ref flag);
            PaymentMethod(/*oggetto*/);
        }
    }

    public static void ContinueOrNot(ref bool flag)
    {
        ConsoleKeyInfo continuare;
            do {
                Console.Clear();
                Console.WriteLine("Prodotto aggiunto.");
                Console.WriteLine("\nVuoi aggiungere altro? (S/N)");
                continuare = Console.ReadKey(true)!;
            } while (continuare.Key is not (ConsoleKey.S or ConsoleKey.N));

            if (continuare.Key is ConsoleKey.N) flag = false; 
            ContinueAndClear();
    }
    public static void PaymentMethod(/*ICatalogo oggetto*/)
    {
        ConsoleKeyInfo scelta;
        do {
            Console.Clear();
            Console.WriteLine("Selezione metodo pagamento:\n1. Contanti\n1. Carta Credito\n3. Bitcoin");
            scelta = Console.ReadKey()!;
        } while (scelta.Key is < ConsoleKey.D1 or > ConsoleKey.D3);

        // Selezionare strategia in base alla scelta, modificando il riferimento attuale della classe 'Singleton', 'AppContext'
        switch (scelta.Key)
        {
            case ConsoleKey.D1:
                // 1. Scelta strategia
                // 2. Pagamento
                break;
            case ConsoleKey.D2:
                // 1. Scelta strategia
                // 2. Pagamento
                break;
            case ConsoleKey.D3:
                // 1. Scelta strategia
                // 2. Pagamento
                break;
        }
    }
    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}