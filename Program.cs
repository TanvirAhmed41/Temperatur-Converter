using System;

class Test {

    public static void Main (string[] args){

       double Fahrenheit, celsius ;

       Console.WriteLine ("Temperature Calcutor");

       Console.Write("Enter Fahrenheit Temperature: ");
       Fahrenheit = Convert.ToDouble(Console.ReadLine());

       celsius = (Fahrenheit - 32)/1.8 ;

       Console.WriteLine ($"Temperature in Celsius = {celsius.ToString("F2")}");


    }


}
