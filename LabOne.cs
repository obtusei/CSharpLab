namespace Program
{

          public class LabOne
          {

                    // Print your name, Roll Number, address on the screen
                    public void NumberOne()
                    {
                              Console.Write("Enter the name: ");
                              string name = Console.ReadLine() ?? throw new Exception("Name is required");
                              Console.Write("Enter the roll no: ");
                              int roll = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the address: ");
                              string address = Console.ReadLine() ?? throw new Exception("Address is required");
                              Console.WriteLine("---------------------------------");
                              Console.WriteLine("Name: {0} \nRoll no: {1} \nAddress: {2}", name, roll, address);

                    }

                    // Display sum of two numbers
                    public void NumberTwo()
                    {
                              Console.WriteLine("---------SUM CALCULATION---------");
                              Console.Write("Enter the first digit: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the second digit: ");
                              int b = Convert.ToInt32(Console.ReadLine());
                              int c = a + b;
                              Console.WriteLine("Sum of {0} + {1} is: {2}", a, b, c);
                    }

                    //  Input two numbers and find sum, difference, product, quotient and remainder
                    public void NumberThree()
                    {
                              Console.WriteLine("---------SUM/DIFFERENCE/PRODUCT/QUOTIENT CALCULATION---------");
                              Console.Write("Enter the first digit: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the second digit: ");
                              int b = Convert.ToInt32(Console.ReadLine());
                              int sum = a + b;
                              int diff = a - b;
                              int product = a * b;
                              int quot = a / b;
                              Console.WriteLine("Sum of {0} & {1} is: {2}", a, b, sum);
                              Console.WriteLine("Difference of {0} & {1} is: {2}", a, b, diff);
                              Console.WriteLine("Product of {0} & {1} is: {2}", a, b, product);
                              Console.WriteLine("Quotient of {0} & {1} is: {2}", a, b, quot);
                    }

                    //Compute Simple interest
                    public void NumberFour()
                    {
                              Console.Write("Enter the principal: ");
                              int principal = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the rate: ");
                              double rate = Convert.ToDouble(Console.ReadLine());
                              Console.Write("Enter the time: ");
                              double time = Convert.ToDouble(Console.ReadLine());
                              double interest = principal * rate * time / 100;
                              Console.WriteLine("The interest is : {0}", interest);
                    }

                    // Compute area of circle
                    public void NumberFive()
                    {
                              Console.Write("Enter the radius of circle: ");
                              int radius = Convert.ToInt32(Console.ReadLine());
                              double area = 2 * 3.14 * radius;
                              Console.WriteLine("Area of given circle with radisu {0} is {1}", radius, area);
                    }

                    // Input three numbers and print max and min
                    public void NumberSix()
                    {
                              Console.Write("Enter the first digit: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the second digit: ");
                              int b = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the third digit: ");
                              int c = Convert.ToInt32(Console.ReadLine());
                              //print max and min
                              int max = a;
                              int min = a;
                              if (b > max)
                              {
                                        max = b;
                              }
                              if (c > max)
                              {
                                        max = c;
                              }
                              if (b < min)
                              {
                                        min = b;
                              }
                              if (c < min)
                              {
                                        min = c;
                              }
                              Console.WriteLine("Max is: {0}", max);
                              Console.WriteLine("Min is: {0}", min);

                    }

                    // Check if it's a Armstrong number or not
                    public void NumberSeven()
                    {
                              Console.Write("Enter the three digit number: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              // check if it's a Armstrong number or not
                              int temp = a;
                              int sum = 0;
                              while (temp > 0)
                              {
                                        int r = temp % 10;
                                        sum = sum + (r * r * r);
                                        temp = temp / 10;
                              }
                              if (sum == a)
                              {
                                        Console.WriteLine("{0} is an Armstrong number", a);
                              }
                              else
                              {
                                        Console.WriteLine("{0} is not an Armstrong number", a);
                              }
                    }

                    // To print prime numbers between 50 to 100
                    public void NumberEight()
                    {
                              Console.WriteLine("---------PRIME NUMBERS BETWEEN 50 TO 100---------");
                              for (int i = 50; i <= 100; i++)
                              {
                                        int count = 0;
                                        for (int j = 1; j <= i; j++)
                                        {
                                                  if (i % j == 0)
                                                            count++;
                                        }
                                        if (count == 2)
                                                  Console.WriteLine(i);
                              }
                    }

                    //TO input three side of a triangle and display its type
                    public void NumberNine()
                    {
                              Console.Write("Enter the first side: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the second side: ");
                              int b = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the third side: ");
                              int c = Convert.ToInt32(Console.ReadLine());
                              if (a + b > c && a + c > b && b + c > a)
                              {
                                        if (a == b && b == c)
                                                  Console.WriteLine("Equilateral triangle");
                                        else if (a == b || b == c || a == c)
                                                  Console.WriteLine("Isosceles triangle");
                                        else
                                                  Console.WriteLine("Scalene triangle");
                              }
                              else
                              {
                                        Console.WriteLine("Not a triangle");
                              }
                    }

                    //To print multiplication table of a given number
                    public void NumberTen()
                    {
                              Console.Write("Enter the number: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              for (int i = 1; i <= 10; i++)
                              {
                                        Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
                              }
                    }

                    // Console Calculator
                    public void NumberEleven()
                    {
                              Console.WriteLine("---------CONSOLE CALCULATOR---------");
                              Console.Write("Enter the first digit: ");
                              int a = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the second digit: ");
                              int b = Convert.ToInt32(Console.ReadLine());
                              Console.Write("Enter the operator: ");
                              string op = Console.ReadLine() ?? throw new Exception("Operator is required");
                              if (op == "+")
                              {
                                        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                              }
                              else if (op == "-")
                              {
                                        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                              }
                              else if (op == "*")
                              {
                                        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                              }
                              else if (op == "/")
                              {
                                        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                              }
                              else
                              {
                                        Console.WriteLine("Invalid operator");
                              }

                    }

                    // Convert expression in infix to postfix
                    public void NumberTwelve()
                    {
                              Console.WriteLine("---------INFIX TO POSTFIX---------");
                              Console.Write("Enter the infix expression: ");
                              string infix = Console.ReadLine() ?? throw new Exception("Infix expression is required");
                              string postfix = "";
                              Stack<char> stack = new Stack<char>();
                              for (int i = 0; i < infix.Length; i++)
                              {
                                        if (infix[i] == '(')
                                                  stack.Push('(');
                                        else if (infix[i] == ')')
                                        {
                                                  while (stack.Count > 0 && stack.Peek() != '(')
                                                            postfix += stack.Pop();
                                                  stack.Pop();
                                        }
                                        else if (infix[i] == '+' || infix[i] == '-' || infix[i] == '*' || infix[i] == '/')
                                        {
                                                  while (stack.Count > 0 && stack.Peek() != '(' && precedence(infix[i]) <= precedence(stack.Peek()))
                                                            postfix += stack.Pop();
                                                  stack.Push(infix[i]);
                                        }
                                        else
                                        {
                                                  postfix += infix[i];
                                        }
                              }
                              while (stack.Count > 0)
                                        postfix += stack.Pop();
                              Console.WriteLine("Postfix expression is: {0}", postfix);
                    }
                    public int precedence(char op)
                    {
                              if (op == '+' || op == '-')
                                        return 1;
                              else
                                        return 2;
                    }



                    //To evaluate expression in reverse polish nototation
                    public void NumberThirteen()
                    {
                              Console.WriteLine("---------EVALUATE EXPRESSION---------");
                              Console.Write("Enter the expression: ");
                              string input = Console.ReadLine() ?? throw new Exception("Expression is required");
                              string[] tokens = input.Split(' ');
                              Stack<string> stack = new Stack<string>();
                              foreach (string token in tokens)
                              {
                                        switch (token)
                                        {
                                                  case "+":
                                                            int a = Convert.ToInt32(stack.Pop());
                                                            int b = Convert.ToInt32(stack.Pop());
                                                            int c = a + b;
                                                            stack.Push(c.ToString());
                                                            break;
                                                  case "-":
                                                            int d = Convert.ToInt32(stack.Pop());
                                                            int e = Convert.ToInt32(stack.Pop());
                                                            int f = e - d;
                                                            stack.Push(f.ToString());
                                                            break;
                                                  case "*":
                                                            int g = Convert.ToInt32(stack.Pop());
                                                            int h = Convert.ToInt32(stack.Pop());
                                                            int i = g * h;
                                                            stack.Push(i.ToString());
                                                            break;
                                                  case "/":
                                                            int j = Convert.ToInt32(stack.Pop());
                                                            int k = Convert.ToInt32(stack.Pop());
                                                            int l = k / j;
                                                            stack.Push(l.ToString());
                                                            break;
                                                  default:
                                                            stack.Push(token);
                                                            break;
                                        }
                              }

                              Console.WriteLine("Result: {0}", stack.Peek());
                    }

                    //to verify if a string is a palindrome or not
                    public void NumberFourteen()
                    {
                              Console.Write("Enter the string: ");
                              string str = Console.ReadLine() ?? throw new Exception("String is required");
                              string rev = "";
                              for (int i = str.Length - 1; i >= 0; i--)
                              {
                                        rev += str[i];
                              }
                              if (str == rev)
                              {
                                        Console.WriteLine("The string is a palindrome");
                              }
                              else
                              {
                                        Console.WriteLine("The string is not a palindrome");
                              }
                    }

                    // to display abbreviation of a name i.e if you input a name "Amit Kumar Sharma" system will display "A. K. Sharma"
                    public void NumberFifteen()
                    {
                              Console.Write("Enter the name: ");
                              string name = Console.ReadLine() ?? throw new Exception("Name is required");
                              string[] tokens = name.Split(' ');
                              string abbreviation = "";
                              foreach (string token in tokens)
                              {

                                        if (token != tokens[tokens.Length - 1])
                                        {
                                                  abbreviation += token[0];
                                                  abbreviation += ". ";

                                        }
                                        else
                                        {
                                                  abbreviation += token;
                                        }
                              }
                              Console.WriteLine(abbreviation);
                    }
          }

}