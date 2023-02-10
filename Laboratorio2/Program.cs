namespace Laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Informa o Nome e salário do funcionario

            Console.WriteLine("Informe o nome do funcionario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do funcionario: ");
            double salario = Convert.ToDouble(Console.ReadLine());



            // Desconto de 10% sobre o salário Fornecido OBS: Na string resposta os caracteres :c após as variavei adiciona o caractere R$ antes do valor da variavel
            double desconto = salario * 10 / 100;
            double salarioLiquido = salario - desconto;

            string resposta = $"Funcionario: {nome} \nSalario Bruto: {salario:c}\n" + $"Desconto: {desconto:c}\nSalario Liquido: {salarioLiquido:c}";
            Console.WriteLine(resposta);

        }
    }
}