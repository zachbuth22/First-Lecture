//create a variable called x and give it a value of 5

int age = 5;
string name = "Justin";
string name2 = "Ethan";
/*
 * validate the number variable
 * do something if validated
 */
if (age == 1)
{

}

//declaring variables
int money;
//intialize variable
money = 5;
//combined
bool hungry = true;

//constant
const double taxRate = 0.06;
// taxRate = 6; // not allowed to change constants
//Console.WriteLine(taxRate);

Console.WriteLine("Please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry);
double value = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);

//increment/decrement
age++;
age = age + 1;
age--;
age = age - 1;

//odd or even
Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if (oddCheck == 0)
{ Console.WriteLine("even"); }
else if (oddCheck == 1)
{ Console.WriteLine("odd"); }

//assignment
value = 0;
value = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);

//null
string catName = null;
Console.WriteLine(catName);
catName = "Felony";
Console.WriteLine(catName);

string y = null;

if (y == null)
{ y = "YSDDD"; }

//nonnullable
//int z = null;

//Excercise 1
Console.WriteLine("Enter some text");
string ex1 = Console.ReadLine();
Console.WriteLine(ex1);

//Exercise 2
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number + 1);

//Exercise 3
Console.WriteLine("Enter a number");
double number2 = double.Parse(Console.ReadLine());
Console.WriteLine(number2 + .5);

//Exercise 4
Console.WriteLine("Enter a number");
double number3 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
double number4 = double.Parse(Console.ReadLine());
Console.WriteLine("The sum is " + (number3 + number4));

//Exercise 5
Console.WriteLine("Enter a number");
double number5 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
double number6 = double.Parse(Console.ReadLine());
Console.WriteLine("The product is " + (number5 * number6));

Console.ReadLine();