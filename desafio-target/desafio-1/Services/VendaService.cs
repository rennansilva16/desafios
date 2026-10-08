using desafio_1.Models;

public class VendaService
{

    public static decimal CalcularComissao(decimal valorVenda)
    {
        //- Vendas abaixo de R$100,00 não gera comissão
        // - Vendas abaixo de R$500,00 gera 1% de comissão
        // - A partir de R$500,00 gera 5% de comissão

        switch (valorVenda)
        {
            case < 100:
                return 0;
            case < 500:
                return valorVenda * 0.01m;
            default:
                return valorVenda * 0.05m;
        }
    }

    public static List<ComissaoVendedor> CalcularComissaoPorVendedor(List<Venda> vendas)
    {
        return vendas
        .GroupBy(v => v.vendedor)
        .Select(g => new ComissaoVendedor
        {
            Vendedor = g.Key,
            TotalVendas = g.Sum(v => v.valor),
            TotalComissao = g.Sum(v => CalcularComissao(v.valor))
        }).ToList();
    }
}