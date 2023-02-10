namespace Laboratorio1
{
   
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fornecer um valor real: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow(valor, 2);
           Console.WriteLine($"OValor de {valor} ao quadrado é {resultado}");    
        }
    }
}