using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Conditionals
{
    internal class Ternary_Operator
    {

        // ?: represents Ternary Operator or Conditional operator.
        // condition ? statement 1 : statement 2.

        public static void Run()
        {
            int x = 10;
            int y = 20;

         //condition =          statement 1(if)        :      statement 2(else)     ; if condition is true then statement 1 will run else statement 2 will be executed.
          var result =  x > y ? " x is greater than y" : " y is greater than x";

            Console.WriteLine(result);



            int j = 30;
            int k = 40;

            var answer = j > k ? "j is greater than k": // It acts as a if statement.
                         j < k ? "k is greater than j": // this is an elseif statement.
                                 "both are equal";// else statement.

            Console.WriteLine(answer);

            // If you are entering 2 statements simultaneously in a same line than 1 line acts as an 'if' statment and another acts as 'else' statement.
            // Another statement will be returned as 'elseif' statement.


            //string result = x > y ? "x is greater than y" : "x is less than y" :         if and else
            //x == y ? "x is equal to y";                                                  elseif
            //The above lines will throw error because elseif statement is occuring after an else statement.
        }
    }
}
