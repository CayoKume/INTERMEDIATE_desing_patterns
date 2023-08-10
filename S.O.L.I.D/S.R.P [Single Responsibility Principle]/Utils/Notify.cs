namespace S.R.P__Single_Responsibility_Principle_.Utils
{
    internal class Notify
    {
        public Notify(Client cliente)
        {
            Console.WriteLine($"Notificando o cliente: {cliente.nome}");
        }
    }
}
