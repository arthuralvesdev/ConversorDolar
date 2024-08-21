namespace ConversorDolar
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Informe o valor em dolar: ");
            double valorEmDolar = double.Parse(Console.ReadLine());
            double valorEmReais = valorEmDolar * 5.24;
            Console.WriteLine("O valor em reais é: " + valorEmReais);
            
        }
    }
}