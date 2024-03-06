using System;

class Program 
{
  static void Main()
    {
        Console.WriteLine("Digite sua nota");
        double nota =
         Convert.ToDouble(Console.ReadLine());

        //Verificação se a nota é maior de 6

        if (nota >=6)
        {
            Console.WriteLine("O aluno passou!");
        }
        else
        {
            Console.WriteLine("O aluno não passou");
        }

    }
}


