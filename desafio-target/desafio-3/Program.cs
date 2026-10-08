// **Preciso fazer um programa que, a partir de um valor e de uma data de vencimento, calcule o valor dos juros na data de hoje, considerando uma multa de 2,5% ao dia.**

Console.Write("Digite o valor do documento: ");
var valorDigitado = Console.ReadLine();

if (!decimal.TryParse(valorDigitado, out var valor) || valor <= 0)
{
    Console.WriteLine("Valor inválido.");
    return;
}

Console.Write("Digite a data de vencimento (dd/mm/yyyy): ");
var dataVencimentoDigitada = Console.ReadLine();

if (!DateTime.TryParse(dataVencimentoDigitada, out var dataVencimento))
{
    Console.WriteLine("Data inválida.");
    return;
}

var dataHoje = DateTime.Today;
var diasAtraso = (dataHoje - dataVencimento.Date).Days;

if (diasAtraso > 0)
{
    var multa = CalcularMulta(valor, diasAtraso);
    var valorTotal = valor + multa;

    Console.WriteLine($"Dias de atraso: {diasAtraso}");
    Console.WriteLine($"Valor da multa: R$ {multa:F2}");
    Console.WriteLine($"Valor total a pagar: R$ {valorTotal:F2}");
}
else
{
    Console.WriteLine("Não há atraso no pagamento.");
}

static decimal CalcularMulta(decimal valor, int diasAtraso)
{
    return valor * 0.025m * diasAtraso;
}