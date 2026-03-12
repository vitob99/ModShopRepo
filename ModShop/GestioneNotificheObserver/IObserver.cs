public interface IObserver
{
    void AggiornamentoCambioStrategia(IStrategyPagamento s); 
    void AggiornamentoCambioDecorazione(ICatalogo c, string tipo); 
    void AggiornamentoCheckout(ICatalogo c);
}