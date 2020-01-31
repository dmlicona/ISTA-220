##### __ISTA220__ 
##### _C#_HW05__

## *Denis Licona*
###### *29 Jan 2020* 
---
1. What is a *compound assignment operator*? How does it work?
* It is a notation that combines any arithmetic operator with the assignment operator as a shorthand.

2. List all the compound assignment operators.
* variable *= number;
* variable /= number;
* variable %= number;
* variable += number;
* variable -= number;

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.
* answer = variable + 50;
* variable += 50;
* variable -= 50;
* answer = variable - 50;

4. How long does a *while* loop run?
* It runs a statement repeatedly while a condition is true. It stops once a boolean expression is evaluated to false. 

5. What is an *iteration variable?* (Not in book)
* It is the update control variable, how often/much something is to execute. 

6. What happens if you don’t change the loop variable in the body of the while loop block?
* It will continue to loop forever prompting an error. 

7. How many parts does a *for* loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?
* *for* has three parts, (initialization; Boolean expression; update control variable) statement
* Yes you can omit any of the three parts.

8. How do you guarantee that a loop runs at least once?
* By using a *do* statement 

9. What does the *break* statement do?
* Used to jump out of the body of an iteration statement loop and immediately continues executing the first statement that follows the loop. 

10. What does the *continue* statement do?
* It causes the program to perform the next iteration of the loop immediately (after reevaluating the Boolean expression).

11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An “infinite loop” is a loop without an update variable that in effect runs forever. As you will see, these kinds of loops are written intentionally to perform various kinds of tasks.
*  To restrict a condition in order to always keep the condition true. 