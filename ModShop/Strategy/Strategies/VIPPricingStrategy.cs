public class VIPPricingStrategy : IStrategyPagamento
{
    const decimal TASSO_US = 1.0771m;
    const int VIP_DISCOUNT = 7;

    public decimal CalcolaPrezzo(decimal prezzo, string regione)
    {
        // 1. Applichiamo lo sconto (7%)
        decimal prezzoScontato = prezzo * (1 - VIP_DISCOUNT / 100m);

        // 2. Convertiamo se necessario
        return (regione == "US") ? prezzoScontato * TASSO_US : prezzoScontato;
    }

    public string NomeStrategia() => "Calcolo prezzo (VIP)";
}