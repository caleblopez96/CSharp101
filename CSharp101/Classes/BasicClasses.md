# Basic Classes

A class is like a blueprint or template for creating objects. It defines what data (fields) and behavior (methods) objects of that type will have.

## Class Definition

Here's the basic structure of a class:

```csharp
public class Person
{
    // Fields go here
    // Constructors go here
    // Methods go here
}
```

The `public` keyword means other parts of your program can use this class. The class name should always start with a capital letter.

## Fields

Fields are variables that store data for each object. They represent the "state" of an object.

### Public Fields

Public fields can be accessed from outside the class:

```csharp
public class Person
{
    public string Name;    // Anyone can read/write this
    public int Age;        // Anyone can read/write this
}
```

### Private Fields

Private fields can only be used inside the class. Use underscore prefix by convention:

```csharp
public class Person
{
    public string Name;
    public int Age;
    private string _email;  // Only this class can access this
}
```

### Static Fields

Static fields are shared by ALL objects of the class:

```csharp
public class Person
{
    public string Name;
    public int Age;

    // This counter is shared by all Person objects
    public static int TotalPeopleCreated = 0;
}
```

## Constructors

Constructors are special methods that run when you create an object. They initialize the object's data.

### Default Constructor

A constructor with no parameters:

```csharp
public Person()
{
    Name = "Unknown";
    Age = 0;
    _email = "no-email@example.com";
    TotalPeopleCreated++;  // Increment the shared counter
}
```

### Parameterized Constructor

A constructor that accepts values to initialize the object:

```csharp
public Person(string name, int age)
{
    Name = name;
    Age = age;
    _email = "no-email@example.com";
    TotalPeopleCreated++;
}
```

## Methods

Methods define what objects can do. They represent the "behavior" of an object.

### Instance Methods

Instance methods work on a specific object:

```csharp
public void DisplayInfo()
{
    Console.WriteLine($"Name: {Name}, Age: {Age}");
}

public void CelebrateBirthday()
{
    Age++;  // This only affects THIS person's age
    Console.WriteLine($"{Name} is now {Age} years old!");
}
```

### Methods for Private Fields

Since private fields can't be accessed directly, you need methods to work with them:

```csharp
public void SetEmail(string email)
{
    _email = email;  // Method can access private field
}

public string GetEmail()
{
    return _email;   // Method can return private field
}
```

### Static Methods

Static methods belong to the class, not to any specific object:

```csharp
public static void ShowClassInfo()
{
    Console.WriteLine($"This is the Person class.");
    Console.WriteLine($"Total people created: {TotalPeopleCreated}");
}
```

## Complete Example

Here's a complete `Person` class with all the concepts:

```csharp
public class Person
{
    // Fields
    public string Name;
    public int Age;
    private string _email;
    public static int TotalPeopleCreated = 0;

    // Default constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
        _email = "no-email@example.com";
        TotalPeopleCreated++;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        _email = "no-email@example.com";
        TotalPeopleCreated++;
    }

    // Instance methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void CelebrateBirthday()
    {
        Age++;
        Console.WriteLine($"{Name} is now {Age} years old!");
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    // Static method
    public static void ShowClassInfo()
    {
        Console.WriteLine($"Person class - Total created: {TotalPeopleCreated}");
    }
}
```

## Using the Class

Here's how you would use this `Person` class:

```csharp
public static void RunExamples()
{
    // Create objects using different constructors
    Person person1 = new Person();                    // Uses default constructor
    Person person2 = new Person("Alice", 25);        // Uses parameterized constructor

    // Use instance methods
    person1.DisplayInfo();  // Output: Name: Unknown, Age: 0
    person2.DisplayInfo();  // Output: Name: Alice, Age: 25

    // Modify object state
    person1.Name = "Bob";
    person1.Age = 30;
    person1.SetEmail("bob@example.com");

    person2.CelebrateBirthday();  // Alice becomes 26

    // Use static method (called on the class, not an object)
    Person.ShowClassInfo();  // Shows total people created

    Console.WriteLine($"Total people: {Person.TotalPeopleCreated}");
}
```

## Key Concepts

### Public vs Private

- **Public**: Can be accessed from anywhere (`person.Name`)
- **Private**: Can only be accessed within the same class (`_email`)

### Instance vs Static

- **Instance**: Each object has its own copy (`person1.Name` vs `person2.Name`)
- **Static**: Shared by all objects (`Person.TotalPeopleCreated`)

### Constructors

- Run automatically when you create an object with `new`
- Initialize the object's fields
- You can have multiple constructors with different parameters

### Methods

- Define what objects can do
- Instance methods work on specific objects
- Static methods work at the class level

## Why Use Classes?

Classes help you organize code by grouping related data and behavior together. Instead of having separate variables for name, age, and email scattered throughout your code, you can bundle them into a `Person` class that knows how to work with that data.

```csharp
// Without classes - messy and hard to manage
string person1Name = "Alice";
int person1Age = 25;
string person1Email = "alice@example.com";

string person2Name = "Bob";
int person2Age = 30;
string person2Email = "bob@example.com";

// With classes - organized and easy to work with
Person person1 = new Person("Alice", 25);
Person person2 = new Person("Bob", 30);
person1.SetEmail("alice@example.com");
person2.SetEmail("bob@example.com");
```
