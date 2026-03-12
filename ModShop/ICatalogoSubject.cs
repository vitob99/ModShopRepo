interface ICatalogoSubject  //implementare nella classe singleton, che avrà una List<IObserver>
{
    void AggiungiObserver();
    void RimuoviObserver();
    void Notifica(IStrategyPagamento s);  //notifica aggiornamento strategia
    void Notifica(string tipo); // + IProdotto //notifica aggiornamento decorazione
    void Notifica(); // + IProdotto //notifica aggiornamento checkout
}