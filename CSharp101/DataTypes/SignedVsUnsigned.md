# 📌 When to Use Signed vs Unsigned

## Signed

Use if your number **might be negative**.

| Type      | Size    | Range                                    |
| :-------- | :------ | :--------------------------------------- |
| `sbyte`   | 8-bit   | -128 to 127                              |
| `short`   | 16-bit  | -32,768 to 32,767                        |
| `int`     | 32-bit  | -2,147,483,648 to 2,147,483,647          |
| `long`    | 64-bit  | A very large negative to positive number |
| `float`   | 32-bit  | ±3.4 × 10³⁸, ~7 digits of precision      |
| `double`  | 64-bit  | ±1.7 × 10³⁰⁸, ~15-16 digits of precision |
| `decimal` | 128-bit | ±7.9 × 10²⁸, ~28-29 digits of precision  |

---

## Unsigned

Use if your number will **always be zero or positive**.

| Type     | Size   | Range                             |
| :------- | :----- | :-------------------------------- |
| `byte`   | 8-bit  | 0 to 255                          |
| `ushort` | 16-bit | 0 to 65,535                       |
| `uint`   | 32-bit | 0 to 4,294,967,295                |
| `ulong`  | 64-bit | 0 to a very large positive number |

---

> **Note:**  
> If the type doesn't have a `u` before it (like `uint`), it’s **signed by default**.

---

# How to Pick the Right Type?

Ask yourself:

1. **Will this number ever be negative?**

   - Yes → Use a signed type (`int`, `float`, `decimal`)
   - No → Go to 2

2. **Will it always be zero or positive?**

   - Yes → Use an unsigned type (`uint`, `byte`)
   - No → Go to 3

3. **Do I need to store decimal or fraction values?**

   - Yes → Use `float`, `double`, or `decimal`
   - No → Go to 4

4. **Is high precision important (like for money or calculations you can't afford to round)?**

   - Yes → Use `decimal` (more precise than `float`/`double`)
   - No → Go to 5

5. **Is the number super small (like between 0-255)?**

   - Yes → Use `byte` or `sbyte`
   - No → Go to 6

6. **Is it a very large number?**
   - Yes → Use `long`, `ulong`, or `decimal` (if decimals are needed)
   - No → Use `int` (safe default for most whole numbers)

---

> **If you're unsure, start with `int` for whole numbers or `double` for decimals and optimize later if necessary.**
