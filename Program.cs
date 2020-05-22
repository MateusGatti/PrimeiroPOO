using System;

namespace AtividadeAula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.nome = "HB20";
            carro.cor = "Preto";

            Console.WriteLine(carro.nome);
            Console.WriteLine(carro.cor);

            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Freiar());
            Console.WriteLine(carro.Esquerda());
            Console.WriteLine(carro.Direita());



        }
    }
}
