//AND (&&) and OR (||) logical operators

using System.ComponentModel.Design;
using System.Transactions;

string username, password; // username: admin // password 12345678

Console.WriteLine("Enter username:");
username = Console.ReadLine();

Console.WriteLine("Enter the password:");
password = Console.ReadLine();


// OR             // != NOT
if (username != "admin" || password != "12345678")
{
    Console.WriteLine("Invalid user credentials");
}
else
{
    Console.WriteLine("Welcome");
}


// AND
//if (username == "admin" && password == "12345678") 
//{
//    Console.WriteLine("Welcome");
//}
//else
//{
//    Console.WriteLine("Invalid user credentials");
//}