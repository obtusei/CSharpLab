namespace Program
{

          public class App
          {
                    public static void Main(string[] args)
                    {
                              LabOne obj = new LabOne();
                              Console.WriteLine("Name:Abhishek Bhatta and CRN:019-312\n");
                              Console.Write("Choose a number between 1 and 15:");
                              int number = Convert.ToInt32(Console.ReadLine());
                              Console.WriteLine("\n");
                              switch (number)
                              {
                                        case 1: obj.NumberOne(); break;
                                        case 2: obj.NumberTwo(); break;
                                        case 3: obj.NumberThree(); break;
                                        case 4: obj.NumberFour(); break;
                                        case 5: obj.NumberFive(); break;
                                        case 6: obj.NumberSix(); break;
                                        case 7: obj.NumberSeven(); break;
                                        case 8: obj.NumberEight(); break;
                                        case 9: obj.NumberNine(); break;
                                        case 10: obj.NumberTen(); break;
                                        case 11: obj.NumberEleven(); break;
                                        case 12: obj.NumberTwelve(); break;
                                        case 13: obj.NumberThirteen(); break;
                                        case 14: obj.NumberFourteen(); break;
                                        case 15: obj.NumberFifteen(); break;
                                        default: Console.WriteLine("Invalid Input"); break;
                              }

                              Console.WriteLine("\n\n");
                    }
          }


}