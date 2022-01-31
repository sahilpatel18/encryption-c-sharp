using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            string userTextMessage;
            string userEncryptedMessage;
            
            do{
                Encryption e1 = new Encryption();
                Console.WriteLine("1: Encrypt a message");
                Console.WriteLine("2: Decrypt a message");
                Console.WriteLine("3: Quit");
                Console.WriteLine("\nEnter Choice:"); 
                userChoice = Console.ReadLine();
                Console.WriteLine();

                if(int.Parse(userChoice) == 1){
                    Console.WriteLine("Enter the plain text message: ");
                    userTextMessage = Console.ReadLine();

                    Console.WriteLine("\nEncrypted Msg: " + e1.encrypt_message(userTextMessage));
                    Console.WriteLine();

                }
                if(int.Parse(userChoice) == 2){
                    Console.WriteLine("Enter the ecrypted message:");
                    userEncryptedMessage = Console.ReadLine();
                    Console.WriteLine("\nDecrypted Msg: " + e1.decrypt_message(userEncryptedMessage));
                    Console.WriteLine();
                }

            }while(int.Parse(userChoice) != 3);

            

                        
        }
    }
}
