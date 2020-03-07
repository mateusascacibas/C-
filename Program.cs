using System;
using elevador;
namespace elevador
{
    class Program
    {
        static int recebe = 0;
        static int valor = 0;
        static void Main(string[] args)
        {
            Elevador p1 = new Elevador();
            
            Console.WriteLine("Digite o total de andares do predio");
            p1.totalandares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Capacidade ");
            p1.capacidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A Capacidade do elevador é de : " + p1.getCapacidade() + " pessoas");
            Console.WriteLine("\n");
            

            while (recebe != 5) {
                Console.WriteLine("Digite \n " +
                    "1 para subir elevador \n " +
                    "2 para descer elevador \n " +
                    "3 para entrar pessoa \n " +
                    "4 para sair pessoa \n " +
                    "5 para sair do programa \n");

                recebe = Convert.ToInt32(Console.ReadLine());
                if (recebe == 1)
                {
                    if (p1.AndarAtual < p1.totalandares)
                    {
                        p1.setAndarAtualCima(p1.AndarAtual);
                    }
                    else
                    {
                        Console.WriteLine("O elevador já está no ultimo andar. \n");
                    }
                }
                else if(recebe == 2)
                {
                    if (p1.AndarAtual > 0)
                    {
                        p1.setAndarAtualBaixo(p1.AndarAtual);
                    }
                    else
                    {
                        Console.WriteLine("O elevador já está no terreo. \n");
                    }
                    
                }
                else if(recebe == 3)
                {
                    if (p1.pessoasqtd < p1.capacidade)
                    {
                        p1.setPessoasqtdEntra(p1.pessoasqtd);
                    }
                    else
                    {
                        Console.WriteLine("O elevador ja está cheio. \n");
                    }
                }
                else if(recebe == 4)
                {
                    if (p1.pessoasqtd > 0)
                    {
                        p1.setPessoasqtdSai(p1.pessoasqtd);
                    }
                    else
                    {
                        Console.WriteLine("O elevador ja está vazio. \n");
                    }
                }
                Console.WriteLine("\n O elevador se encontra no andar " + p1.getAndarAtual() + "\n contendo " + p1.getPessoasqtd() + " pessoas dentro \n \n");
            }


        }
    }
}
