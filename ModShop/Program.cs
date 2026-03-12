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
                scelta = Console.ReadKey()!;
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
                    Console.Clear();
                    ContinueAndClear();
                    break;
                case ConsoleKey.D4:
                    flag = false;
                    Console.Clear();
                    Console.WriteLine("Sessione conclusa.");
                    ContinueAndClear();
                    break;
            }
        }
    }

    public static void SceltaRegione(){
        ConsoleKeyInfo scelta;

        do {
            Console.Clear();
            Console.WriteLine("Benvenuto nel sistema!\n\nIndica la tua regione di provenienza:\n1. EU\n2. US");
            scelta = Console.ReadKey();
        } while (scelta.Key is < ConsoleKey.D1 or > ConsoleKey.D2);
        
        regione = scelta.Key switch { ConsoleKey.D1 => "EU", ConsoleKey.D2 => "US", _ => string.Empty };

        Console.Clear();
        Console.WriteLine("Regione selezionata. Accesso validato!");
        ContinueAndClear();
    }

    public static void AcquistaFumetto()
    {
        Console.WriteLine("--- CATALOGO FUMETTI ---");
        Console.WriteLine("1. Spider-Man: Blue - €15.00\n" +
            "2. Superman (Ed. Deluxe) - €35.00\n" +
            "3. Justice League Vol. 1 - €5.00\n" +
            "4. Batman: Il Ritorno del Cavaliere Oscuro - €20.00\n" +
            "5. Flash Vol. 100 - €4.30");
    }
    public static void AcquistaGadget()
    {
        Console.WriteLine("--- CATALOGO GADGET ---");
        Console.WriteLine("1. Funko Pop! Iron Man - €12.90\n" +
            "2. Portachiavi Zelda (Triforza) - €6.50\n" +
            "3. Tazza Termica Pac-Man - €14.00\n" +
            "4. Poster Arrotolato One Piece - €9.90\n" +
            "5. Action Figure Goku SSJ - €45.00");
    }
    public static void AcquistaOggettoDigitale()
    {
        Console.WriteLine("--- CONTENUTI DIGITALI ---");
        Console.WriteLine("1. Wallpaper Collezione Artistica - €1.99\n" +
            "2. Colonna Sonora Originale - €9.99\n" +
            "3. Artbook Digitale (PDF) - €12.50\n" +
            "4. Skin Esclusiva 'Pixel Hero' - €4.99\n" +
            "5. Abbonamento Premium 1 Mese - €7.00");
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}