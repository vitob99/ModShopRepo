interface ICatalogoSubject  // Implementare nella classe singleton, che avrà un 'List<IObserver>'
{
    void AggiungiObserver();
    void RimuoviObserver();
    void Notifica(IStrategyPagamento s);  // Notifica aggiornamento strategia
    void Notifica(string tipo); // + IProdotto // Notifica aggiornamento decorazione
    void Notifica(); // + IProdotto // Notifica aggiornamento checkout
}