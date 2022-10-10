// See https://aka.ms/new-console-template for more information

/* This console is for running and testing EmailHandler.dll
 * 
 */
using EmailHandler;
using System.Configuration;

//pull Email properties from App.config
string host = ConfigurationManager.AppSettings.Get("host");
int port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("port"));
string userName = ConfigurationManager.AppSettings.Get("userName");
string userEmail = ConfigurationManager.AppSettings.Get("userEmail");
string userPassword = ConfigurationManager.AppSettings.Get("userPass");



//get some info from the user
Console.Write("Destination Email: ");
string recipientEmail = Console.ReadLine();

string messageSubject = "Test";
string messageBody = "This is a test message";


Console.WriteLine("Creating email object, and sending email.");

Email email = new Email(host, port, userName, userEmail, userPassword, recipientEmail, messageSubject, messageBody);

email.SendEmail();


Console.ReadKey();




