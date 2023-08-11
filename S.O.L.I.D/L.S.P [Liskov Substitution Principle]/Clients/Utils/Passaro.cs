namespace L.S.P__Liskov_Substitution_Principle_.Clients.Utils
{
    internal class Passaro
    {
        private string nome;

        public Passaro(string nome)
        {
            this.nome = nome;
        }

        public virtual void Voar(string nome)
        {

        }
    }
}
