# C# Interfaces

## What is an Interface?

An **interface is a list of things you promise to do**.

That’s it.

It’s like saying:

“If you want to be my pizza delivery guy, you **must** have a `DeliverPizza()` method.”

It doesn't matter **how** you deliver it: bike, car, skateboard, teleport…  
It just matters that you have a `DeliverPizza()` method.

```csharp
public interface IInterfaceName
{
    void MethodName (type param);
}

// Start interface variable names with "I" -> IMessageSender

```

---

## Why Would You Use It?

So later, if I switch from **Domino’s** to **Papa John’s**, I don’t have to rewrite my entire program.

As long as both follow the rule (both have a `DeliverPizza()` method), the code still works.

---

## Real Example — No Interface:

```csharp
public class Dominos
{
    public void DeliverPizza()
    {
        Console.WriteLine("Delivering pizza from Domino's!");
    }
}

public class PizzaApp
{
    public void Start()
    {
        var pizzaGuy = new Dominos();
        pizzaGuy.DeliverPizza();
    }
}
```

**Problem**:  
If you want to use Papa John’s instead, you have to change this:

```csharp
var pizzaGuy = new Dominos();
```

to

```csharp
var pizzaGuy = new PapaJohns();
```

And maybe also fix other code if PapaJohns works differently.

---

## Same Example — With an Interface (Better)

**Make a rule:**

```csharp
public interface IPizzaDelivery
{
    void DeliverPizza();
}
```

**Both Domino’s and Papa John’s follow the rule:**

```csharp
public class Dominos : IPizzaDelivery
{
    public void DeliverPizza()
    {
        Console.WriteLine("Delivering pizza from Domino's!");
    }
}

public class PapaJohns : IPizzaDelivery
{
    public void DeliverPizza()
    {
        Console.WriteLine("Delivering pizza from Papa John's!");
    }
}
```

**Now your PizzaApp doesn’t care who delivers pizza — as long as they follow the rule:**

```csharp
public class PizzaApp
{
    public void Start(IPizzaDelivery pizzaGuy)
    {
        pizzaGuy.DeliverPizza();
    }
}
```

---

## Swapping becomes Easy:

```csharp
var app = new PizzaApp();

app.Start(new Dominos());
// or
app.Start(new PapaJohns());
```

**No need to rewrite anything inside PizzaApp.**

Both Domino’s and Papa John’s promised to have a `DeliverPizza()` method.

---

## RECAP

**The point of an interface**  
→ so you can swap things in and out without changing your main code.

**Without interface**: your app knows too much about the specific class.  
**With interface**: your app just knows “hey as long as it can DeliverPizza(), I’m good.”

---

## Scenario:

You’re building a program that can send messages to different places.
Right now, you want to be able to send a message to:

- Email

- Text message

But later, you might add:

- Slack

- Discord

### Solution:

#### Create The Interface

```csharp
public interface IMessageSender
{
    void SendMessage (string message);
}
```

#### Use the Interface

- Create your class and have it implement the interface

```csharp
// Email Sender

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
```

```csharp
// Text Sender

public class TextSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Text Message: {message}");
    }
}

```

```csharp
// Facebook Sender

public class FacebookSender : IMessageSender
{
  public void SendMessage(string message)
  {
    Console.WriteLine($"Sending Facebook Message: {message}");
  }
}
```

```csharp
// Slack Sender

public class SlackSender : IMessageSender
{
  public void SendMessage(string message)
  {
    Console.WriteLine($"Sending Slack Message: {message}");
  }
}
```

#### Food For Thought

---

**Question:**  
So I literally use an interface when I want to enforce that a certain class contains a certain method?

**Answer:**  
At its core — **yes**.  
It's basically a contract saying:  
_"Any class that implements me must have these methods (or properties, or events)."_

---

**Question:**
So basically, when creating a class thats going to inherit from an interface, the class is FORCED to implement whatever methods, properties, or events are declared in the interface?

**Answer:**

Yes. In the following example, every class using the IMessageSender interface MUST have a SendMessage method:

```csharp
public interface IMessageSender
{
    void SendMessage (string message);
}
```

```csharp
// The SendMessage() method MUST be implemented inside of this class

public class EmailSender : IMessageSender
{
  void SendMessage(string message)
  {
      Console.WriteLine($"Sending Email Message: {message}");
  }
}
```

---

**Question:**  
When I'm creating a class that implements an interface, is there a way to quickly see what methods I have to implement?

**Answer:**  
Yes! In Visual Studio, you can **right-click on the interface name** and select **"Go To Definition"**.

This will show you the list of methods, properties, or events that your class is required to implement. It’s a quick way to check the "contract" you need to follow.

---

**Question:**  
Can a class implement more than one interface?

**Answer:**  
Yes. In C#, a class can implement multiple interfaces like this:

```csharp
public class MyClass : IInterface1, IInterface2
{
    // implement methods from both interfaces here
}
```

---
