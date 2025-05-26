# C# Syntax Breakdown

[access modifier] [static (optional)] [const|readonly (optional)] dataType
variableName = value;

## Access Modifier (REQUIRED, defaults to private)

- PURPOSE: specify the visibility or access level of the variable
- OPTIONS:
  - public: accessible from anywhere
  - private: accessible only within the class where its declared
  - protected: accessin;e within the class and its derived classes
  - internal: accessible within the same assembly
  - protected internal: accessible within the same assembly and derived classes.
  - private protected: accessible within the class and its derived classes in
    the same assembly

## Static (OPTIONAL)

- PURPOSE: makes the variable and value accessible by all instances of the class
- OPTIONAL: not required unless variable and variable value needs to be shared
  across all instances of the class

```c#
  public static int sharedValue = 10;  // shared among all instances of the class
  public int notShared; // unique to each instance
```

## [const|readonly] (OPTIONAL)

- PURPOSE:

  - const: declares a constant variable whose value is fixed at compile time and
    cannot be changed
  - readonly: defines a variable whose value can only be assigned at runtime,
    either at declaration or inside constructor

```c#
  const int MaxValue = 100; // const that cant be changed
  readonly int instanceValue; // can only be assigned in constructor
```

## dataType (REQUIRED)

- PURPOSE: specifies data that the variable will hold (int, string, etc...)
- REQUIRED: you have to specify that data type for every variable

```c#
int age = 25;
```

## variable name (REQUIRED)

- PURPOSE: create identifier for the variable

  - camelCase for local variables (myVariable)
  - PascalCase for properties and fields (MyField)

- REQUIRED: variables must have a name

  - follow naming conventions

## value (OPTIONAL)

- PURPOSE: optionally init the value of the variable
- OPTIONAL: not all variables have to be assigned a value at declaration.

```c#
int age = 30
```

### Variable Declaration Decision Process:

#### Step 1: Choose an access modifier:<br>

- public, private, protected, internal, protected internal, or private
  protected. The default value is private.

#### Step 2: Static check: <br>

Decide if the variable should be shared across all instances. <br> If yes add
static, if not dont inlcude static.

#### Step 3: const | readonly check: <br>

Decide if variable should be const or readonly <br> -> if value should never
change and is known at compile time, use const <br> -> if value should be set
once at runtime (in constructor or declaration), use readonly

#### Step 4: Choose the correct data type

-> int, string, bool, double, etc...

#### Step 5: Name the variable

-> camelCase for private/internal fields<br> -> PascalCase for public
fields/properties
