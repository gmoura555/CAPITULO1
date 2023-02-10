namespace Laboratorio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Armazena o Nome do Funcionario na variavel "nome"
            Console.WriteLine("Informe o nome do Funcionario: ");
           string nome = Console.ReadLine();

            //Armazena o Salario informado na varivel "salario" 
            Console.WriteLine("Informe o salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            
            //Armazena o valor gasto com transporte na variavel "gastoTranporte"
            Console.WriteLine("Informe o gasto com transporte: ");
            double gastoTransporte = Convert.ToDouble(Console.ReadLine());

            //Calcula o valor de 6% sobre o valor da variavel salario
            double vt = salario * 6 / 100;

            //Verifica o valor real do Vale transporte
            double vtReal = (gastoTransporte > vt ? vt : gastoTransporte);

            //salario com o desconto do Vt
            double salarioLiquido = (salario - vtReal + gastoTransporte);

            //Apresenta os resultados
            string resultado = $"\nFuncionário: {nome}\n" + $"Salário: {salario}\n" + $"Desconto VT: {vtReal:c}" ;
            Console.WriteLine(resultado);
                                                  
        }
    }
}