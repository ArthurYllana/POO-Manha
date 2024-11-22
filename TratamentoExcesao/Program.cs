// Função main()

double a = 9;
double b = 0;
//try
{
    System.Console.WriteLine("Resultado " + (a/b));
}
//catch (Exception e)
{
    System.Console.WriteLine("Não pode ocorrer divisão por zero!");
}
System.Console.WriteLine("Termino do programa!");

/*
try
{
    // Isto causará uma exceção
    File.OpenRead("\\teste\\ArquivoLeitura.txt");
}

catch (FileNotFoundException e)
{
    Console.WriteLine();
    Console.WriteLine("Erro pelo FileNotFoundException");Console.WriteLine("-------------------------------------");Console.WriteLine(e.ToString());Console.WriteLine();
}

catch (DirectoryNotFoundException e)
{
    Console.WriteLine();
    Console.WriteLine("Erro pelo DirectoryNotFoundException");Console.WriteLine("-------------------------------------");Console.WriteLine(e.ToString());Console.WriteLine();
}

catch (Exception e)
{
    Console.WriteLine();
    Console.WriteLine("Erro pelo Exception");Console.WriteLine("-------------------------------------");Console.WriteLine(e.ToString());Console.WriteLine();
}
System.Console.WriteLine("Termino do programa!");
*/