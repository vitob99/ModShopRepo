interface IStrategyPagamento //definire nella classe singleton i metodi per settare ed eseguire una strategia
{
    protected decimal CalcolaPrezzo(decimal prezzo, string valuta, int iva, int sconto); //o CalcolaPrezzo(decimal prezzo, string regione)
    public string NomeStrategia();
}