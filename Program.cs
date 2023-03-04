using System.Runtime.CompilerServices;
using System.Runtime.Serialization;


//int A = int.Parse(Console.ReadLine());
//int B = int.Parse(Console.ReadLine());

//int X = A + B;
//Console.WriteLine($"X = {X}");

Console.WriteLine("Coloque o Raio: ");
float R = float.Parse(Console.ReadLine());
float Area = (float)(Math.PI * Math.Pow(R,2));
Console.WriteLine($"A = {Area}");









ContaCorrente Conta = new ContaCorrente("Murilo", "123456", 500);
ContaCorrente Conta1 = new ContaCorrente("leo", "654321", 700);
ContaCorrente Conta2 = new ContaCorrente("Vini", "12344556", 1000);
ContaCorrente Conta3 = new ContaCorrente("lucas", "65784", 800);
ContaCorrente Conta4 = new ContaCorrente("rafa", "6876987", 900);

Conta.deposito(500);
Console.WriteLine($"Nome: {Conta.Nome}  Nº da conta: {Conta.NdaConta}   Saldo: {Conta.Saldo}");

Carro carro1 = new Carro("Ford", "top", 2004, 160);
Carro carro2 = new Carro("aaa", "aa", 2099, 180);
Carro carro3 = new Carro("bbb", "fd", 3000, 200);
Carro carro4 = new Carro("ccc", "gfd", 2010, 220);
Carro carro5 = new Carro("ddd", "re", 2012, 300);
Carro carro6 = new Carro("rrr", "gf", 2014, 100);
Carro carro7 = new Carro("sss", "htw", 2020, 200);

List<Carro> listaCarro = new List<Carro>() { carro1, carro2, carro3, carro4, carro5, carro6, carro7 };

Console.WriteLine(carro1.Marca);
Console.WriteLine($"Velocidade atual do carro: {carro4.VelocidadeAtual}");
carro4.Acelerar(10);
Console.WriteLine($"Acelerei e a velocidade subiu para: {carro4.VelocidadeAtual}");

//for (int i = 0; i < listaCarro.; i++)
//{
//    Console.WriteLine($"marca: {listaCarro}");
//}

int soma(int n, int x)
{
int somax = n + x;
return somax;
}

Console.WriteLine(soma(15, 2));

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int VelocidadeAtual { get; set; }

    public Carro(string marca, string modelo, int ano, int velocidadeAtual)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
        this.VelocidadeAtual = velocidadeAtual;
    }

    public void Acelerar(int Aceleracao)
    {
        this.VelocidadeAtual = this.VelocidadeAtual + Aceleracao;
    }

    public void Frear(int frenagem)
    {
        this.VelocidadeAtual = this.VelocidadeAtual - frenagem;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"marca {this.Marca}");
    }
}

public class ContaCorrente
{
    public string Nome { get; set; }
    public string NdaConta { get; set; }
    public float Saldo { get; set; }

    public ContaCorrente(string nome, string ndaConta, float saldo)
    {
        this.Nome = nome;
        this.NdaConta = ndaConta;
        this.Saldo = saldo;
    }

    public void setNome(string novonome)
    {
        this.Nome = novonome;
    }

    public void setNdaConta(string novoNconta)
    {
        this.NdaConta = novoNconta;
    }

    public void deposito(int depositar)
    {
        this.Saldo = this.Saldo + depositar;
    }

    public void Saque(int sacar)
    {
        this.Saldo = this.Saldo - sacar;
    }
}

