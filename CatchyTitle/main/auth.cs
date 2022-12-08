using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
class AuthChecker {
  static void Main() {
    Console.WriteLine("Check auth 1.. 2... 3...");
    string userAccepted = "CatchyTitleDev, CatchyTitleOfficial"
    string oldUser = userAccepted;
    [Serialize Field] string newUser;
    newUser = "example123";
    string containedUser; //where you are supposed to add
    if(newUser == containedUser)
    {
    userAccepted = "CatchyTitleDev, CatchyTitleOfficial, " + containedUser;
      // Store the path of the textfile in your system
        string file = @"C:\Downloads\auth.txt";
  
        // To write all of the text to the file
        string text = "CatchyTitleDev, CatchyTitleOfficial";
        File.WriteAllText(file, text);
  
        // To display current contents of the file
        Console.WriteLine(File.ReadAllText(file));
        Console.WriteLine();
  
        // To write text to file line by line
        string[] textLines1 = { "CatchyTitleDev", 
                               "CatchyTitleOfficial", };
  
        File.WriteAllLines(file, textLines1);
  
        // To display current contents of the file
        Console.WriteLine(File.ReadAllText(file));
  
        // To write to a file using StreamWriter
        // Writes line by line
        string[] textLines2 = {userAccepted", " + newUser};
  
        using(StreamWriter writer = new StreamWriter(file))
        {
            foreach(string ln in textLines2)
            {
                writer.WriteLine(ln);
            }
        }
        // To display current contents of the file
        Console.WriteLine(File.ReadAllText(file));
  
        Console.ReadKey();
    //find location of files on main pc, change authorization to the added user, then give sign up
    
        /*string path = @"auth.txt";
 string path = Path.path();
        using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
        {
            Byte[] info = new UTF8Encoding(true).GetBytes(" " + containedUser);
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }
        // Open the stream and read it back.
        using (FileStream fs = File.Open(path, FileMode.Open))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b,0,b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }*/
    }
  }
}
