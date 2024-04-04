// Alexandra Camarena
// HW 6 Task 3

Console.WriteLine("Please input a sentence: ");

string str = Console.ReadLine();
str = str.ToUpper();

string newStr = str.Replace("A","4");
newStr = newStr.Replace("E","3");
newStr = newStr.Replace("H","|-|");
newStr = newStr.Replace("S","$");
newStr = newStr.Replace("T","7");
newStr = newStr.Replace("U","|_|");
newStr = newStr.Replace("O","0");
newStr = newStr.Replace("P","[]D");

Console.WriteLine("The new sentence after conversion is: ");
if (newStr[newStr.Length - 1] == '!')
{
    Console.WriteLine(newStr);
}
else 
{
    newStr = string.Format($"{newStr}!");
    Console.WriteLine(newStr);
}