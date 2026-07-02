-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 1

Difference between Interface and Abstract Class?

-------------------------------------

Answer

Interfaces define a contract.

Abstract classes can contain implementation.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 2

What is Dependency Injection?

-------------------------------------

Answer

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 3

What is SOLID?

-------------------------------------

Answer

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 4

Difference between IEnumerable and IQueryable?

-------------------------------------

Answer

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 5

Why would you remove set from a property?

-------------------------------------

Answer

To make the object immutable after creation or to ensure it can only be modified through controlled methods, which helps maintain a valid state.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 6

Why use a List<Employee> instead of an array?

-------------------------------------

Answer

Lists can grow and shrink dynamically.

They provide helpful methods like Add, Remove, Find, Where, and Count.

They're generally the preferred collection for business applications unless a fixed-size collection is specifically needed.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 7

What is LINQ?

-------------------------------------

Answer

LINQ (Language Integrated Query) is a feature in C# that allows you to write SQL-like queries directly in your C# code to work with collections of data.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 8

When would you use FirstOrDefault instead of First?

-------------------------------------

Answer

FirstOrDefault returns the first element of a sequence, or a default value if the sequence contains no elements. First returns the first element of a sequence, but throws an exception if the sequence contains no elements.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 9

What does Any() do?

-------------------------------------

Answer

Any() returns true if any elements in the sequence satisfy the condition, otherwise it returns false.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 10

What does Where() return?

-------------------------------------

Answer

Where() returns a filtered collection of elements that satisfy the specified condition.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 11

What is the difference between a static method and an instance method?

-------------------------------------

Answer

Static methods belong to the class itself and can be called without creating an instance of the class. Instance methods belong to an instance of the class and can only be called on an object of that class.

Eg. Static method: Math.Sqrt(16) - called on the Math class itself.
Eg. Instance method: myString.ToUpper() - called on an instance of the String class.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 12

Why would you use a private setter?

-------------------------------------

Answer

To control how the property's value can be modified, ensuring that it can only be changed in a controlled manner, such as through a public method. (Encapsulation)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 13

What is encapsulation?

-------------------------------------

Answer

Encapsulation is the principle of hiding an object's internal state and requiring all interactions to occur through well-defined methods or properties. This helps maintain valid data, protects against misuse, and improves maintainability.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 14

Why override ToString()?

-------------------------------------

Answer

ToString() is overridden to provide a string representation of an object, making it easier to display or log the object's state.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 15

When should business logic live inside a class?

-------------------------------------

Answer

Business logic should live inside a class when it is directly related to the data and behavior of that class. This promotes encapsulation and makes the code more maintainable and easier to understand.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 16

What is obfuscation?

-------------------------------------

Answer

Obfuscation is the process of making code difficult to read or understand, often used to protect intellectual property or prevent reverse engineering. It can involve renaming variables and methods to meaningless names, removing comments, and altering the structure of the code.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 17

What is the purpose of obfuscation?

-------------------------------------

Answer

Obfuscation is used to protect intellectual property, prevent reverse engineering, and make it harder for attackers to understand the code's logic and functionality.

Real world example: If you have a proprietary algorithm in your code, obfuscation can help prevent competitors from easily copying it.

Sensitive data in a database can be obfuscated to protect it from unauthorized access. This can involve techniques like encryption, tokenization, or masking to ensure that the data is not easily readable or usable by unauthorized parties.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 18

What is inheritance?

-------------------------------------

Answer

Inheritance is an object-oriented programming feature that allows one class to inherit properties and methods from another class. 

It represents an "is-a" relationship and promotes code reuse. 

For example, a Manager is an Employee, so Manager can inherit common employee functionality while adding its own behavior.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 19

What is polymorphism?

-------------------------------------

Answer

Polymorphism is a concept in object-oriented programming that allows objects of different classes to be treated as objects of a common superclass. 

It enables a single interface to represent different underlying forms (data types). Polymorphism can be achieved through method overriding (runtime polymorphism) and method overloading (compile-time polymorphism).

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 20

What is an abstract class?

-------------------------------------

Answer

An abstract class is a class that cannot be instantiated on its own and is intended to be a base class for other classes. 

It can contain both abstract methods (which must be implemented by derived classes) and concrete methods (which have an implementation). 

Abstract classes are used to define a common interface and share code among related classes.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 21

What is the difference between virtual and override?

-------------------------------------

Answer

The `virtual` keyword is used in a base class to indicate that a method can be overridden in derived classes. 

Whereas the `override` keyword is used in a derived class to provide a new implementation of a method that is declared as virtual in the base class.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 22

What does the base keyword do?

-------------------------------------

Answer

The `base` keyword is used in a derived class to access members (methods, properties, constructors) of its base class. 

It allows you to call the base class's implementation of a method or constructor, which can be useful for extending or modifying behavior while still leveraging the base class's functionality.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 23

What is the difference between protected and private?

-------------------------------------

Answer

The `protected` access modifier allows members of a class to be accessible within the class itself and by derived classes. 

Whereas the `private` access modifier restricts access to members of a class to only within that class itself, making them inaccessible to derived classes or any other external code.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 24

What is composition?

-------------------------------------

Answer

Composition is a design principle in object-oriented programming where a class is composed of one or more objects from other classes, rather than inheriting from them.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 25

When would you avoid inheritance?

-------------------------------------

Answer

Would avoid inheritance when the relationship between classes does not represent an "is-a" relationship, or when it leads to tight coupling and reduced flexibility.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 26

What is an interface?

-------------------------------------

Answer

An interface defines a contract that implementing classes must follow. It specifies what members a class must provide without defining how they are implemented.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 27

Why use interfaces?

-------------------------------------

Answer

Interfaces promote loose coupling, flexibility, testability, and allow multiple implementations of the same behavior.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 28

Can a class inherit multiple classes?

-------------------------------------

Answer

No.

C# only supports single inheritance.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 29

Can a class implement multiple interfaces?

-------------------------------------

Answer

Yes.

A class can implement as many interfaces as required.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 30

Difference between interface and abstract class?

-------------------------------------

Answer

Abstract classes define what something is.

Interfaces define what something can do.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 31

Why are interfaces important for Dependency Injection?

-------------------------------------

Answer

Because code depends on abstractions instead of concrete implementations, making it easy to replace or mock implementations.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 32 *

Suppose your application currently sends notifications by email. A client asks you to add SMS and push notifications.

Option A:

if (type == "Email")
{
    ...
}
else if (type == "Sms")
{
    ...
}
else if (type == "Push")
{
    ...
}

Option B:

INotification notification = ...;

notification.Send(message);

-------------------------------------

Answer

Option B, because it follows the Open/Closed Principle because new notification types can be added without modifying existing code. 

It also promotes loose coupling since the service depends on the INotification interface rather than a specific implementation. 

This makes the application easier to maintain, easier to extend, and much easier to unit test because implementations can be replaced with mock or fake objects.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 33

Why not just instantiate EmailNotification directly inside NotificationService?

-------------------------------------

Answer

Doing so would tightly couple NotificationService to a specific implementation. 

By depending on the INotification interface instead, the service can work with any notification type without modification. 

This makes the code more extensible, easier to maintain, and easier to test because implementations can be swapped or mocked.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 34 *

A client wants to add WhatsApp notifications. What changes are required?

-------------------------------------

Answer

Create a new WhatsAppNotification class implementing INotification. No changes are required to NotificationService, demonstrating the Open/Closed Principle.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 35 *

Why is programming to an interface better than programming to a concrete class?

-------------------------------------

Answer

It reduces coupling, allows implementations to be swapped, improves testability, and supports Dependency Injection.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Question 36 *

Why is this better?

ILogger logger

than

ConsoleLogger logger

-------------------------------------

Answer

Because the consuming class doesn't care how logging is performed; it only depends on the behavior defined by the interface.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
