# Variables

int

Whole numbers

Example:

int age = 30;

-------------------------------------

double

Scientific calculations

Example:

double height = 1.75;

-------------------------------------

decimal

Money

Example:

decimal salary = 25000.50m;

-------------------------------------

float

Used for gaming development - where precision is not as important

Example:

float speed = 120.5f;


# Collections

A List<T> is a collection of objects that can be accessed by index. It provides methods to manipulate the list, such as adding, removing, and searching for items.

The difference between an array and a list is that an array has a fixed size, while a list can grow and shrink dynamically.

A foreach loop is used to iterate over the elements of a list. It allows you to access each element in the list without needing to know the index.

Count property is used to get the number of elements in a list.

Add method is used to add an item to the end of the list.

RemoveAt method is used to remove an item at a specific index in the list.

Find method is used to find an item in the list that matches a specific condition.

FirstOrDefault method is used to return the first element of a list that matches a specific condition, or a default value if no such element is found.

Any method is used to determine if any elements in the list satisfy a specific condition.

Where method is used to filter the elements of a list based on a specific condition.

Average method is used to calculate the average of the elements in a list.


# Methods

Instance Method:

Belong to an object.

Require an instance to be called.

Example:

employee.GiveRaise(5000m);

-------------------------------------

Static Method:

Belong to the class itself.

Do not require an object.

Example:

Math.Max(10,20);

-------------------------------------

Private Setter:

Allows a property to be modified only from inside its own class.

Example:

public decimal Salary { get; private set; }

-------------------------------------

ToString():

Returns a string representation of an object.

Override it to make objects easier to print and debug.


# Object-Oriented Programming

## Inherirance

Allows a class to inherit members from another class using the ':' syntax.

Example:

Employee : Person

-------------------------------------

## Abstract Class

A class that cannot be instantiated directly.

It is designed to be inherited.

-------------------------------------

## Virtual Method

A method that can be overridden by derived classes.

-------------------------------------

## Override

Provides a new implementation of a virtual method inherited from a base class.

-------------------------------------

## Base

Calls the constructor or members of the parent class.

Example:

: base(name, age)

-------------------------------------

## Polymorphism

Allows objects derived from the same base class to be treated as the same type while behaving differently.

-------------------------------------

## Composition

Represents a 'has-a' relationship.

Example:

Car has an Engine.

Preferred over inheritance when the relationship is not naturally an 'is-a' relationship.



# Interfaces

An interface defines a contract.

Classes implementing an interface must provide implementations for all its members.

Example:

public interface ILogger
{
    void Log(string message);
}

-------------------------------------

A class can inherit only one class.

A class can implement many interfaces.

-------------------------------------

Interfaces promote:

- Loose coupling
- Testability
- Flexibility
- Dependency Injection

-------------------------------------

Think of interfaces as abilities.

Example:

IPayable

IPrintable

ILogger

IEmailSender


# SOLID Principles

Single Responsibility Principle (SRP)
A class should have one responsibility and one reason to change.

Open/Closed Principle (OCP)
Software should be open for extension but closed for modification.

Liskov Substitution Principle (LSP)
Derived classes should be replaceable wherever their base class is expected.

Interface Segregation Principle (ISP)
Prefer several small, focused interfaces over one large interface.

Dependency Inversion Principle (DIP)
Depend on abstractions (interfaces), not concrete implementations.


# Dependency Injection

Dependency Injection is a design pattern where a class receives the objects it depends on instead of creating them itself.

This reduces coupling, improves testability, and makes the code easier to maintain.


# Analogy for Interfaces, SOLID Principles, and Dependency Injection

Think of it like building a house:

1. **Interfaces** are the wall sockets. It defines 220V 3 pins. It doesn't generate electricity. It's just the contract.

2. **Dependency Injection** is like the electricity provider. It provides the electricity to the sockets. Your appliance simply plugs in. That's DI. The appliance didn't create electricity, it received it.

3. **SOLID Principles** are the building codes. They ensure that the house is built in a way that is safe, maintainable, and scalable. If you follow the building codes, your house will be more robust and easier to modify in the future.