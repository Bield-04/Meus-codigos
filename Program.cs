Console.WriteLine("Digite sua idade:");

var idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o seu nome:");

var nome = Console.ReadLine();

var p = new Pessoa(idade,nome);

Console.WriteLine($"O seu Nome é {p.nome} e sua idade é {p.idade}");

class Pessoa(int Idade, string Nome)
{
    public int idade = Idade;
    public string nome = Nome;
    
}
