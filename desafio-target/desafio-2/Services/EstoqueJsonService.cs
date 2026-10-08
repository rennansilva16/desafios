using System.Text.Json;
using desafio_2.Models;

namespace desafio_2.Services;

public class EstoqueJsonService
{
    public static List<Produto> LerArquivoJson(string caminhoArquivo)
    {
        var json = File.ReadAllText(caminhoArquivo);

        var estoqueResponse = JsonSerializer.Deserialize<EstoqueResponse>(
            json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        return estoqueResponse?.Estoque ?? [];
    }

    public static void SalvarArquivoJson(
        string caminhoArquivo,
        List<Produto> produtos)
    {
        var estoqueResponse = new EstoqueResponse
        {
            Estoque = produtos
        };

        var json = JsonSerializer.Serialize(
            estoqueResponse,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(caminhoArquivo, json);
    }
}