using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
class NetID{
    DateTime enterTime { get; set; }
    static void Main(){
	Console.WriteLine("|-------------------------------------------------|");
	Console.WriteLine("|                                                 |");
	Console.WriteLine("|   WELCOME TO THE ACTIVITY CENTER AT UT DALLAS   |");
	Console.WriteLine("|                                                 |");
	Console.WriteLine("|-------------------------------------------------|");
        NetID netid = new NetID();
	string readyEnter, readyExit;
	Console.WriteLine("Are you ready to enter the activity center? You must type 'yes' in all lowercase in order to enter, or otherwise you cannot enter.");
	readyEnter = Console.ReadLine();
	if(readyEnter == "yes"){
	    netid.recordEnter();
	}
	else{
	    Console.WriteLine("We apologized if you cannot enter the activity center, but you can only enter when you are ready.");
	}
	Console.WriteLine("Are you ready to exit the activity center? You must enter 'yes' in all lowercase in order to to exit, or otherwise you cannot exit.");
	readyExit = Console.ReadLine();
	if(readyExit == "yes"){
	    netid.recordExit();
	}
	else{
	    Console.WriteLine("We apologized if you stucked at the activity center, but you can only exit when you are ready.");
	}
   } 
    void recordEnter(){
        do {
            string netID;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|*-------------------------------------------------------*|");
            Console.WriteLine("||                                                       ||");
            Console.WriteLine("||    TIME RECORDING FOR ENTERING THE ACTIVITY CENTER    ||");
            Console.WriteLine("||                                                       ||");
            Console.WriteLine("|*-------------------------------------------------------*|");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter your NET-ID here:");
            netID = Console.ReadLine();
            try{
                if(Regex.IsMatch(netID.Substring(0,3), @"^[a-zA-Z]+$") && Regex.IsMatch(netID.Substring(3,6), @"^[0-9]+$")) {
		    DateTime enterTime;
		    enterTime = DateTime.Now.ToLocalTime();
                    Console.WriteLine("The time you entered the activity center is " + enterTime);
		    Console.WriteLine("Thank you for entering your NET-ID for recording purpose.");
		    Console.WriteLine("");
		    Console.WriteLine("");
		    break;
                }
                else if(!(Regex.IsMatch(netID.Substring(0,3), @"^[a-zA-Z]+$")) && !(Regex.IsMatch(netID.Substring(3,6), @"^[0-9]+$"))) {
                    Console.WriteLine("The entered NET-ID does not exactly contain three letters and six numbers.");
                    Console.WriteLine("Please try again.");
		    Console.WriteLine("");
                    continue;
                }
                else if(!(Regex.IsMatch(netID.Substring(0,9), @"^[-@#!$%&*()_+|~=`{}\:;'<>?,.\/]+$"))){
                    Console.WriteLine("The entered NET-ID does not contain any symbols.");
                    Console.WriteLine("Please try again.");
		    Console.WriteLine("");
                    continue;
                }
                else {
                    Console.WriteLine("This is not a valid NET-ID.");
                    Console.WriteLine("Please try again.");
		    Console.WriteLine("");
                    continue;
                }
            }
            catch(Exception){
                Console.WriteLine("This is not a valid NET-ID.");
		Console.WriteLine("Please enter again and check if your NET-ID is right.");
		Console.WriteLine("");
            }
        }while(true);
    }
    void recordExit(){
        do {
            string netID;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|*-------------------------------------------------------*|");
            Console.WriteLine("||                                                       ||");
            Console.WriteLine("||     TIME RECORDING FOR EXITING THE ACTIVITY CENTER    ||");
            Console.WriteLine("||                                                       ||");
            Console.WriteLine("|*-------------------------------------------------------*|");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter your NET-ID here:");
            netID = Console.ReadLine();
            try{
                if(Regex.IsMatch(netID.Substring(0,3), @"^[a-zA-Z]+$") && Regex.IsMatch(netID.Substring(3,6), @"^[0-9]+$")) {
		    DateTime exitTime;
		    exitTime = DateTime.Now.ToLocalTime();
                    Console.WriteLine("The time you exited the activity center is " + exitTime);
                    Console.WriteLine("The time spent at the activity center is the time between entering and exiting the activity center.");
		    Console.WriteLine("Thank you for coming to the Activity Center.");
		    Console.WriteLine("");
		    Console.WriteLine("");
                    break;
                }
                else if(!(Regex.IsMatch(netID.Substring(0,3), @"^[a-zA-Z]+$")) && !(Regex.IsMatch(netID.Substring(3,6), @"^[0-9]+$"))){
                    Console.WriteLine("The entered NET-ID does not exactly contain three letters and six numbers.");
                    Console.WriteLine("Please try again.");
		    Console.WriteLine("");
                    continue;
                }
                else if(!(Regex.IsMatch(netID.Substring(0,9), @"^[-@#!$%&*()_+|~=`{}\:;'<>?,.\/]+$"))){
                    Console.WriteLine("The entered NET-ID does not contain any symbols.");
                    Console.WriteLine("Please try again.");
		    Console.WriteLine("");
                    continue;
                }
                else {
                    Console.WriteLine("This is not a valid NET-ID.");
                    Console.WriteLine("Please try again.");
                    Console.WriteLine("");
		    continue;
                }
            }
            catch(Exception){
		Console.WriteLine("This is not a valid NET-ID");
                Console.WriteLine("Please enter again and check if your NET-ID is right.");
        	Console.WriteLine(""); 
	   }
        }while(true);
    }
}


