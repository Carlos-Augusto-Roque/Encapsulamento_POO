namespace Encapsulamento_POO.classes
{
    public class MasterCard : Cartao //classe MasterCard herda classe Cartão
    {
        private int parcelas;//atributo da classe
        public int Parcelas{//método acessor
            get{return parcelas;}//leitura do valor do campo
            set{parcelas = value;}//um novo valor é atribuido á propiedade (gravação)
        }

        //métodos
        public string ComprarComDesconto()
        {
            return "";
        }
    }
}