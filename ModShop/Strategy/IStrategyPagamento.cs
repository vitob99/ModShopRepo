public interface IStrategyPagamento // Definire nella classe singleton i metodi per settare ed eseguire una strategia
{
    public decimal CalcolaPrezzo(decimal prezzo, string regione);
    public string NomeStrategia();
}