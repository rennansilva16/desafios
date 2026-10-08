## Desafio

**Preciso fazer um programa onde seja possível lançar movimentações de estoque dos produtos, realizando entrada ou saída de mercadoria no depósito.**

Cada movimentação deve possuir:

- Um número identificador único.
- Uma descrição para identificar o tipo da movimentação realizada.
- A quantidade movimentada.
- O produto movimentado.

Ao final de cada movimentação, o programa deve retornar a quantidade atual em estoque do produto movimentado.

## Etapas

### Etapa 1

**Objetivo**

- Ler os produtos e seus respectivos estoques a partir do JSON.
- Permitir realizar movimentações de entrada e saída.
- Identificar cada movimentação por um número único.
- Registrar uma descrição para cada movimentação.
- Validar a quantidade informada.
- Validar a existência do produto.
- Impedir saídas superiores ao estoque disponível.
- Atualizar o estoque do produto movimentado.
- Persistir o estoque atualizado em JSON.
- Manter o histórico das movimentações realizadas em JSON.
- Exibir a quantidade atual em estoque após a movimentação.

**Status:** Concluída.