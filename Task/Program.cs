// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear ();
Console.Write("Enter number of array elements: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Enter {i+1} array elements ");
     stringArray[i] = Console.ReadLine();
  }
}
string [] temporary(string [] stringArray)
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}
void printA(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($" ‘{stringArray[i]}’, ");
    }
    Console.Write("]");
}
array(stringArray);
printA(temporary(stringArray));
