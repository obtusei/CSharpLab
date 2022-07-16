// palidrome
namespace Program
{
          class Q5
          {

                    void palindrome(string str)
                    {
                              string rev = "";
                              for (int i = str.Length - 1; i >= 0; i--)
                              {
                                        rev = rev + str[i];
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

                    //counting tokens in a string
                    void count(string str)
                    {
                              int count = 0;
                              for (int i = 0; i < str.Length; i++)
                              {
                                        if (str[i] == ' ')
                                        {
                                                  count++;
                                        }
                              }
                              Console.WriteLine("The number of tokens in the string is:" + count);
                    }
                    public Q5()
                    {
                              Console.WriteLine("Enter a string:");
                              string str = Console.ReadLine() ?? throw new Exception("Love is in the air");
                              palindrome(str);
                              count(str);

                    }
          }
}

