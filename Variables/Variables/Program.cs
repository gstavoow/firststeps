internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine("aperte qualquer tecla para sair");
        //Console.ReadKey();

        //criar uma variavel boolean (bool)
        //criar uma variavel float -uma casa decimal
        //criar uma variavel double -duas casas decimais
        //criar uma variavel decimal -mais de duas casas decimais


        int numero = 90;
        string nome = "gustavo";
        bool ehVerdadeiro = true;


        Console.WriteLine(nome);
        Console.WriteLine(numero);
        Console.WriteLine(ehVerdadeiro);
        Console.WriteLine(string.Empty);



        numero = numero + 92;
        nome = "dugdhyf";
        ehVerdadeiro = false;

        Console.WriteLine(nome);
        Console.WriteLine(numero);
        Console.WriteLine(ehVerdadeiro);
        Console.WriteLine("");
     
        Console.WriteLine("escreva o primeiro numero");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escreva o segundo numero");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"resultado {n1 + n2}");
        if (n1 + n2 == 10)
        {
            Console.WriteLine("oloco");
        }
        else
        {
            Console.WriteLine("aperte qualquer tecla para sair");
            Console.ReadKey();
        }




    }
}