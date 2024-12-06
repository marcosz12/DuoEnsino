namespace EnsinoMedio.Models
{
    public class Aluno : Pessoa
    {

        public int Pontuacao { get; set; }
        public List<string> Duvidas { get; set; } = new List<string>();

        public List<string> RespostaAtividades { get; set; } = new List<string>();
        public Aluno(int pontuacao)
        {
            Pontuacao = pontuacao;
        }
    }
}
