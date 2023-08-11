namespace L.S.P__Liskov_Substitution_Principle_.Clients.Utils
{
    internal class Galinha : Passaro
    {
        public Galinha(string nome) : base(nome)
        {
            Voar(nome);
        }

        public override void Voar(string nome)
        {
            Console.WriteLine($"A galinha não sabe voar");
        }
    }
}
