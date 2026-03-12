class Program
{
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
        
        AppContext.regione = scelta.Key switch { ConsoleKey.D1 => "EU", ConsoleKey.D2 => "US", _ => string.Empty };

        Console.Clear();
        Console.WriteLine("Regione selezionata. Accesso validato!");
        ContinueAndClear();
    }

    public static void AcquistaFumetto()
    {
        // 1. Inizializziamo l'oggetto base
        ICatalogo oggetto = CatalogoFactory.CreaOggetto("FUMETTO");
        bool continuaAggiungere = true;

        while (continuaAggiungere) 
        {
            int scelta;
            do {
                Console.Clear();
                Console.WriteLine("--- CATALOGO FUMETTI ---");
                Console.WriteLine($"1. Spider-Man: Blue - {(AppContext.regione is "EU" ? '€' : '$')}15.00\n" +
                    $"2. Superman (Ed. Deluxe) - {(AppContext.regione is "EU" ? '€' : '$')}35.00\n" +
                    $"3. Justice League Vol. 1 - {(AppContext.regione is "EU" ? '€' : '$')}5.00\n" +
                    $"4. Batman: Il Ritorno del Cavaliere Oscuro - {(AppContext.regione is "EU" ? '€' : '$')}20.00\n" +
                    $"5. Flash Vol. 100 - {(AppContext.regione is "EU" ? '€' : '$')}4.30");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 5);
            
            // 2. Decoriamo l'oggetto esistente con la nuova scelta
            oggetto = DecoratorFactory.Decora(oggetto, scelta);

            // 3. Chiediamo se vuole continuare (passando il flag per referenza)
            ContinueOrNot(ref continuaAggiungere);
        }

        // 4. Viene eseguito solo quando l'utente ha finito di aggiungere prodotti (preme 'N')
        PaymentMethod(oggetto);
    }

    public static void AcquistaGadget()
    {
        ICatalogo oggetto = CatalogoFactory.CreaOggetto("GADGET");
        bool flag = true;
        while (flag) 
        {
            int scelta;
            do {
                Console.WriteLine("--- CATALOGO GADGET ---");
                Console.WriteLine($"1. Funko Pop! Iron Man - {(AppContext.regione is "EU" ? '€' : '$')}12.90\n" +
                $"2. Portachiavi Zelda (Triforza) - {(AppContext.regione is "EU" ? '€' : '$')}6.50\n" +
                $"3. Tazza Termica Pac-Man - {(AppContext.regione is "EU" ? '€' : '$')}14.00\n" +
                $"4. Poster Arrotolato One Piece - {(AppContext.regione is "EU" ? '€' : '$')}9.90\n" +
                $"5. Action Figure Goku SSJ - {(AppContext.regione is "EU" ? '€' : '$')}45.00");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 5);
            
            oggetto = DecoratorFactory.Decora(oggetto, scelta);
            ContinueOrNot(ref flag);
        }

        PaymentMethod(oggetto);
    }

    public static void AcquistaOggettoDigitale()
    {
        ICatalogo oggetto = CatalogoFactory.CreaOggetto("DIGITALE");
        bool flag = true;
        while (flag)
        {
            int scelta;
            do { 
                Console.WriteLine("--- CONTENUTI DIGITALI ---");
                Console.WriteLine($"1. Wallpaper Collezione Artistica - {(AppContext.regione is "EU" ? '€' : '$')}1.99\n" +
                $"2. Colonna Sonora Originale - {(AppContext.regione is "EU" ? '€' : '$')}9.99\n" +
                $"3. Artbook Digitale (PDF) - {(AppContext.regione is "EU" ? '€' : '$')}12.50\n" +
                $"4. Skin Esclusiva 'Pixel Hero' - {(AppContext.regione is "EU" ? '€' : '$')}4.99\n" +
                $"5. Abbonamento Premium 1 Mese - {(AppContext.regione is "EU" ? '€' : '$')}7.00");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 5);
            
            oggetto = DecoratorFactory.Decora(oggetto, scelta);
            ContinueOrNot(ref flag);
        }
        
        PaymentMethod(oggetto);
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

    public static void PaymentMethod(ICatalogo oggetto)
    {
        ConsoleKeyInfo scelta;
        do {
            Console.Clear();
            Console.WriteLine("Selezione metodo pagamento:\n1. Contanti\n2. Carta Credito\n3. Bitcoin");
            scelta = Console.ReadKey()!;
        } while (scelta.Key is < ConsoleKey.D1 or > ConsoleKey.D3);

        // Switch della strategia operativa basato sull'input utente 
        // (modificando il riferimento della proprietà presente nella classe singleton 'AppContext').
        switch (scelta.Key)
        {
            case ConsoleKey.D1:
                AppContext.GetInstance().SetStrategia(new StandardPricingStrategy());
                break;
            case ConsoleKey.D2:
                AppContext.GetInstance().SetStrategia(new PromoPricingStrategy());
                break;
            case ConsoleKey.D3:
                AppContext.GetInstance().SetStrategia(new VIPPricingStrategy());
                break;
        }

        // Recupero prezzo finale
        decimal prezzoBase = oggetto.GetPrezzo(); 
        decimal prezzoFinale = AppContext.GetInstance().CalcolaPrezzo(prezzoBase);

        Console.WriteLine($"\nStrategia applicata: {AppContext.GetInstance().strategy!.NomeStrategia()}");
        Console.WriteLine($"Prezzo finale da pagare ({AppContext.regione}): {(AppContext.regione == "EU" ? "€" : "$")}{prezzoFinale:F2}");
        
        AppContext.GetInstance().Checkout(); // Notifica gli osservatori
        ContinueAndClear();
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}