### Guideline
1. Write your solutions in Numbers.cs class in this folder.
2. Run tests and check if your solution is correct.
3. Create a PR to main branch once your tests are passing.


#### 1. Checked addition
Write a C# function to add two integers and return the result. Return `-1` if the addition overflows.

##### Example
| Input | Output |
| :--- | :--- |
| `1 2` | `3` |
| `2147483647 2147483647` | `-1` |

```csharp
public int CheckedAdd(int a, int b)
{
    // your code here
}
```
---

#### 2. Clean number
Write a C# function which accepts a string with numbers, spaces and special characters in it. Clean out the all non-numeric characters and parse the string into single BigInteger type.

If the string doesnt contain numeric characters, then return a BigInteger with value `0`.

##### Example
| Input | Output |
| :--- | :--- |
| `1 2` | `12` |
| `21##47 48asdf3647` | `2147483647` |
| `asdf<>?<` | `0` |

```csharp
public BigInteger CleanNumber(string str)
{
    // your code here
}
```
---

#### 3. Add Transactions
You are building a financial transaction tracking system for a large corporation. Due to the scale of operations, transactions involve extremely large amounts of money represented as strings. Implement a function `AddTransaction` that takes two transaction amounts represented as strings and returns their sum.

##### Example
| Input | Output |
| :--- | :--- |
| `"" ""` | `0` |
| `"1231231231231231233123123123123123123123" "1231231231231231233123123123123123123123"` | `2462462462462462466246246246246246246246` |

```csharp
public BigInteger AddTransactions(string amount1, string amount2)
{
    // your code here
}
```
---

#### 4. Predict Population
In a demographic study, you're analyzing population growth over several decades. Implement a function `PredictPopulation` that takes the initial population size and growth rate  and predicts the population after a certain number of years.

##### Example
| Input | Output |
| :--- | :--- |
| `500000 3 10` | `48828125000000000000` |
| `1000 1 20` | `1000` |

```csharp
public BigInteger PredictPopulation(BigInteger initialPopulation, int growthRate, int years) 
{
    // Your code here
}
```
---


#### 5. Currency Conversion
You are building a currency conversion tool that needs to accurately convert an amount from one currency to another. Implement a function `ConvertCurrency` that takes a decimal amount in one currency and a float exchange rate, and returns the equivalent amount in the target currency.

##### Example
| Input | Output |
| :--- | :--- |
| `1000 12663.90` | `12663900` |