namespace S.R.P__Single_Responsibility_Principle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                O Princípio da responsabilidade única, dita que uma classe deve conter somente uma responsabilidade,
                delegando métodos, propiedades e variaveis que não pertencem a ela, para as demais classes
            */

            #region Exemplo de como o SRP pode ser violado
            /*
                Neste exemplo notamos que a classe program é responsavel por criar, atualizar, deletar e notificar o cliente.
                Para que possamos respeitar o principio SRP devemos separar esses métodos em outras classes
            */

            static void CreateClient()
            {

            }

            static void UpdateClient()
            {

            }

            static void DeleteClient()
            {

            }

            static void NotifyClient()
            {

            }
            #endregion

            #region Exemplo da aplicação do SRP
            /*
                Para isso, iremos criar uma pasta chamada Utils para armazenar nossa classe, e dentro dela iremos criar 
                uma nova classe chamada Client e outra chama Notify
            */
            #endregion
        }
    }
}