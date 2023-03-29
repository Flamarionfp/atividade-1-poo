class Aluno : Pessoa
{
    public string nome;
    public int idade;
    public bool estaAprovado;

    public Aluno(string nomeAluno, int idadeAluno, bool estaAprovadoAluno)
    {
        nome = nomeAluno;
        idade = idadeAluno;
        estaAprovado = estaAprovadoAluno;
    }

    public override void dizerAlgo(string algo)
    {
        System.Console.WriteLine("Olá mundo!");
    }

    public override int multiplicar(int i, int j)
    {
        return i * j;
    }

    public override int somar(int i, int j)
    {
        return i + j;
    }

    public override int subtrair(int i, int j)
    {
        return i - j;
    }

    public override int dividir(int i, int j)
    {
        return i / j;
    }

    public override int calcularRestoDeDivisao(int i, int j)
    {
        return i % j;
    }
}


