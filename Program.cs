int opcao;

do
{
    Console.Clear();
    Console.WriteLine("------ Quatro operações ------");

    Console.WriteLine("\n------ Selecione uma opção do menu ------");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");

    opcao = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    //Console.WriteLine($"Opção: {opcao}");

    if (opcao == 1)
    {
        double n1, n2, resultado;

        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        resultado = n1 + n2;
        Console.WriteLine($"{n1} + {n2} = {resultado:N2}");
    }
    else if (opcao == 2)
    {
        double n1, n2, resultado;

        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        resultado = n1 - n2;
        Console.WriteLine($"{n1} - {n2} = {resultado:N2}");
    }
    else if (opcao == 3)
    {
        double n1, n2, resultado;

        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        resultado = n1 * n2;
        Console.WriteLine($"{n1} x {n2} = {resultado:N2}");
    }
    else if (opcao == 4)
    {
        double n1, n2, resultado;

        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        if (n2 == 0)
        {
            Console.WriteLine("O dividendo não pode ser zero!");
        }
        else
        {
            resultado = n1 / n2;
            Console.WriteLine($"{n1} ÷ {n2} = {resultado:N2}");
        }
    }
    else if (opcao == 0)
    {
        Console.WriteLine("\n\n------ Obrigado por utilizar o programa! ------");
    }
    else
    {
        Console.WriteLine("Favor digitar uma opção válida!");
    }
    
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
}
while (opcao != 0);

