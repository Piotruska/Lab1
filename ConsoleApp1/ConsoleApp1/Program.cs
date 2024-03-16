//After Merge
//Task 4
static double max(int[] arrr)
{
    int maxxxx = arrr[0];
    foreach (int x in arrr)
    {
        if (x > maxxxx)
        {
            maxxxx = x;
        }
    }
    return maxxxx;
}
Console.WriteLine(max(new []{1,2,3,4,5,6,7,8,9,10}));


//Task 3
static double MyMethod(int[] arr)
{
    double total = 0;
    int len = arr.Length;
    foreach (int x in arr)
    {
        total += x;
    }
    return total/len;
}
Console.WriteLine(MyMethod(new []{1,2,3,4,5,6,7,8,9,10}));


Console.WriteLine("Hello, World!");

//Modification 1
Console.WriteLine("Mod 1");

//Modification 2
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";


//Modification 3
class Vechicle
{
    protected string name;
    protected int numberOfSouls;
}

class Car : Vechicle
{
    protected int numberOfDoors;
    
}

