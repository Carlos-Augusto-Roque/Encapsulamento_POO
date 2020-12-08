namespace Encapsulamento_POO.classes
{
    public class Cartao//classe principal cartão
    {
        private string numero;//atributo da classe 
        public string Numero{//método acessor
            get{return numero;}//leitura do valor do campo
            set{numero = value;}//um novo valor é atribuido á propiedade (gravação)
        }

        private string bandeira = "MasterCard";//atributo da classe já com valor atribuído
        public string Bandeira{//método acessor
            get{return bandeira;}//leitura do valor já declarado no atributo 
        }
        
        protected string token = "qwertyui";//atributo da classe já com valor atribuído
        public string Token{//método acessor
            get{return token;}//leitura do valor já declarado no atributo 
        }

        private string cvv;//atributo da classe 
        public string Cvv{//método acessor
            get{return cvv;}//leitura do valor do campo
            set{cvv = value;}//um novo valor é atribuido á propiedade (gravação)
        }

        protected float limite = 5000;//atributo da classe já com valor atribuído
        public float Limite{//método acessor
            get{return limite;}//leitura do valor já declarado no atributo 
        }


        //métodos
        public string RegistrarCompra(bool validado)
        {
            return "";
        } 

        private bool ValidarCompra(float saldo)
        {
            return true;
        }

        protected string ValidarToken(string token)
        {
            return "";
        }

    }
}

// As propriedades combinam aspectos de métodos e campos. Para o usuário de um objeto, uma propriedade parece ser um campo. Acessar a propriedade requer a mesma sintaxe. Para o implementador de uma classe, uma propriedade consiste em um ou dois blocos de código, que representam um acessador get e/ou um acessador set. O bloco de código para o acessador get é executado quando a propriedade é lida. O bloco de código para o acessador set é executado quando um novo valor é atribuído à propriedade. Uma propriedade sem um acessador set é considerada como somente leitura. Uma propriedade sem um acessador get é considerada como somente gravação. Uma propriedade que tem os dois acessadores é leitura/gravação.