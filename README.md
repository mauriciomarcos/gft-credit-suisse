# gft-credit-suisse
Repositório criado para avaliação do teste realizado a partir do desafio indicado no README.
Foram desenvolvidas duas fromas distintas para a resolução do problema.
**Resolução-01:** Criada uma estratégia utilizando condicional para resolver o problema.
**Resolução-02:** Aplicado o Pattern Strategy para a resolução do problema.

## Question 1. Identify the categories of trades in a bank´s portfolio.
A bank has a portfolio of thousands of trades and they need to be categorized.
A trade is a commercial negotiation between a bank and a client.
Each trade has a value that indicates the transaction amount in dollars and a text indicating if the client´s sector is "Public" or "Private". They implement the following interface:

```csharp
interface ITrade
{
    double Value { get; }

    string ClientSector { get; }
}
```
Currently, there are three categories rules:
**LOWRISK:** Trades with value less than 1,000,000 and client from Public Sector
**MEDIUMRISK:** Trades with value greater than 1,000,000 and client from Public Sector
**HIGHRISK:** Trades with value greater than 1,000,000 and client from Private Sector

Imagine you receive a list of trades and you need to return a list of categories as below:
input: **List<ITrade> portfolio**
output: **List<string> tradeCategories**

Example:

**Input:**
```csharp
Trade1 {Value = 2000000; ClientSector = "Private"}
Trade2 {Value = 400000; ClientSector = "Public"}
Trade3 {Value = 500000; ClientSector = "Public"}
Trade4 {Value = 3000000; ClientSector = "Public"}
portfolio = {Trade1, Trade2, Trade3, Trade4}
```
**Output:**
```csharp
tradeCategories = {"HIGHRISK", "LOWRISK", "LOWRISK", "MEDIUMRISK"}
```
**Your design must take into account category rules can be added/removed/modified and will become highly complex in the near future.**

**Please write your answer in pseudo-code showing clearly what classes, interfaces, methods and design patterns you would create/use to solve this problem. Also, object oriented programming is appreciated.**
