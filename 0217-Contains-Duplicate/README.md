
# Notes 📝

## HashSets in C#

A HashSet is a collection in C# that is implemented as a hash table. It provides fast lookups, adds, and removes of elements. It does not maintain the order of elements and does not allow duplicate elements.

### Creating a HashSet
```cs
    // Creating an empty HashSet
    HashSet<int> numbers = new HashSet<int>();
    
    // Creating a HashSet with initial values
    HashSet<string> names = new HashSet<string>() { "John", "Mike", "Sara" };
```

### Add() Method

The Add() method is used to add an element to a HashSet. It returns a boolean value indicating whether the element was successfully added or not. If the element already exists in the HashSet, the Add() method will return false.
```cs
    HashSet<int> numbers = new HashSet<int>();
    bool result = numbers.Add(1); // result is true
    result = numbers.Add(1); // result is false (1 already exists in the HashSet)
```

### ToHashSet() Method

The ToHashSet() method is used to convert an IEnumerable collection to a HashSet. It creates a new HashSet and copies all the elements from the original collection to the new HashSet.
```cs
    List<int> list = new List<int> { 1, 2, 3, 4, 5 };
    HashSet<int> set = list.ToHashSet();
```

### Additional Methods 👾

-   `Remove(T item)` : Removes all occurrences of the specified element from the HashSet. It returns a boolean indicating whether the element was found and removed or not.
-   `Contains(T item)`: Determines whether an element is in the HashSet or not. It returns a boolean.
-   `Count`: Gets the number of elements in the HashSet.
-   `Clear()`: Removes all elements from the HashSet.


