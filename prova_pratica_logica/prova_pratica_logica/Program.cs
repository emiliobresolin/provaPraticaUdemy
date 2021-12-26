using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
//using System.Threading.Tasks;

namespace prova_pratica_logica
{
    class Program
    {
        static void Main(string[] args)
        {

            //PROGRAMA EXERCICIO 1.1
            Console.WriteLine("Digite o codigo do produto:");
            int cod_pc1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantida de produtos:");
            float num_pc1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario do produto:");
            float val_pc1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo do produto numero 2:");
            int cod_pc2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos:");
            float num_pc2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario do produto:");
            float val_pc2 = float.Parse(Console.ReadLine());

            Console.WriteLine("{0}", val_pc1);
            Console.WriteLine("{0}", val_pc2);

            float valorTotal1 = num_pc1 * val_pc1;
            float valorTotal2 = num_pc2 * val_pc2;

            Console.WriteLine("{0}", valorTotal1);
            Console.WriteLine("{0}", valorTotal2);

            Console.WriteLine($"TOTAL A PAGAR: R$ {valorTotal1 + valorTotal2}");

            //PROGRAMA EXERCICIO 1.2
            Console.WriteLine("Digite o valor do raio: ");
            float raio = float.Parse(Console.ReadLine());
            float pI = 3.14159f;
            Console.WriteLine("O valor de area do circulo fica: ");
            float area = pI * (raio * raio);
            Console.WriteLine(area);

            //EXERCICIO 2.1
            Console.WriteLine("MENU:\n1-Cachorro quente R$4.00\n2-Xis salada R$4.50\n" +
                "3-Xis bacon R$5.00\n4-Torrada R$2.00\n5-Refrigerante R$1.50");
            float preco_prod = 0.00f;
            Console.WriteLine("Digite o codigo do produto: ");
            int codigo_prod = int.Parse(Console.ReadLine());
            if (codigo_prod==1)
            {
                preco_prod = 4.00f;
            }
            else if (codigo_prod==2)
            {
                preco_prod = 4.50f;
            }
            else if (codigo_prod == 3)
            {
                preco_prod = 5.00f;
            }
            else if (codigo_prod == 4)
            {
                preco_prod = 2.00f;
            }
            else if (codigo_prod == 5)
            {
                preco_prod = 1.50f;
            }
            else
            {
                Console.WriteLine("Codigo invalido");
                return;
            }
            Console.WriteLine("Digite a quantidade desejada: ");
            int quantidade_prod = int.Parse(Console.ReadLine());
            float valor_total_lanche = preco_prod * quantidade_prod;
            Console.WriteLine($"Valor total do pedido: R${valor_total_lanche}");

            //EXERCICIO 3.1
            Console.WriteLine("Digite uma senha com 4 numeros inteiros: ");
            int senha_1 = int.Parse(Console.ReadLine());
            for (int contador_1 = 0; contador_1 < 5; contador_1++)
            {
                Console.WriteLine("Digite sua senha: ");
                int confirSenha = int.Parse(Console.ReadLine());
                if(confirSenha!=senha_1)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    
                    return;
                }
            }

            //TESTE AQUI
            /*Console.WriteLine("DIGITE UM NUMERO PARA CONTAGEM!\n");
            int l = int.Parse(Console.ReadLine());
            for (int j = 1; j<=l; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadLine();*/
        }
    }
}
