DOCUMENTAZIONE

FACTORY:
Catalogo -> factory di oggetti base
oggetti base -> gadget, oggetto digitale, fumetto -> product code: "FUMETTO", "GADGET", "SKIN" -> ToUpper()

proprietà oggetti base: string produttore, bool isLimited


DECORATORE:
decoratori specializzati per tipo base: 
proprietà: decimal costo, priorietà specifiche di tipo
notifica gli osservatori dopo ogni aggiunta [Aggiornamento()]
all'uscita della funzione chiama instanza Singleton metodo Logger(Prodotto prodottofinale) -> mostra il recap finale dell'ordine

STRATEGY
Osservatori concreti = (Interfaccia con metodo Notifica(Prodotto p) - UI, Log, Mail, SMS => lista osservatori e implementazione interfaccia ISoggetto in => AppContext
Strategy = IStrategy CalcolaPrezzo(decimal prezzo, string valuta, int iva, int sconto)
       Strategie: StandardPricing, PromoPricing, WholesalePricing, DynamicPricing 





OBSERVER
Observer = IOBserver con metodo di Aggiornamento()
       ISoggetto con metodi di aggiunta/rimozione osservatore e Notifica() -> sarà implementato per i metodi di notifica,aggiunta e rimozione osservatori
       Observer concreti, estendono IObserver: 
       Log - Aggiorna i log 
       UI - Aggiorna UI
       Email - Notifica Email
