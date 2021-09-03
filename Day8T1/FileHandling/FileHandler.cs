using System;
using System.IO;
namespace Day8T1.FileHandling
{
    public class FileHandler
    {
        public void writeToFile(string Name)
        {
            FileStream f = new FileStream("Training.txt", FileMode.Create);  
            StreamWriter s = new StreamWriter(f); 
            s.WriteLine(Name);
            s.Close();
          
            f.Close(); 
            Console.WriteLine("File write done successfully");
            
        }
        public void readFromFile() 
        { 

            FileStream f = new FileStream("Training.txt", FileMode.Open); 
            StreamReader streamReader = new StreamReader(f);
            string Date= streamReader.ReadLine();
            System.Console.WriteLine(Date);
            streamReader.Close();
            f.Close();
            System.Console.WriteLine("File Read Successfully");
            
        }
    }
}