using System.Globalization;
using UdemyOOP2;

static int menu() {
    Console.WriteLine("1 : Valores geometricos de um retangulo");
    Console.WriteLine("2 : Aumento de salário de Funcionario");
    Console.WriteLine("3 : Aluno aprovado?");
    Console.WriteLine("4 : Dolar para real(estático)");
    Console.Write("\nOpção: ");
    int op = int.Parse(Console.ReadLine());
    Console.Clear();
    return op;
}

int op = menu();
switch (op) {
    case 1:
        Retangulo retangulo = new Retangulo();
        Console.WriteLine("Entre a largura e altura do retangulo: ");
        retangulo.Largura=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(' ');
        retangulo.Altura=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"\nAREA = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 2:
        Funcionario funcionario = new Funcionario();
        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("\nSalário bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("\nImposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine($"\nFuncionário: {funcionario.Nome}, $ {funcionario.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}");
        Console.Write("\nDigite a porcentagem para aumentar o salário: ");
        funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        Console.WriteLine($"\nFuncionário: {funcionario.Nome}, $ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

        break;
    case 3: 
        break;
    case 4:
        break;
    default:
        break;
}