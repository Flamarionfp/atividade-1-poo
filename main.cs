class Program
{
    public static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Flamarion", 20, true);
        aluno.dizerAlgo("Olá!");

        int soma = aluno.somar(2, 1);
        int subtracao = aluno.subtrair(8, 4);
        int multiplicacao = aluno.multiplicar(3, 4);
        int divisao = aluno.dividir(10, 2);
        int restoDivisao = aluno.calcularRestoDeDivisao(10, 2);

        System.Console.WriteLine(aluno.nome);
        System.Console.WriteLine(soma);
        System.Console.WriteLine(subtracao);
        System.Console.WriteLine(multiplicacao);
        System.Console.WriteLine(restoDivisao);
    }
}