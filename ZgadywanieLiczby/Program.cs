// See https://aka.ms/new-console-template for more information
using static System.Console;
GetAppInfo();
string UserName = GetUserName();
GreetUser(UserName);
Random random = new Random();
int correctNumber = random.Next(1,11);
bool correctAnswer = false;
WriteLine("Zgadnij wylosowaną liczbę z przedziału od 1 do 10.");
while(!correctAnswer)
{
    string input = ReadLine();
    int guess;
    bool isNumber = int.TryParse(input, out guess);
   
    if(!isNumber)
    {
        PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę.");
        continue;
    }
    if(guess<1 || guess>10)
    {
        PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę od 1 do 10.");
        continue;
    }
    
    if (guess < correctNumber)
    {
        PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedź! Wylosowana liczba jest większa.");
    }
    else if (guess > correctNumber)
    {
        PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedź! Wylosowana liczba jest mniejsza.");
    }
    else 
    {
        correctAnswer = true;
        PrintColorMessage(ConsoleColor.Green, "Brawo! Prawidłowa odpowiedź.");
    }
}



static void GetAppInfo()
{
    string appName = "Zgadywanie liczby";
    int appVersion = 1;
    string appAuthor = "Ania Praszczyk";
    string info =$"{appName}\nWersja 0.0.{appVersion}\nAutorka: {appAuthor}";
    PrintColorMessage(ConsoleColor.Magenta,info);
    

}
static string GetUserName()
{
    WriteLine("Jak masz na imię?");
    string InputUserName = ReadLine();
    return InputUserName;
}
static void GreetUser(string UserName)
{
    string greet = $"Powodzenia {UserName}, odgadnij liczbę...";
    PrintColorMessage(ConsoleColor.Blue, greet);
}
static void PrintColorMessage(ConsoleColor color, string message)
{
    ForegroundColor = color;
    WriteLine(message);
    ResetColor();
}