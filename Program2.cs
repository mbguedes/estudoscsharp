class Program2
{
    static void Main()
    {
        NotaMedia();
    }

    static void NotaMedia()
    {
        Console.WriteLine("Digite a nota do 1º trimestre: ");
        int nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do 2º trimestre: ");
        int nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do 3º trimestre: ");
        int nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do 4º trimestre: ");
        int nota4 = int.Parse(Console.ReadLine()); 

        double mediaAnual = (nota1 + nota2 + nota3 + nota4) / 4.0;

        if (mediaAnual >= 7)
        {
            Console.WriteLine("Média anual: " + mediaAnual + " - Nota suficiente para aprovação.");
        }
        else
        {
            Console.WriteLine("Média anual: " + mediaAnual + " - Nota não suficiente para aprovação.");
        }
    }
}
