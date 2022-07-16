// use of enumeration
namespace Program
{
          enum Days
          {
                    Monday,
                    Tuesday,
                    Wednesday,
                    Thursday,
                    Friday,
                    Saturday,
                    Sunday
          }
          class Q12
          {
                    public Q12()
                    {
                              Days d = Days.Monday;
                              Console.WriteLine("Monday is:" + d);
                    }
          }
}