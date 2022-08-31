using System.Globalization;
using System.Text;
using AS3_A;
using Dahuyag_Assessment_1;
using NUnit.Framework;

namespace AS4_A
{
    public class InfixToPostfixConverter
    {
        public static Dictionary<string, int> operatorsOrderedByPrecedence = new Dictionary<string, int>()
        {
            {"+", 1},
            {"-", 1},
            {"sin", 2},
            {"cos", 2},
            {"tan", 2},
            {"csc", 2},
            {"sec", 2},
            {"cot", 2},
            {"*", 3},
            {"/", 3},
            {"%", 4},
            {"^", 4}
        };
        public static string numbersAndDividingSymbols = "0123456789.,";
        public static Dictionary<char, char> delimiters = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'[',']'},
            {'{','}'}
        };
        public static string ConvertToPostFix(string infixNotation)
        {
            var stack = new StackList<char>();
            var sb = new StringBuilder();
            var numberString = new StringBuilder();
            var recentlyClosedDelimiter = false;
            for (var index = 0; index < infixNotation.Length; index++)
            {
                var character = infixNotation[index];
                //Multi-digit logic
                if (numbersAndDividingSymbols.Contains(character)) numberString.Append($"{character}");
                else
                {
                    if (numberString.Length == 0) { }
                    else
                    {
                        sb.Append($"{numberString} ");
                        numberString.Clear();
                    }
                }
                //Checks for opening delimiter
                if (delimiters.ContainsKey(character)) stack.Push(character);
                //Does operation logic
                if (IsOperator(character)) DoOperation(stack, character, sb);
                //Checks for closing delimiter
                if (delimiters.ContainsValue(character))
                {
                    char delimiter;
                    while (!delimiters.TryGetValue(stack.Peek(), out delimiter))
                    {
                        sb.Append($"{stack.Pop()} ");
                        if (stack.Count == 0) break;
                    }

                    if (delimiter == character)
                    {
                        stack.Pop();
                        recentlyClosedDelimiter = true;
                    }
                    else
                        throw new InvalidOperationException("Delimiters do not match");
                }

                //Application of implied multiplication
                if (recentlyClosedDelimiter 
                    && index != infixNotation.Length - 1
                    && infixNotation[index + 1] != ' ')
                {
                    var impliedOperator = '*';
                    if (!IsOperator(infixNotation[index + 1]))
                        DoOperation(stack, impliedOperator, sb);

                    recentlyClosedDelimiter = false;
                }
            }
            //add the remaining number in (if any)
            sb.Append($"{numberString} ");
            foreach (var remaining in stack)
            {
                if (delimiters.ContainsKey(remaining)) throw new InvalidOperationException("Delimeters do not match");
                sb.Append($"{remaining} " );
            }
            return sb.ToString();
        }

        private static void DoOperation(StackList<char> stack, char character, StringBuilder sb)
        {
            if (stack.Count == 0) stack.Push(character);
            else
            {
                while (!Precedence(stack.Peek(), character)
                       && !(delimiters.ContainsKey(stack.Peek()) || delimiters.ContainsValue(stack.Peek())))
                {
                    sb.Append($"{stack.Pop()} ");
                    if (stack.Count == 0) break;
                }

                stack.Push(character);
            }
        }

        public static bool IsOperator(char c)
        {
            return operatorsOrderedByPrecedence.ContainsKey(c.ToString());
        }

        public static bool Precedence(char operator1, char operator2)
        {
            operatorsOrderedByPrecedence.TryGetValue(operator1.ToString(), out var operator1Precedence);
            operatorsOrderedByPrecedence.TryGetValue(operator2.ToString(), out var operator2Precedence);
            return operator1Precedence < operator2Precedence;
        }
    }

    public class Tests
    {
        [Test]
        public void METHOD()
        {
            var postfixExpression = InfixToPostfixConverter.ConvertToPostFix("(6.00) (2+2) + {3 +1- 2 +2 -1- (2 + 3)4 * 8} / 7 + 1");
            Console.WriteLine(postfixExpression);

            var result = PostfixEvaluator.EvaluatePostfixExpression(postfixExpression);
            Console.WriteLine(result);
        }
    }
}