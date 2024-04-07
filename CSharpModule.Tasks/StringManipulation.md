###### Reverse String
Write a C# function to reverse a given string without using any built-in string reversal functions. 

Below code reverses string using concatenation
```csharp
public string Reverse(string str)
{
    string result = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        result += str[i];
    }
    return result;
}
```

Optimize this code using `StringBuilder`.
