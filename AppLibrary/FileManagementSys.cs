using System.IO;
namespace AppLibrary
{
    public class FileManagement
    {
                    public QueueClass<string> userQueue = new QueueClass<string>();
          public static void Filing()
        {
            

             string pathLink = @"../AppLibrary/UserStore.txt";
             if(!File.Exists(pathLink))
             {
               using StreamWriter newFile = File.CreateText(pathLink);
               
             }
             using(StreamWriter userStore = File.AppendText(pathLink))
             {
                  userStore.WriteLine("==============================================");
                 userStore.WriteLine("USER MANAGEMENT APPLICATION: ADANMA OKWUCHI");
                 userStore.WriteLine("==============================================");
                 userStore.WriteLine();
             }
             using(StreamReader userStore = File.OpenText(pathLink))
             {
                 userStore.ReadToEnd();
             }


           
           
          
        }
        
    }
}