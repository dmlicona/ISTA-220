##### __ISTA220__ 
##### __CSSBS_HW01__

## *Denis Licona*
###### *Date* 
---

1. *What is a local variable?*

The opening and closing braces that form the body of a method define the scope of the method. Any
variables you declare inside the body of a method are scoped to that method; they disappear when the
method ends and can be accessed only by code running in that method.

2. *What is a statement?*

A command that performs an action and ends with a semicolon, such as calculating a value and storing the result or displaying a message to a user.

3. *What is an identifier?*

The names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables.

4. *What is a variable?* 

It is a storage location that holds a value.

5. *What is a method?*

It is a block of combined statements.

6. *Are primitive types and value types the same thing? This is not in the book.*

No, theh are not the same thing. They are called primitive because they are the main built-in types, you don't have to create. Value type variables have to be created to assign a value directly. The value types directly contain data.

7. *How are arithmetic operators and variable types related?*

Arithmetic operators can be used for calculating variable data types. 

8. *How do you turn an integer into a string?*

By using ToString() method.

9. *How do you turn a string into an integer?*

The .NET Framework provides a method called Int32.Parse that you can use to convert a string value to an integer if you need to perform arithmetic computations on values held as strings.

10. *What is the difference between precedence and associativity? Give an example where this makes a difference.*

Precedence governs the order in which an expression’s operators are evaluated. Associativity is the direction (left or right) in which the operands of an operator are evaluated. The difference is that when two of the same additive operands or two of the same multiplicative operands are together, the precedence goes to the first operand on the left. 

Example: 4+1*4, * has precedence. If 4/2*8, / has precedence as it would be read from left to right. 
 
11. *What is the definite assignment rule?*

Must assign a value to a variable before you can use it, otherwise it won't compile. 

12. *How are the prefix and postfix increment and decrement operators evaluated differently?*

In the expression x++, the variable x occurs first, so its value is used as the value of the expression before x is incremented. In the expression ++x, the operator occurs first, so its operation is performed before the value of x is evaluated as the result.

13. *What is string interpolation?*

It is a method of concatenating, formatting and manipulating strings. A common use of string concatenation is to generate string values that include variable values. The $ symbol at the start of the string indicates that it is an interpolated string and that any expressions between the { and } characters should be evaluated and the result substituted
in their place.

14. *What does the var keyword do?*

It is used to declare implicit type variables in C#. Used when you do not know what kind of datatype can be formed from the data. 

Example, var i = 10, it is implied that i is an integer. var t = true, it implies that t is a Boolean. 