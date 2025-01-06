using System;

class Test {

    public static void Main (string[] args){

       double Fahrenheit, celsius ;

       Console.WriteLine ("Temperature Calcutor");

       Console.Write("Enter Fahrenheit Temperature: ");
       Fahrenheit = Convert.ToDouble(Console.ReadLine());

       Console.Write("Enter Celsius Temperature: ");
       celsius = Convert.ToDouble(Console.ReadLine());

       celsius = (Fahrenheit - 32)/1.8 ;
       Fahrenheit = (1.8 * celsius)+32 ;

       Console.WriteLine ($"Temperature in Celsius = {celsius.ToString("F2")} C");
       Console.WriteLine ($"Temperature in Fahrenheit = {Fahrenheit.ToString("F2")} F");


    }


}
