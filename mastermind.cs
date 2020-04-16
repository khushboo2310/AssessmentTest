class HelloWorld {
  public static void Main() {
   int ans = 0;
//An empty string
   string pass = "";
   int userCount = 0;
   Random random = new Random();
//Generating random string of 4 digit
//We are using the System.random class
//It has a method Next(min, max) which takes two arguemnts
   for(int i=0;i<4;i++)
  {
//Appending the random digit in the string
   pass+=random.Next(1,6);
  }


while(true)
{   
//Game of Guessing Starts
ans = 0;
string userChoice="";
while(userChoice.Length != 4)
{
Console.WriteLine("Guess the password? ");
userChoice = Console.ReadLine();
if(userChoice.Length != 4)
{
Console.WriteLine("Invalid String combination. Please try again ");
}
}
userCount++;

//Calculating the frequencies of characters in user input
  
for(int i=0;i<4;i++)
{
if(userChoice[i] == pass[i])
{
ans++;
Console.Write("+");
if(ans == 4)
{
Console.WriteLine("Bravo!! You got it Correct");
}
}
else
{
if(pass.Contains(Char.ToString(userChoice[i])))
Console.Write("-");
else
Console.Write("X");
  
  
}
}
Console.WriteLine("");
if(userCount == 10 || ans == 4)
break;
  

}
//Check for losing condition
if(userCount == 10 && ans != 4)
Console.WriteLine("You lost the bet ");
  
Console.WriteLine("The correct password was " + pass);
}
}
