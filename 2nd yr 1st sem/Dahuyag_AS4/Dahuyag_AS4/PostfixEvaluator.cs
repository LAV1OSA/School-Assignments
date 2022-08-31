using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS3_A;
using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework;
using FluentAssertions;

namespace AS4_A
{
    public class PostfixEvaluator
    {
        public static double EvaluatePostfixExpression(string postfixExpression)
        {
            var stack = new StackList<double>();
            var numberString = new StringBuilder();
            foreach (var character in postfixExpression)
            {
                if (InfixToPostfixConverter.numbersAndDividingSymbols.Contains(character))
                    numberString.Append(character);
                else if (InfixToPostfixConverter.IsOperator(character))
                {
                    if (stack.Count < 2) throw new InvalidOperationException("Invalid Postfix Notation");
                    var x = stack.Pop();
                    var y = stack.Pop();
                    var result = Calculate(y, x, character);
                    stack.Push(result);
                }
                else
                {
                    if (numberString.Length == 0) continue;
                    stack.Push(double.Parse(numberString.ToString()));
                    numberString.Clear();
                }
            }
            return stack.Pop();
        }

        private static double Calculate(double y, double x, char operation)
        {
            switch (operation)
            {
                case '+':
                    return y + x;
                case '-':
                    return y - x;
                case '*':
                    return y * x;
                case '/':
                    return y / x;
                case '%':
                    return y % x;
                case '^':
                    return Math.Pow(y,x);
            }
            throw new InvalidOperationException("Operation not recognized");
        }
    }
}
