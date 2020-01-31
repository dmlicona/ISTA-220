##### __ISTA220__ 
##### _C#_HW03__

## *Denis Licona*
###### *22 Jan 2020* 
---
1. What is a method?
* A method is a named sequence of statements. A code block that contains a series of statements. It is a named block of code that accepts outside values and returns values to the outside. 

2. (Not in book) What is the difference between a function and a procedure/subprocedure/subroutine?
* Function has to return one and only one value (another can be returned by OUT variable); it transforms input into output. Procedure returns as many data sets and return values. A function does not have side effects. Subprocedures work by side effects. 

3. What does a return statement do?
* The returnType is the name of a type and specifies the kind of information the method returns as a result of its processing. Terminates the execution of a method. Terminates a block of code. 

4. What is an expression bodied method?
* An expression-bodied method consists of a single expression that returns a value whose type matches the method's return type, or, for methods that return void, that performs some operation.

5. What is the scope of a variable?
* The scope of a variable is simply the region of the program in which that variable is usable.

6. What is an overloaded method?
* Method overloading allows a class to have multiple methods with the same name. In other words, when the different implementations of an operation have different sets of parameters; that is, when they have the same name but a different number of parameters or when the types of the parameters differ.

7. How do you call a method that requirements arguments?
* You supply a comma-separated list of arguments, and the number and type of the arguments are used by the compiler to select one of the overloaded methods. You use a parenthesis. 

8. How do you write a method, that is, specify the method definition, that requires a parameter list?
* Write the method within a class. Specify the method name, parameter list, and return type, followed by the body of the method between braces. Console.WriteLine("Using parameter list");

9. How do you specify a parameter as optional when defining a method?
* You specify that a parameter is optional when you define a method by providing a default value for the parameter. You indicate a default value by using the assignment operator.
* In the optMethod method shown next, the first parameter is mandatory because it does not specify a default value, but the second and third parameters are optional: void optMethod(int first, double second = 0.0, string third = "Hello") {
...
}

10. How do you pass an argument to a method as a named parameter?
* You specify the name of the parameter, followed by a colon and the value to use.

11. How do you return values from a method? Can you return multiple values from a method, and if so,
how?
* Write a _return_ statement within the method to return a value. You can return multiple values by writing a _return_ statement that returns a tuple, which is a small collection of values (strictly speaking, a tuple contains two values, but C# tuples can comprise bigger sets than this).

12. How does the compiler resolve an ambiguity between named arguments and optional parameters?
* The compiler can distinguish between the methods because they have different parameter lists.
