// See https://aka.ms/new-console-template for more information

/* This console is for running and testing EmailHandler.dll
 * 
 */
using EmailHandler;
using System.Configuration;


//pull inputs from App.config
string host = ConfigurationManager.AppSettings.Get("host");
int port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("port"));
string userName = ConfigurationManager.AppSettings.Get("userName");
string userEmail = ConfigurationManager.AppSettings.Get("userEmail");
string userPass = ConfigurationManager.AppSettings.Get("userPass");


//this section is temporary until I can reliably send email and complete the other objectives in the project.
//pull inputs from console input

Console.Write("Destination Email: ");
string recipientEmail = Console.ReadLine();

string subject = "Test";
string messageBody = "This is a test message";



Console.WriteLine("Creating email object, and sending email.");


Email email = new Email();
//SendEmail() is asynchronous, but it's a 'fire and forget' method.
email.SendEmail(host, port, userName, userEmail, userPass, recipientEmail, subject, messageBody);


Console.ReadKey();




