namespace Candidato.Entities
{
    public class Casa
    {
        public Rua rua { get; private set; }
        public int numero { get; private set; }
        public int totalEleitores { get; private set; }

        public Casa(Rua rua, int numero, int totalEleitores)
        {
            this.rua = rua;
            this.numero = numero;
            this.totalEleitores = totalEleitores;
        }

        public Casa(string cep, string nome, int numero, int totalEleitores)
        {
            this.rua = new Rua(cep, nome);
            this.numero = numero;
            this.totalEleitores = totalEleitores;
        }
    }
}