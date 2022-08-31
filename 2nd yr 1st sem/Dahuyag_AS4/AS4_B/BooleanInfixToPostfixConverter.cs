using System.Text;
using AS3_A;
using AS4_A;
using AS4_B;
using NUnit.Framework;

namespace AS4_B
{
    public class BooleanInfixToPostfixConverter:InfixToPostfixConverter
    {
        public static Dictionary<string, int> BooleanOperators = new Dictionary<string, int>()
        {
            {"&&", 1},
            {"||", 1},
            {"==", 2},
            {"!=", 2},
            {"<=", 3},
            {"<", 3},
            {">", 3},
            {">=", 3},
            {"!", 5},
        };

        public static string ConvertBooleanToPostfix(string infixNotation)
        {
            var stack = new StackList<string>();
            var sb = new StringBuilder();
            var numberString = new StringBuilder();
            var operatorString = new StringBuilder();
            var recentlyClosedDelimiter = false;
            var isInUnaryOperation = false;
            for (var index = 0; index < infixNotation.Length; index++)
            {
                var character = infixNotation[index];
                //Multi-digit logic
                if (NumbersAndDividingSymbols.Contains(character)) numberString.Append($"{character}");
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
                if (Delimiters.ContainsKey(character)) stack.Push(character.ToString());
                //Checks for closing delimiter
                else if (Delimiters.ContainsValue(character))
                {
                    char delimiter;
                    while (!Delimiters.TryGetValue(stack.Peek()[0], out delimiter))
                    {
                        sb.Append($"{stack.Pop()} ");
                        if (stack.Count == 0) break;
                    }

                    if (delimiter == character)
                    {
                        stack.Pop();
                        recentlyClosedDelimiter = true;
                        //if is in a parenthesis after a unary expression, add unary operation to the string
                        if (isInUnaryOperation)
                        {
                            sb.Append($"{stack.Pop()} ");
                            isInUnaryOperation = false;
                        }
                    }
                    else
                        throw new InvalidOperationException("Delimiters do not match");
                }
                //Does operation logic
                else if (!NumbersAndDividingSymbols.Contains(character) && character != ' ')
                {
                    operatorString.Append(character);

                    if((operatorString.ToString() == ">" 
                        || operatorString.ToString() == "<")
                       && infixNotation[index + 1] == '=')
                        continue;
                    if (IsBooleanOperator(operatorString.ToString()))
                    {
                        //check if unary operation
                        BooleanOperators.TryGetValue(operatorString.ToString(), out int value);
                        if (value == 5)
                        {
                            isInUnaryOperation = true;
                            stack.Push(operatorString.ToString());
                        }
                        else
                            DoOperation(stack, operatorString.ToString(), sb);
                        operatorString.Clear();
                    }
                }
            }
            //add the remaining number in (if any)
            sb.Append($"{numberString} ");
            foreach (var remaining in stack)
            {
                if (Delimiters.ContainsKey(remaining[0])) throw new InvalidOperationException("Delimiters do not match");
                sb.Append($"{remaining} ");
            }
            return sb.ToString();
        }
        private static void DoOperation(IStack<string> stack, string characterString, StringBuilder sb)
        {
            if (stack.Count == 0) stack.Push(characterString);
            else
            {
                while (!BooleanPrecedence(stack.Peek(), characterString)
                       && !(Delimiters.ContainsKey(stack.Peek()[0]) || Delimiters.ContainsValue(stack.Peek()[0])))
                {
                    sb.Append($"{stack.Pop()} ");
                    if (stack.Count == 0) break;
                }

                stack.Push(characterString);
            }
        }

        public static bool IsBooleanOperator(string s)
        {
            return BooleanOperators.ContainsKey(s);
        }

        public static bool BooleanPrecedence(string operator1, string operator2)
        {
            BooleanOperators.TryGetValue(operator1, out var operator1Precedence);
            BooleanOperators.TryGetValue(operator2, out var operator2Precedence);
            return operator1Precedence < operator2Precedence;
        }
    }
}
public class Tests
{
    [Test]
    public void METHOD()
    {
        var postfixExpression1 = BooleanInfixToPostfixConverter.ConvertBooleanToPostfix("(2==2) || !(4 > 2) && (1 >= 0) || (3.01 > 40.22)");
        Console.WriteLine(postfixExpression1);
        /*
        var result1 = PostfixEvaluator.EvaluatePostfixExpression(postfixExpression1);
        Console.WriteLine(result1);


        var postfixExpression = InfixToPostfixConverter.ConvertToPostfix("((6.00) (2+2)) + {3 +1- 2 +2 -1- (2 + 3)4 * 8} / 7 + (2)cos(sin(30 - 10 * 2) * 20 + 1)");
        Console.WriteLine(postfixExpression);
        var result = PostfixEvaluator.EvaluatePostfixExpression(postfixExpression);
        Console.WriteLine(result);
    */
    }
}
