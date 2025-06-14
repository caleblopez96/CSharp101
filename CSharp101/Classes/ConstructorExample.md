
# C# Class Constructors Traditional vs Primary

## Without Primary Constructor (classic)
```csharp
public class Dealership
{
    // Properties
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Car> Inventory { get; set; }

    // Constructor
    public Dealership(string name, string location, List<Car> inventory)
    {
        Name = name;
        Location = location;
        Inventory = inventory;
    }
}
```

**Notes:**
- This is the traditional, pre-C# 12 way.
- Properties are declared at the top.
- Values are passed into a constructor and assigned inside the constructor body.
- You can overload constructors easily with this pattern.

---

## With Primary Constructor (C# 12+)
```csharp
public class Dealership(string name, string location, List<Car> inventory)
{
    // Properties assigned directly from constructor parameters
    public string Name { get; set; } = name;
    public string Location { get; set; } = location;
    public List<Car> Inventory { get; set; } = inventory;
}
```

**Notes:**
- **Primary constructors** let you declare parameters directly in the class declaration.
- Those parameters are **in scope in the entire class body**, which is why you can use them to initialize properties directly.
- Good for simple, immutable, or configuration-style classes.
- Can still add methods and additional logic inside the class body.
- You **can’t overload primary constructors** — there's only one set of parameters.
- Cleaner syntax when a class’s constructor parameters directly match its properties.

---

## Pros & Cons Table

| Classic Constructor  | Primary Constructor |
|:---------------------|:--------------------|
| Familiar, works in older C# versions | New in C# 12+ |
| Supports multiple/overloaded constructors | No constructor overloading |
| Slightly more verbose | Cleaner and less boilerplate |
| Parameters only accessible inside constructor | Parameters accessible throughout class body |
