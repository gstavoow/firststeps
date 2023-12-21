public class Program
{
    private static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 5;

        Console.WriteLine($"N1 = {n1}");
        Console.WriteLine("N2 = " + n2);

        Console.WriteLine("***** OPERADORES ******");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("OPERADORES ARITMETICOS");
        Console.WriteLine();
        Console.WriteLine("Soma:");
        Console.WriteLine($"N1 + N2 = {n1 + n2}");

        Console.WriteLine();
        Console.WriteLine("Subtração:");
        Console.WriteLine($"N1 - N2 = {n1 - n2}");

        Console.WriteLine();
        Console.WriteLine("Multiplicação:");
        Console.WriteLine($"N1 * N2 = {n1 * n2}");

        Console.WriteLine();
        Console.WriteLine("Divisão:");
        Console.WriteLine($"N1 / N2 = {n1 / n2}");

        Console.WriteLine();

        Console.WriteLine($"N1 = {n1}");
        Console.WriteLine("N2 = " + n2);

        Console.WriteLine();
        Console.WriteLine("Modulo Exato:");
        Console.WriteLine($"N1 % N2 = {n1 % n2}");
        Console.WriteLine();

        n1 = 10;
        n2 = 4;

        Console.WriteLine($"N1 = {n1}");
        Console.WriteLine("N2 = " + n2);

        Console.WriteLine();
        Console.WriteLine("Modulo Não Exato:");
        Console.WriteLine($"N1 % N2 = {n1 % n2}");

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Este Numero é par? ");

        int entrada = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(entrada % 2 == 0 ? "Sim" : "Não");


        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("OPERADORES RELACIONAIS");
        Console.WriteLine();

        Console.Write("Digite o primeiro numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o segundo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();



        Console.WriteLine($"N1 = {n1}");
        Console.WriteLine("N2 = " + n2);


        Console.WriteLine();
        Console.WriteLine($"{n1} É MAIOR DO QUE {n2}? {n1 > n2}");
        Console.WriteLine();
        Console.WriteLine($"{n1} É MENOR DO QUE {n2}? {n1 < n2}");
        Console.WriteLine();
        Console.WriteLine($"{n1} É DIFERENTE DE {n2}? {n1 != n2}");
        Console.WriteLine();
        Console.WriteLine($"{n1} É MAIOR OU IGUAL A {n2}? {n1 >= n2}");
        Console.WriteLine();
        Console.WriteLine($"{n1} É MENOR OU IGUAL A {n2}? {n1 <= n2}");
        Console.WriteLine();
        Console.WriteLine($"{n1} É IGUAL A {n2}? {n1 == n2}");

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("OPERADORES  LOGICOS");
        Console.WriteLine();
        Console.WriteLine("OPERADOR LOGICO OU");
        Console.WriteLine();

        Console.Write("Digite o primeiro numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o segundo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o terceiro numero: ");
        int n3 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"N1 = {n1}");
        Console.WriteLine("N2 = " + n2);
        Console.WriteLine("N3 = " + n3);
        Console.WriteLine();
        Console.WriteLine($"{n1} > {n2} || {n2} >= {n3}: {n1 > n2 || n2 >= n3}");




        Console.WriteLine() ;
        Console.WriteLine() ;

        Console.WriteLine("OPERADOR LOGICO E");
        Console.WriteLine();


        Console.Write("Digite o primeiro numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o segundo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o terceiro numero: ");
        n3 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"N1 = {n1}");
        Console.WriteLine("N2 = " + n2);
        Console.WriteLine("N3 = " + n3);
        Console.WriteLine();
        Console.WriteLine($"{n1} <= {n2} && {n2} > {n3}: {n1 <= n2 && n2 > n3}");


        Console.ReadKey();
    }
}