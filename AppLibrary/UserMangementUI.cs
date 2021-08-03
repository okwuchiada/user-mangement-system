using System;
namespace AppLibrary
{
    public class UserMangementUI
    {
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string email { get; set; }
        public static string favoriteFood { get; set; }

        public static void UserInterface()
        {
            System.Console.Clear();
         Console.ForegroundColor = ConsoleColor.Blue;
         QueueClass<string> users = new QueueClass<string>();
         Console.WriteLine("ADA'S USER MANAGEMENT APP");
        //  ============ DISPLAY INFORMATION  ======
         System.Console.WriteLine("Enter: ");
         System.Console.WriteLine("1 to Add User");
         System.Console.WriteLine("2 to Show User");
         System.Console.WriteLine("3 to Remove Last User");
         System.Console.WriteLine("4 Exit");
        
         System.Console.Write("\r\nSelect an option: ");

         string userInput = System.Console.ReadLine();
         switch (userInput)
         {
             case "1":
           
                 System.Console.Write("Please enter first name: ");
             firstName = Console.ReadLine();
             System.Console.Write("Please enter last name: ");
             lastName = Console.ReadLine();
            System.Console.Write("Please enter email: ");
             email = Console.ReadLine();
              System.Console.Write("Please enter favorite food: ");
             favoriteFood = Console.ReadLine();
             string[] userStr = {firstName, lastName, email, favoriteFood};
             string userInfo = $"{userStr[0]} || {userStr[1]} || {userStr[2]} || {userStr[3]}";
            users.Enqueue(userInfo);
             users.Print();

             break;

             case "2":
        //   File management system 
             users.Print();
             break;

             case "3":
             users.Dequeue();
             users.Print();
             break;

            case "4":
            Console.Clear();
            break;
             
             default:
             System.Console.WriteLine("Please select a number from 1-4");
             break;
         }



        }
    }
}