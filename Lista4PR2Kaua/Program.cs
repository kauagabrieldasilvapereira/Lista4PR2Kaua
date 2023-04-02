using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2Kaua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Essa afirmativa é falsa, pois se colocarmos um valor com virgula na variavel int ela ira dar errado, esse programa abaixo só ira ler valores inteiros, ou seja se colocarmos valores com virgula( que no caso é ponto) o programa não será executado.
            //int dist, temp, velo;

            //Console.WriteLine("Qual a distância ? ");
            //dist = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o tempo ? ");
            //temp = int.Parse(Console.ReadLine());

            //velo = dist / temp;

            //Console.WriteLine("A sua velocidade é " + velo);
            //Console.ReadKey();

            //2. O Read retorna o valor do primeiro char que usuario escreveu e em ASCII, já o readline le a linha inteira e retorma o valor inserido pelo usuario.
            //Sim é sempre o mesmo.

            //3. Temos que ter cuidado para ver se a variavel é inteira para usarmos o int, se for com uma variavel com muitas casas depois da virgula utilizamos o float, mais se tivermos muitas casas depois da virgula na variavel, usamos a double, pois ela praticamente dobra o numero de casas depois da virgula em comparação com o float

            //4.
            //int num, num2, num3;
            //Console.WriteLine("Entre com um numero : ");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("Mensagem 1");
            //else
            //    Console.WriteLine("Mensagem 2");

            //Console.ReadKey();
            //4. Dado o numeoro 8 a saida sera a mensagem 2, se entrarmos com 27 sua saida tamebem sera mensagem 2, e se entrarmos com 28 a saida ser mensagem 1, se o numero for 0 ou maior que 10, ele dara a mensagem 2, ja se ele for menor que 10 ele dara mensagem 1.

            //5.

            //float acel, velini,inst,velt;
            //Console.WriteLine("Qual a aceleração ? ");
            //acel = float.Parse(Console.ReadLine());

            //Console.WriteLine("Qual a velocidade inicial ? ");
            //velini = float.Parse(Console.ReadLine());

            //Console.WriteLine("Me fale um instante qualquer ? ");
            //inst = float.Parse(Console.ReadLine());

            //velt = velini + acel * inst;

            //Console.WriteLine("A sua velocidade é " + velt);
            //Console.ReadKey();

            //6.
            //int num;

            //Console.WriteLine("Digite um numero inteiro");
            //num = int.Parse(Console.ReadLine());

            // if(((num % 3) == 0) && ((num & 5 ) == 0) && ((num % 10) == 0))
            //      Console.WriteLine("Seu número é divisel por 3, 5 e 10");

            // else if (((num % 3) == 0) && ((num % 5) == 0))
            //      Console.WriteLine("Seu número é divisel por 3 e 5");

            //else if ((num % 3) == 0)
            //      Console.WriteLine("Seu número é divisel por 3");

            //else if ((num % 5) == 0)
            //      Console.WriteLine("Seu número é divisel por 5");

            // else 
            //    Console.WriteLine("Seu numero nao e divisel nem por 3 nem por 5 e nem por 10");

            // Console.ReadKey();

            //7.
            //int temp, km;
            //Console.WriteLine("Em qual quiolometro esta sua casa ? ");
            //km = int.Parse(Console.ReadLine());

            //if (km <= 12 && km >= 0)
            //    Console.WriteLine("O tempo até o seu destino será de 71 minutos");
            //else if (km <= 29 && km >= 12)
            //{
            //    Console.WriteLine("O tempo até o seu desstino será de 57 minutos");
            //}
            //else if (km <= 55 && km <= 29)
            //{
            //    Console.WriteLine("O tempo até o seu desstino será de 30 minutos");
            //}


            //else if (km <= 82 && km >= 55)
            //{
            //    Console.WriteLine("O tempo até o seu desstino será de 27 minutos");

            //}
            //else if (km <= 100 && km >= 82)
            //{
            //    Console.WriteLine("O tempo até o seu desstino será de 12 minutos");
            //}


            //8.
            //            string marc;
            //            double uni, quant, impos, custo, lucro;

            //            Console.WriteLine("Quantos sacos de ração ? ");
            //            uni = int.Parse(Console.ReadLine());

            //            Console.WriteLine("=====MENU=====");
            //            Console.WriteLine("ROYAL");
            //            Console.WriteLine("WISKAS");
            //            Console.WriteLine("GOLDEN");
            //            Console.WriteLine("NUTRIEN");
            //            Console.WriteLine("SPECIALCAT");
            //            Console.WriteLine("MARBA");
            //            Console.WriteLine("GATUS");
            //            Console.WriteLine("=============");

            //            Console.WriteLine("Escolha a marca ");
            //            marc = Console.ReadLine();

            //            switch (marc)
            //            {
            //                case "ROYAL":

            //                    quant = 129.50 * uni;
            //                    custo = quant * 0.775;
            //                    custo = quant - custo;
            //                    impos = custo * 0.33;
            //                    lucro = (quant - custo) - impos; 
            //                    Console.WriteLine("Valor total  de lucro " + lucro);
            //                    break;

            //                case "WISKAS": 

            //                    quant = 182.78 * uni;
            //                    custo = quant * 0.897;
            //                    custo = quant - custo;
            //                    impos = custo * 0.275;
            //                    lucro = (quant - custo) - impos;
            //                    Console.WriteLine("O valor total de lucro foi de " + lucro);
            //                    break; 

            //                case "NUTRIEN": 

            //                    quant = 144.80 * uni;
            //                    custo = quant * 0.889;
            //                    custo = quant - custo;
            //                    impos = custo * 0.25;
            //                    lucro = (quant - custo) - impos;
            //                    Console.WriteLine("O valor total de lucro foi de " + lucro);
            //                    break;

            //                case "GOLDEN": 

            //                    quant = 159.46 * uni;
            //                    custo = quant * 0.717;
            //                    custo = quant - custo;
            //                    impos = custo * 0.225;
            //                    lucro = (quant - custo) - impos;
            //                    Console.WriteLine("O valor total de lucro foi de " + lucro);
            //                    break;

            //                case "SPECIALCAT": 

            //                    quant = 205.40 * uni;
            //                    custo = quant * 0.8224;
            //                    custo = quant - custo;
            //                    impos = custo * 0.22;
            //                    lucro = (quant - custo) - impos;
            //                    Console.WriteLine("O valor total de lucro foi de " + lucro);
            //                    break;

            //                case "MARBA": 

            //                    quant = 125.10 * uni;
            //                    custo = quant * 0.904;
            //                    custo = quant - custo;
            //                    impos = custo * 0.179;
            //                    lucro = (quant - custo) - impos;
            //                    Console.WriteLine("O valor total de lucro foi de " + lucro);
            //                    break;  

            //                case "GATUS": 

            //                    quant = 133.99 * uni;
            //                    custo = quant * 0.946;
            //                    custo = quant - custo;
            //                    impos = custo * 0.20;
            //                    lucro = (quant - custo) - impos;
            //                    Console.WriteLine("O valor total de lucro foi de " + lucro);
            //                    break;

            //                    default:
            //                    Console.WriteLine("Essa ração nao esta no nosso catalogo ");
            //                    break;



            //            }

//            Console.ReadKey();
//        }
//    }
//}

