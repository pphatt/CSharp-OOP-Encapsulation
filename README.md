# C# OOP Encapsulation example

### Encapsulation Explained:

- `Encapsulation` is one of the fundamental principles of Object-Oriented Programming (OOP). 
It is the practice of bundling data (fields) and methods (functions) that operate on that data within a single unit 
(class) while restricting direct access to some of the object's components. 
This ensures that the internal implementation details of a class are hidden from the outside world, exposing only what is necessary.

- Encapsulation provides `data hiding`, `data protection`, and `controlled access` through `access modifiers`.

- **Short explained:** Hiding the internal state (properties) and functionality of an object and only allowing access through a public set of functions.

- Control the visibility of class members **(Access Modifiers)**:
  * `public`: Accessible everywhere.
  * `private`: Accessible only within the same class.
  * `protected`: Accessible within the class and derived classes.
  * `internal`: Accessible within the same assembly.
  * `protected internal`: Accessible within the same assembly or derived classes.
  * `private protected`: Accessible within the containing class or derived classes in the same assembly.

- **Properties:**
  * Encapsulation is often implemented using `properties`, which act as intermediaries to access `private fields`.
  * Properties allow data validation and logic before `getting` or `setting` a field.

- **Data Hiding:**
  * Only the necessary details of an object are exposed **(via methods or properties)**, while 
  internal details (state or values) are hidden to prevent misuse (prevent outside the class to use).

- New data structure here is `Property` in C# (search `Encapsulation in C#` and look for the microsoft learn once).

# Reference:

- [Encapsulation Explained](https://chatgpt.com/share/678e5d69-4090-8013-aab5-233f725f84f8)
- [Microsoft Encapsulation Explained](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)
