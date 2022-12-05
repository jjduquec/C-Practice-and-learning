using System.Xml;

// unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0 
int integerNumber = -23;

// float means single-precision floating point 
// F suffix makes it a float literal  
float realNumber = 2.3F;
//double means double-precision floating point 
double anotherRealNumber = 2.3; //double literal 



// Numbers with underscore separator 

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1000_0100_0000;
int hexadecimalNotation = 0x_001E_8480;
//Checking variables 

//Console.WriteLine($"{decimalNotation== binaryNotation}");
//Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

//Console.WriteLine("Using doubles:");
decimal a = 0.1M;
decimal b = 0.2M;

/*

if (a + b == 0.3M)
{
    Console.WriteLine($"{a} + {b} equals {0.3M}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3M}");
}


*/


//dynamic  

dynamic something = "Ahmed";

//Console.WriteLine($"Length is {something.Length}");   

//trying var 
var mystring = "incursion en pista";
//Console.WriteLine(mystring);


//working with XML  

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");


int number = 13;
//Console.WriteLine($"number has been set to : {number}");
number = default;
//Console.WriteLine($"number has been reset to its default : {number}"); 

string[] names;
names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

//alternative to the array declaration  
// string[] names = new [] {"Kate","Jack","Rebecca","Tom"}


//looping for get the names 
/*
for (int i = 0; i < names.Length; i++) {


    Console.WriteLine(names[i]);

} 

*/

Console.Write("this is a test of Write special word");