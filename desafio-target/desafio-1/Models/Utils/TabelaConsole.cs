namespace desafio_1.Models.Utils;

public class TabelaConsole
{
    public static void ExibirComissoes(List<ComissaoVendedor> comissoes)
    {
        Console.WriteLine();
        Console.WriteLine("COMISSÃO DOS VENDEDORES");
        Console.WriteLine(new string('-', 75));

        Console.WriteLine(
            $"{"Vendedor",-25} {"Total de Vendas",20} {"Comissão",20}");

        Console.WriteLine(new string('-', 75));

        foreach (var comissao in comissoes)
        {
            Console.WriteLine(
                $"{comissao.Vendedor,-25} " +
                $"{comissao.TotalVendas,20:C2} " +
                $"{comissao.TotalComissao,20:C2}");
        }

        Console.WriteLine(new string('-', 75));
    }
}