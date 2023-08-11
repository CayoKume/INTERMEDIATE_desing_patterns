using L.S.P__Liskov_Substitution_Principle_.Clients.Utils;

namespace L.S.P__Liskov_Substitution_Principle_.Clients._Utils
{
    internal class _Pomba : _Passaro, IPassaro
    {
        public _Pomba(string nome) : base(nome)
        {
            Voar(nome);
        }

        public void Voar(string nome)
        {
            Console.WriteLine($"O passaro {nome} esta voando");
        }
    }
}
