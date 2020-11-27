using System;

namespace Atividade_27._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];
            float[] precos = new float [3];
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("----Lista de produtos----");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Nome do produto");
            nome[1] = Console.ReadLine();

            Console.WriteLine("Valor do produto");
            precos[1] = float.Parse(Console.ReadLine());

            VerificarDesconto(precos[1]);

            bool VerificarDesconto(float precos[1]){
                
                if(precos == "20"){
                    Console.WriteLine("Desconto valido");
                    return true;
                }else{
                    Console.WriteLine("Desconto invalida");
                    return false;
                }
            }


                

            

            

            




















        }
    }
}
