using System;

/** Construct a program that allows the end-user to input the number of days the dog will stay and an add-on code. 
Include two overloaded methods named computeRate(). One version accepts an argument that includes the number of days 
and calculates the rate at $75.00 per day. The other accepts two arguments - the number of days and a code for add-on services. 
If the code is A, bathing and grooming will be included, and the price is $169.00 per day. If the code is C, 
only bathing is included, and the price is $112.00 per day. All other codes are invalid. 
Each method returns the rate to the calling program where it is displayed. 
The main program asks the user for the number of days in a stay and whether add-on services should be included;
then, based on the user’s response, the program either calls the first method or prompts for a add-on services code
and calls the second method. At the conclusion of the program, the program outputs the number of days, 
the add-on services code and the total cost of stay. **/

namespace assignment_two
{
    class Program
    {
        static double getDays (){
            double days;
            Console.WriteLine("how long will your dog be staying");
            days = Convert.ToDouble(Console.ReadLine());

            return days;
        }
        
        static void Main(string[] args)
        {
            double days;
            

            days = getDays();
            dog(days);
        }

        static double computeRate(double days){
           double cost = 75.00;
            return days * cost; 
        }

        static double computeRate(double days, string addon){
            if(addon == "A" || addon == "a"){
                double cost = 169.00;
                return days * cost;
            }else if(addon == "C" || addon == "c"){
                double cost = 122.00;
                return days * cost;
            }else{
                return computeRate(days,addon);
            }
        
        }
        static void dog(double days){
            string addon = "";
            double sum = 0;
            Console.WriteLine("if you want addon service type 1 if not type 2");
            int serviceOption = Convert.ToInt32(Console.ReadLine());
            if(serviceOption == 1){
                Console.WriteLine("if you want grooming and bathing type A or if you just want bathing type C");
                addon = Console.ReadLine();
                sum = computeRate(days,addon);
            }else if(serviceOption == 2){
                 sum = computeRate(days);
                 addon = "N";
            }else{
                Console.WriteLine("Please try again");
                dog(days);
            }

            Console.WriteLine($"your dog will be staying for {days} days. The service code enter was {addon}. your total is {sum}");
            
        }


    }
}
