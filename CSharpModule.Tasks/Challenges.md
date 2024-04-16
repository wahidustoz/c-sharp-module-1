#### 1. Convert Age
Write a C# function that converts given age in years into days. 

- consider a year has 365 days
- ignore leap years

##### Example
| Input | Output |
| :--- | :--- |
| `65` | `23725` |
| `0` | `0` |
| `20` | `7300` |

```csharp
public int AgeInDays(int ageInYears)
{
    // your code here
}
```
---

#### 2. Basketball Score
You are counting total score for a basketball game. In basketball, players can score _2 pointer_ shots and _3 pointer_ shots. Given the number of _2 pointers_ and _3 pointers_, you need to calculate the total score.

##### Example
| Input | Output |
| :--- | :--- |
| `1 1` | `5` |
| `7 5` | `29` |
| `38 8` | `100` |

```csharp
public int CalculateTotalScore(int twoPointers, int threePointers)
{
    // your code here
}
```
---

#### 3. Formal Name
Given the _first name_, _last name_ and a boolean representing if a person is a male, write a C# function which returns the formal name in `{Mr.|Mrs.} {First name} {Last name}` format.

- First name and last name should always be [Title Case](https://en.wikipedia.org/wiki/Title_case)

##### Example
| Input | Output |
| :--- | :--- |
| `"john" "DOE" true` | `Mr. John Doe` |
| `"wahid" "AbDuHaKimOv" true` | `Mr. Wahid Abduhakimov` |
| `hermione Granger false` | `Mrs. Hermoine Granger` |

```csharp
public string FormalName(string firstName, string lastName, bool isMale)
{
    // your code here
}
```
---