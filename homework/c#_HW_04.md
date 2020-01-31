##### __ISTA220__ 
##### _C#_HW04__

## *Denis Licona*
###### *24 Jan 2020* 
---
1. What are all possible values of a Boolean expression?
* True or False

2. List eight Boolean operators.
* ! (not), == (equality), != (inequality), < (less than), <= (less than or equal to), > (greater than), >= (greater than or equal to), && (AND), || (or)

3. What is the general concept of short circuiting? This question has a short and simple answer and you do not need to have a detailed response.
* Stops evaluating a condition as soon as it can deduce the final outcome.

4. What are the difference in how short circuiting works for && and ||?
* For &&, if the left operand evaluates false, then the result of the entire expression is false. For ||, if the left operand evaluates true, then the result of the entire expression is true. 

5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?
* The () has the highest precedence. The = has the lowest precedence. 

6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
* It creates a block which groups a sequence of statements when a boolean expression is true.

7. In a switch statement, what happens if you omit break?
* The compiler will generate an error. The control cannot fall through from one case label to another. 

8. (Not in book) What is a recursive method? Using a language you know (such as English), write a recursive method that adds up the integers in a list of integers. The input to the method is a list of integers and the output is a scalar value representing a sum.
* A recursive method is a method that calls itself. It creates "clones" of itself and the clone has a smaller problem to work. For example, factorial 5! = 5 * 4 * 3 * 2 * 1; also 5! = 5 * 4!. Requirements: it must have the recursive call, have a terminating condition, and must make progress towards terminating. 
* n! = n * (n-1)!

9. (Not in book) Read a short summary of De Morgan’s laws.
(a) Explain how this statement, ”It’s not snowing or raining,” is the same as this statement, ”It’s not snowing and it’s not raining.”
(b) Explain how this statement, ”I’m not running and walking,” is the same as this statement, ”I’m not running or I’m not walking.”
* (a) negate (P and Q), using distributive property, then it is the same as not P or not Q. Thus, not (snowing or raining) = not snowing and not raining.
* (b) not (running and walking) = not running or not walking