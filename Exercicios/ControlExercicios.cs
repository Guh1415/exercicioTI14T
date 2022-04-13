using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;
                case 2:
                    Console.WriteLine("Infome um numero");
                    int num = Convert.ToInt32(Console)
                    break;
                case 3:
                    do {
                    
                        Console.WriteLine("Informe a base: ");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if(bas <= 0) ;
                        {
                            Console.WriteLine("Base digitada nao e valida, digite novamente!");
                        }
                    } while (bas <= 0);

                    do
                    {
                        Console.WriteLine("Informe e altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if(altura <= 0)
                        {
                            Console.WriteLine("Altura digitada não e valida, digite novamente!");
                        }
                    } while (altura <= 0);


                    Console.WriteLine("A area do retangulo e: " + model.Exercicio03(base, altura));
                    break;
            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
