using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Digite seu ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int idade = 2024 - ano;
        System.Console.WriteLine("Sua idade é " + idade + " anos.");
        if (idade >= 18)
            Console.WriteLine("Maior de idade");
        else if (idade == 1)
            Console.WriteLine("É um bebe");
        else
            Console.WriteLine("Menor de idade");
        
        //estrutura condicional de multipla escolha
        int opcao = 3;
        switch (opcao)
        {
            case 1: Console.WriteLine("1 - Somar");
                    //qualquer lógica
                    break;
            case 2: Console.WriteLine("2 - Subtrair");
                    //qualquer lógica
                    break;
            default: System.Console.WriteLine("Opção inválida!");
                     break;
        }
        
        //estrutura de repetição
        int num = 1;
        while (num <= 10)
        {
            Console.WriteLine("5 x " + num + " = " + num * 5);
            num ++;
        }
        
        for (int tabuada = 1; tabuada <= 10; tabuada++)
            for (int num = 1; num <= 10; num++)
                Console.WriteLine(tabuada + " x " + num + " = " + num * tabuada);
        
        int num = 1;
        do
        {
            Console.WriteLine("7 x " + num + " = " + num * 7);
            num ++;
        }while(num <= 10);
        */
        int[] vetor = new int[3];
        vetor[0] = 99;
        vetor[1] = 88;
        vetor[2] = 77;
        foreach (int vet in vetor)
            System.Console.WriteLine(vet);
        System.Console.WriteLine("Exemplo com for");
        for (int i = 0; i < vetor.Length; i++)
        {
            System.Console.WriteLine(vetor[i]);
        }
    }
}