# C# Class Constructors: Traditional vs Primary  

## Without Primary Constructor (Classic C#)

```csharp
public class Dealership
{
    // Properties
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Car> Inventory { get; set; }

    // Constructor Example 1: No params
    public Dealership()
    {
        Name = "Unknown";
        Location = "Unknown";
        Inventory = new List<Car>();
    }

    // Constructor Example 2: 2 params
    public Dealership(string name, string location) 
    {
        Name = name;
        Location = location;
        Inventory = new List<Car>();
    }

    // Constructor Example 3: 3 params
    public Dealership(string name, string location, List<Car> inventory)
    {
        Name = name;
        Location = location;
        Inventory = inventory;
    }

    public void Describe() => Console.WriteLine($"Name: {Name}, Location: {Location}, Inventory: {Inventory}");
}
```
USAGE:
```csharp
Dealership dealership1 = new();
dealership1.Describe(); // Name: Unknown, Location: Unknown, Inventory: No cars in inventory.

Dealership dealership2 = new("Honda Chandler", "Chandler, AZ
dealership2.Describe(); // Name: Honda Chandler, Location: Chandler, Inventory: - No cars in inventory.

List<Car> inventory = new()
{
    new Car("Toyota", "Camry", 2020),
    new Car("Toyota", "Corolla", 2019
    new Car("Toyota", "RAV4", 2021)
};
Dealership dealership3 = new("Toyota Chandler", "Chandler, AZ", inventory);
dealership3.Describe();
/*
    Name: Toyota Chandler, Location: Chandler, AZ
    Inventory:
    -2020 Toyota Camry
    -2019 Toyota Corolla
    -2021 Toyota RAV4
*/
```

**Notes:**
- This is the traditional, pre-C# 12 way.
- Properties are declared inside the class.
- Values are passed into a constructor and assigned inside its body.
- You can overload constructors easily with this pattern.
- Constructor parameters are only accessible inside the constructor body.

---

## With Primary Constructor (C# 12+)

```csharp
public class Dealership(string name = "Unknown", string location = "Unknown", List<Car>? inventory = null)
{
    // Properties
    public string Name { get; set; } = name;
    public string Location { get; set; } = location;
    public List<Car> Inventory { get; set; } = inventory ?? new List<Car>();

    public void Describe() => Console.WriteLine($"Name: {Name}, Location: {Location}, Inventory: {Inventory}");
}

// Usage examples:
Dealership dealership1 = new();
dealership1.Describe(); // Name: Unknown, Location: Unknown, Inventory: No cars in inventory.

Dealership dealership2 = new("Honda Chandler", "Chandler, AZ");
dealership2.Describe(); // Name: Honda Chandler, Location: Chandler, AZ, Inventory: - No cars in inventory.

List<Car> inventory = new()
{
    new Car("Toyota", "Camry", 2020),
    new Car("Toyota", "Corolla", 2019),
    new Car("Toyota", "RAV4", 2021)
};
Dealership dealership3 = new("Toyota Chandler", "Chandler, AZ", inventory);
dealership3.Describe();
/*
    Name: Toyota Chandler, Location: Chandler, AZ
    Inventory:
    -2020 Toyota Camry
    -2019 Toyota Corolla
    -2021 Toyota RAV4
*/
```

**Notes:**
- **Primary constructors** declare parameters directly in the class declaration line.
- Those parameters are **in scope throughout the entire class body**, so you can use them to initialize properties.
- Great for simple data holder, configuration, or DTO-style classes.
- Can still add methods and additional logic in the class body.
- **No support for overloading** primary constructors — there’s only one parameter list.
- Cleaner syntax when constructor parameters match properties directly.

---