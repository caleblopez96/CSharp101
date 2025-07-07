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
}
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
public class Dealership(string name, string location, List<Car> inventory)
{
    // Properties assigned directly from constructor parameters
    public string Name { get; set; } = name;
    public string Location { get; set; } = location;
    public List<Car> Inventory { get; set; } = inventory;
}

// create inventory list to pass as argument to inventory param
var inventory = new List<Car>();

// instantiate the object
Dealership dealership1 = new("Name", "Location", inventory);
```

**Notes:**
- **Primary constructors** declare parameters directly in the class declaration line.
- Those parameters are **in scope throughout the entire class body**, so you can use them to initialize properties.
- Great for simple data holder, configuration, or DTO-style classes.
- Can still add methods and additional logic in the class body.
- **No support for overloading** primary constructors — there’s only one parameter list.
- Cleaner syntax when constructor parameters match properties directly.

---

## Pros & Cons Table

| Classic Constructor               | Primary Constructor             |
|:----------------------------------|:--------------------------------|
| Familiar, works in older C# versions | New in C# 12+                  |
| Supports multiple/overloaded constructors | No constructor overloading  |
| Slightly more verbose             | Cleaner, less boilerplate       |
| Parameters only accessible inside constructor | Parameters accessible throughout class body |

---

## Required vs Optional Properties  
```csharp
public class Car 
{
    public required string Make { get; set; }
}

// Option 1: Object initializer syntax (works with the class as is)
Car car1 = new Car { Make = "Honda" };

// Option 2: Constructor with parameter (requires adding constructor or primary constructor)
public Car(string make)
{
    Make = make;
}
Car car2 = new Car("Honda");
```

---

### Optional (Non-Required) Properties  
If it’s not marked as `required`, you can assign it anytime after construction.

```csharp
public class Car 
{
    public string? Make { get; set; }
}

Car car = new Car() { Make = "Honda" };
car.Make = "Honda"; 

```

---

## When Should You Use a Constructor vs Object Initializers?

| Scenario                        | Use Constructor             | Use Object Initializer       |
|:--------------------------------|:----------------------------|:-----------------------------|
| You want to enforce required values for a valid object | ✅ Yes                     | ❌ Not enforced               |
| You need to validate or transform values at construction | ✅ Yes                     | ❌ Not possible directly       |
| You prefer flexibility and setting properties later | ❌ Optional                 | ✅ Ideal                     |
| You want to support multiple ways to create an object | ✅ Use overloaded constructors | ❌ No overloading in object initializers |
