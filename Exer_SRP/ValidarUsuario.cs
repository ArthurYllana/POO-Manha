namespace Exer_SRP
{
    public class ValidadorUsuarios
    {
        public bool ValidarUsuario(string nome, Conta conta)
        {
            return conta.Titular == nome;
        }
    }
}
