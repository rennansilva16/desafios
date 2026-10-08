using desafio_2.Models;

namespace desafio_2.Services;

public class EstoqueService
{
    public static MovimentacaoEstoque MovimentarEstoque(
        List<Produto> produtos,
        int codigoProduto,
        string tipo,
        string descricao,
        int quantidade,
        int proximoId)
    {
        var produto = produtos.FirstOrDefault(
            p => p.CodigoProduto == codigoProduto);

        if (produto is null)
        {
            throw new Exception("Produto não encontrado.");
        }

        if (quantidade <= 0)
        {
            throw new Exception("A quantidade deve ser maior que zero.");
        }

        if (tipo.Equals("Saída", StringComparison.OrdinalIgnoreCase))
        {
            if (produto.Estoque < quantidade)
            {
                throw new Exception("Estoque insuficiente.");
            }

            produto.Estoque -= quantidade;
        }
        else if (tipo.Equals("Entrada", StringComparison.OrdinalIgnoreCase))
        {
            produto.Estoque += quantidade;
        }
        else
        {
            throw new Exception("Tipo de movimentação inválido.");
        }

        return new MovimentacaoEstoque
        {
            Id = proximoId,
            CodigoProduto = produto.CodigoProduto,
            Descricao = descricao,
            Tipo = tipo,
            Quantidade = quantidade
        };
    }
}