using System.Text.Json;
using desafio_2.Models;

namespace desafio_2.Services;

public class MovimentacaoJsonService
{
    public static List<MovimentacaoEstoque> LerMovimentacoes(
        string caminhoArquivo)
    {
        if (!File.Exists(caminhoArquivo))
        {
            return [];
        }

        var json = File.ReadAllText(caminhoArquivo);

        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        return JsonSerializer.Deserialize<List<MovimentacaoEstoque>>(json) ?? [];
    }

    public static void SalvarMovimentacoes(
        string caminhoArquivo,
        List<MovimentacaoEstoque> movimentacoes)
    {
        var json = JsonSerializer.Serialize(
            movimentacoes,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(caminhoArquivo, json);
    }

    public static int ObterProximoId(
        List<MovimentacaoEstoque> movimentacoes)
    {
        if (movimentacoes.Count == 0)
        {
            return 1;
        }

        return movimentacoes.Max(m => m.Id) + 1;
    }
}