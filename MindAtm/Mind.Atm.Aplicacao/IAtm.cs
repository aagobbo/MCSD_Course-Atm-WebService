namespace Mind.Atm.Aplicacao
{
    public interface IAtm
    {
        void Sacar(string agencia, string numeroConta, decimal valor);

        void Depositar(string agencia, string numeroConta, decimal valor);
    }
}
