//// use of structure by defining point as structure and implementing the structure calculate distance between two points

namespace Program
{
          struct Point
          {
                    public int x;
                    public int y;
                    public Point(int x, int y)
                    {
                              this.x = x;
                              this.y = y;
                    }
                    public double Distance(Point p)
                    {
                              return Math.Sqrt(Math.Pow(p.x - this.x, 2) + Math.Pow(p.y - this.y, 2));
                    }
          }


          class Q6
          {
                    public Q6()
                    {
                              Point p1 = new Point(0, 0);
                              Point p2 = new Point(3, 4);
                              Console.WriteLine("Distance between {0} and {1} is {2}", p1, p2, p1.Distance(p2));
                    }
          }
}