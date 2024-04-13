### Guideline
1. Write your solutions in StringOperations.cs class in this folder.
2. Run tests and check if your solution is correct.
3. Create a PR to main branch once your tests are passing.


#### 1. Reverse String
Write a C# function to reverse a given string without using any built-in string reversal functions.

##### Example
| Input | Output |
| :--- | :--- |
| `hello` | `olleh` |
| `world` | `dlrow` |

```csharp
public string Reverse(string str)
{
    // your code here
    
}
```
---

#### 2. Is it anagram?
Implement a function to check if two strings are anagrams of each other.

##### Example
| Input | Output |
| :--- | :--- |
| `silent` `listen` | `true` |
| `hello` `world` | `false` |

```csharp
public bool AreAnagrams(string str1, string str2)
{
    // your code here
}
```
---

#### 3. Longest Palindrome
Write a program to find the longest palindrome substring within a given string.

##### Example
| Input | Output |
| :--- | :--- |
| `forgeeksskeegfor` | `geeksskeeg` |
| `abracadabra` | `aca` |
| `aba` | `aba` |

```csharp
public string LongestPalindromeWithin(string str)
{
    // your code here
}
```
---

#### 4. Remove Duplicates
Implement a function to remove duplicate characters from a string without using any additional data structures.

##### Example
| Input | Output |
| :--- | :--- |
| `hello` | `helo` |
| `world` | `world` |
| `abracadabra` | `cd` |

```csharp
public string RemoveDuplicates(string str)
{
    // your code here
}
```
---

#### 5. Valid Palindrome
Create a method to check if a given string is a valid palindrome, considering only alphanumeric characters and ignoring cases.

##### Example
| Input | Output |
| :--- | :--- |
| `race car` | `true` |
| `race a car` | `false` |
| `A man, a plan, a canal: Panama` | `true` |

```csharp
public bool IsValidPalindrome(string str)
{
    // your code here
}
```
---

#### 6. First non-repeated character
Write a program to find the first non-repeated character in a given string.

##### Example
| Input | Output |
| :--- | :--- |
| `hello` | `h` |
| `abracadabra` | `c` |

```csharp
public char FirstNonRepeatedCharacter(string str)
{
    // your code here
}
```
---

#### 7. 
Implement a function to perform string compression, where consecutive characters are replaced with the count of the character followed by the character itself.

##### Example
| Input | Output |
| :--- | :--- |
| `aabcccccaaa` | `a2b1c5a3` |
| `aabbcc` | `a2b2c2` |

```csharp
public string Compress(string str)
{
    // your code here
}
```
---

