namespace L.S.P__Liskov_Substitution_Principle_.Clients.Utils
{
    internal class Pomba : Passaro
    {
        public Pomba(string nome) : base(nome)
        {
            Voar(nome);
        }

        public override void Voar(string nome)
        {
            Console.WriteLine($"O passaro {nome} esta voando");
        }
    }
}
