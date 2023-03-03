using System;

namespace Watson {
    class Program {
        static void Main(string[] args) {
            bool TF = false;

        Console.Write("Please Input your password: ");
        int password = int.Parse(Console.ReadLine());
        Console.Write("Please Input your agent:");
        string agent = Console.ReadLine();
        int password100k = password / 100000;
        int password10k = (password / 10000) % 10;
        int password1k = (password / 1000) % 10;
        int password100 = (password / 100) % 10;
        int password10 = (password / 10) % 10;
        int password1 = password % 10;
        
            if(agent == "CIA"){
                if(password1 % 3 == 0){
                    if(password10 != 1 && password10 != 3 && password10 != 5){
                        if(password1k >= 6 && password1k != 8){
                            Console.WriteLine("True");
                        }
                        else{
                            Console.WriteLine("False");
                        }
                    }
                    else{
                            Console.WriteLine("False");
                    }
                }
                else{
                            Console.WriteLine("False");
                }
            }
            else if(agent == "FBI"){
                if(password100k == 4 && password100k == 5 && password100k == 6 && password100k == 7){
                    if(password100 % 2 == 0 && password100 != 6){
                        if(password10k % 2 == 1){
                            Console.WriteLine("True");
                        }
                        else{
                            Console.WriteLine("False");
                        }
                    }
                    else{
                        Console.WriteLine("False");
                    }
                }
                else{
                Console.WriteLine("False");
            }
            }
            else if(agent == "NSA"){
                if(password1 == 1 || password1 == 2 || password1 == 3 || password1 == 5 || password1 == 6){
                    if(password100 % 3 == 0 && password100 % 2 != 0){
                        if(password1 == 7 || password10 == 7 || password100 == 7 || password1k == 7 || password10k == 7 || password100k == 7){
                            Console.WriteLine("True");
                        }
                }
                else{
                Console.WriteLine("False");
                }               
              }
              else{
              Console.WriteLine("False");
              }
            }
        }
    }
}