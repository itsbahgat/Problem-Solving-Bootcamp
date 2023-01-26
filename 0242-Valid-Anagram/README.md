#  Notes 📝
## SequenceEqual() Method in C#

The `SequenceEqual()` method in C# is a LINQ extension method that is used to determine whether two sequences are equal by comparing their elements by using the default equality comparer for their type. It returns a Boolean value indicating whether the two sequences are equal.

Here is an example of how to use the `SequenceEqual()` method:
```cs
    int[] array1 = new int[] { 1, 2, 3 };
    int[] array2 = new int[] { 1, 2, 3 };
    
    bool areEqual = array1.SequenceEqual(array2);
    Console.WriteLine(areEqual); // Output: True
```
> **Note** that the method will return `False` if the two sequences have different number of elements, also it will return false if the elements are not in the same order.

Also, you can use the `SequenceEqual()` method on any type of IEnumerable, such as List, Array, etc.
```cs
    List<int> myList = new List<int> { 1, 2, 3 };
    int[] myArray = new int[] { 1, 2, 3 };
    
    bool areEqual = myList.SequenceEqual(myArray);
    Console.WriteLine(areEqual); // Output: True
```
## Comparing Dictionaries in C#

The `Except` method in C# is used to compare two dictionaries and create a new dictionary that contains the items from the first dictionary (dic1) that are not present in the second dictionary (dic2).

    
```cs
	Dictionary<string, int> dic1 = new Dictionary<string, int>()
	{
	    {"apple", 1},
	    {"banana", 2},
	    {"orange", 3},
	};

	Dictionary<string, int> dic2 = new Dictionary<string, int>()
	{
	    {"banana", 2},
	    {"orange", 4},
	    {"grape", 5},
	};

	var result = dic1.Except(dic2); // { "apple", 1 }, {"orange", 3}
```	
> **Note** that the Except method compares the items based on the key and the value both, so in the example above it's not only comparing the keys but also the values.	
---
The `Any()` method is a method of the `IEnumerable` class, it returns a Boolean value indicating whether the collection contains any elements.


```cs
bool areDifferent = dic1.Except(dic2).Any();
```
	
In this example, the output will be `true`.




