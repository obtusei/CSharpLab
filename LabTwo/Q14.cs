// file stream and character-based file i/o

namespace Program
{
          class Q14
          {
                    public Q14()
                    {
                              string fileName = "test.txt";
                              FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                              StreamWriter sw = new StreamWriter(fs);
                              sw.WriteLine("Hello World");
                              sw.Close();
                              fs.Close();
                              StreamReader sr = new StreamReader(fileName);
                              string line = sr.ReadLine() ?? throw new Exception("File is empty");
                              Console.WriteLine(line);
                              sr.Close();
                    }
          }
}

