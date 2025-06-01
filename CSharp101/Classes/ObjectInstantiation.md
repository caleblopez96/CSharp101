# Object Instantiation

Object instantiation is the process of creating instances (objects) from a class. Think of a class as a blueprint, and objects as the actual houses built from that blueprint.

## Basic Object Creation

The most common way to create an object is using the `new` keyword:

```csharp
// Basic syntax: ClassName objectName = new ClassName();
Person person1 = new Person();
Person person2 = new Person("John", 25);
```

## Different Ways to Create Objects

### 1. Using Default Constructor

When you don't pass any parameters, the default constructor is called:

```csharp
Person person = new Person();
// This calls the constructor with no parameters
// Fields get default values set in the constructor
```

### 2. Using Parameterized Constructor

Pass values directly to initialize the object:

```csharp
Person person = new Person("Alice", 30);
// This calls the constructor that takes name and age
// Fields are set to the values you provide
```

### 3. Object Initializer Syntax

You can set public fields or properties after creation:

```csharp
Person person = new Person()
{
    Name = "Bob",
    Age = 25
};

// This is equivalent to:
Person person = new Person();
person.Name = "Bob";
person.Age = 25;
```

### 4. Combining Constructor and Initializer

Use a constructor AND set additional fields:

```csharp
Person person = new Person("Charlie", 35)
{
    Email = "charlie@example.com"
};
```

## Working with Objects After Creation

Once you have an object, you can use its methods and access its fields:

```csharp
Person person = new Person("Diana", 28);

// Access public fields
Console.WriteLine(person.Name);  // Output: Diana
Console.WriteLine(person.Age);   // Output: 28

// Call methods
person.CelebrateBirthday();      // Increases age by 1
person.DisplayInfo();            // Shows person's information

// Modify fields
person.Name = "Diana Smith";
person.Age = 29;
```

## Multiple Objects from Same Class

You can create as many objects as you need from the same class:

```csharp
Person person1 = new Person("John", 25);
Person person2 = new Person("Jane", 30);
Person person3 = new Person("Mike", 35);

// Each object is independent
person1.CelebrateBirthday();  // Only affects person1
person2.SetEmail("jane@example.com");  // Only affects person2
```

## Static vs Instance Members

### Instance Members

Each object has its own copy of instance fields and methods:

```csharp
Person person1 = new Person("Alice", 25);
Person person2 = new Person("Bob", 30);

person1.Age = 26;  // Only changes person1's age
// person2.Age is still 30
```

### Static Members

Static fields and methods belong to the class, not to any specific object:

```csharp
// Access static members through the class name, not an object
Console.WriteLine(Person.TotalPeopleCreated);  // Shows total count
Person.ShowClassInfo();  // Calls static method

// You DON'T use an object for static members:
// person1.TotalPeopleCreated  // ❌ Wrong way
```

## Complete Example

Here's a full example showing different instantiation methods:

```csharp
public static void RunExamples()
{
    // 1. Default constructor
    Person person1 = new Person();
    Console.WriteLine($"Person 1: {person1.Name}, {person1.Age}");

    // 2. Parameterized constructor
    Person person2 = new Person("Alice", 25);
    Console.WriteLine($"Person 2: {person2.Name}, {person2.Age}");

    // 3. Object initializer
    Person person3 = new Person()
    {
        Name = "Bob",
        Age = 30
    };
    Console.WriteLine($"Person 3: {person3.Name}, {person3.Age}");

    // 4. Using the objects
    person2.CelebrateBirthday();
    person3.SetEmail("bob@example.com");

    // 5. Static members
    Console.WriteLine($"Total people: {Person.TotalPeopleCreated}");
    Person.ShowClassInfo();
}
```

## Key Points to Remember

1. **Use `new` keyword** to create objects from classes
2. **Each object is independent** - changing one doesn't affect others
3. **Constructor parameters** initialize the object when it's created
4. **Object initializers** are a shorthand for setting fields after creation
5. **Static members** belong to the class, accessed through class name
6. **Instance members** belong to specific objects, accessed through object name

## Common Mistakes

```csharp
// Wrong - trying to use class like an object
Person.Name = "John";  // Error! Name is not static

// Wrong - trying to use static member on object
Person person = new Person();
person.TotalPeopleCreated++;  // Error! TotalPeopleCreated is static

// Correct way
Person person = new Person();
person.Name = "John";  // Instance member on object
Person.TotalPeopleCreated++;  // Static member on class
```
