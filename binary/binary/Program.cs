using System;
using System.IO;
namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"h:\sample.bin",FileMode.Create);
            Int16 i16 = 500;
            byte b = 65;
            Boolean l = true;
            string s = "petike";
            int i32 = 82563;
            double d = 3.14;
                               
            BinaryWriter writer = new BinaryWriter(fs);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                writer.Write((byte)rnd.Next(100));
            }
            
            //writer.Write(b);
            //writer.Write(i16);
            //writer.Write(l);
            //writer.Write(s);
            //fs.Seek(4, SeekOrigin.Begin);
            //writer.Write((byte)5);

            BinaryReader reader = new BinaryReader(fs);

            while (fs.Position != fs.Length)
            {
                Console.Write(reader.ReadByte() + "*");
            }

            fs.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(reader.ReadByte() + "|");

            }
            
            //Console.WriteLine($"{fs.Position} : {reader.ReadByte()}");
            //Console.WriteLine($"{fs.Position} : {reader.ReadInt16()}");
            //Console.WriteLine($"{fs.Position} : {reader.ReadBoolean()}");
            //Console.WriteLine($"{fs.Position} : {reader.ReadString()}");
            //Console.WriteLine($"{fs.Position} : ");

            fs.Close();
            
            


            Console.ReadKey();
        }
    }
}
