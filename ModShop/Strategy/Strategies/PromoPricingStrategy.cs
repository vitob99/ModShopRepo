public class PromoPricingStrategy : IStrategyPagamento
{
    const int PROMO_DISCOUNT = 5;
    const decimal TASSO_US = 1.0771m;
    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        // 1. Applichiamo lo sconto (5%)
        decimal prezzoScontato = prezzo * (1 - PROMO_DISCOUNT / 100m);
        
        // 2. Convertiamo se necessario
        return (regione == "US") ? prezzoScontato * TASSO_US : prezzoScontato;
    }
    public string NomeStrategia() => "Calcolo prezzo (Promo)";
}