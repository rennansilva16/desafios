## Desafio

**Preciso fazer um programa que leia os dados e calcule a comissão de cada vendedor, seguindo a seguinte regra para cada venda:**

- Vendas abaixo de R$100,00 não geram comissão.
- Vendas abaixo de R$500,00 geram 1% de comissão.
- A partir de R$500,00 geram 5% de comissão.

## Ideias

### Consulta
- Exibir a comissão de cada vendedor em formato de tabela.
- Criar um menu para consultar a comissão de todos os vendedores ou de um vendedor específico.

### Persistência
- Salvar a comissão de cada vendedor em um arquivo JSON.
- Permitir consultar posteriormente os resultados salvos.

### Histórico
- Manter um histórico das consultas realizadas.
- Permitir consultar versões anteriores dos resultados.

### Fechamento mensal
- Permitir salvar uma tabela oficial de comissão para cada mês.
- Caso já exista uma tabela oficial para o mês, permitir sua atualização mantendo a versão anterior no histórico.

## Etapas

### Etapa 1

**Objetivo**

- Calcular a comissão de cada venda.
- Agrupar as comissões por vendedor.
- Calcular o total de vendas de cada vendedor.
- Exibir os resultados em formato de tabela.

**Status:** Concluída.