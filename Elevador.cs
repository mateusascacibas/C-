using System;
using System.Collections.Generic;
using System.Text;

namespace elevador
{
    class Elevador
    {
        public int AndarAtual = 0;
        public int totalandares = 0;
        public int pessoasqtd = 0;
        public int capacidade = 0;

       public Elevador(int totalandares, int capacidade)
        {
            this.totalandares = totalandares;
            this.capacidade = capacidade;
        }

        public Elevador()
        {
        }

        static void Inicializa(int capacidade, int totalandares)
        {
            Console.WriteLine("Digite a capacidade do elevador \n");
            capacidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o total de andares do predio \n");
            totalandares = Convert.ToInt32(Console.ReadLine());
        }
        
        public int getAndarAtual()
        {
            return this.AndarAtual;
        }

        public void setAndarAtualCima(int AndarAtual)
        {
            this.AndarAtual = AndarAtual + 1 ;
        }
        public void setAndarAtualBaixo(int AndarAtual)
        {
            this.AndarAtual = AndarAtual - 1;
        }

        public void setPessoasqtdSai(int pessoasqtd)
        {
            this.pessoasqtd = pessoasqtd - 1 ;
        }

        public void setPessoasqtdEntra(int pessoasqtd)
        {
            this.pessoasqtd = pessoasqtd + 1;
        }

        public int getPessoasqtd()
        {
            return this.pessoasqtd;
        }

       public int getCapacidade()
        {
            return this.capacidade;
        }

        public int getTotal()
        {
            return this.totalandares;
        }
    }
}
