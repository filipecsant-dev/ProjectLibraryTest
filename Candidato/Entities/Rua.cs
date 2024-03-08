namespace Candidato.Entities
{
    public class Rua
    {
        public string cep { get; private set; }
        public string nome { get; private set; }

        public Rua(string cep, string nome)
        {
            this.cep = cep;
            this.nome = nome;
        }

    }
}