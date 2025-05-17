{
        Console.Write("Digite o salário por hora: ");
        double salarioHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o total de horas normais trabalhadas: ");
        double horasNormais = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o total de horas extras: ");
        double horasExtras = Convert.ToDouble(Console.ReadLine());

        double salarioFinal = CalcularSalario(salarioHora, horasNormais, horasExtras);

        Console.WriteLine($"Salário total: R$ {salarioFinal:F2}");
    }

    static double CalcularSalario(double salarioHora, double horasNormais, double horasExtras)
    {
        double valorHorasNormais = salarioHora * horasNormais;
        double valorHorasExtras = salarioHora * 1.4 * horasExtras;
        return valorHorasNormais + valorHorasExtras;
    }