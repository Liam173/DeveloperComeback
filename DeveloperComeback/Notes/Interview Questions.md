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
