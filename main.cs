using System;

class MainClass {
  public static void Main (string[] args) {
        string myName;
    myName = "veer";//assigning a variable
    Console.WriteLine("my name is " + myName);//printing their name
    Console.ReadKey();//reads the write line
    
    // User inputs STRING
    string myName;//declaring a variable myName
    Console.Write("Name: ");//printing 
    myName = Console.ReadLine();//initializes variable to ReadLine 
    Console.WriteLine("My name is " + myName);//prints name
    Console.ReadKey();//reads writeline


    // User inputs age as a STRING
    string myAgeString;//assigns variable myAgeString
    int myAge;//declaring a variable myAge
    Console.Write("Age: ");//printing age
    myAgeString = Console.ReadLine();//initializes variable to write line?
    // int.Parse() converts the STRING to an INTEGER.
    myAge = int.Parse(myAgeString);//pulls apart the age variable into different parts to make it a number
    Console.WriteLine("My age is " + myAge);//pritnts the variable of myAge as an int
    Console.ReadKey();//reads the writeline

  }
}