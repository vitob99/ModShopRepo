public interface IStrategyPagamento //definire nella classe singleton i metodi per settare ed eseguire una strategia
{
    public decimal CalcolaPrezzo(decimal prezzo, string regione);
    decimal CalcolaPrezzo(decimal prezzo, string valuta, int iva, int sconto);
    public string NomeStrategia();
}