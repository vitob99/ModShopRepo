interface IObserver
{
    void AggiornamentoCambioStrategia(IStrategyPagamento s); 
    void AggiornamentoCambioDecorazione(string tipo); //IProdotto
    void AggiornamentoCheckout(); //IProdotto
}