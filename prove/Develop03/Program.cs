using System;

class Program
{
    static void Main(string[] args){

        Fraction f1 = new Fraction();
        console.WriteLine(f1.GetFractionString());
        console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(5);
        console.WriteLine(f2.GetFractionString());
        console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(3, 4);
        console.WriteLine(f3.GetFractionString());
        console.WriteLine(f3.GetFractionString());

        Fraction f4 = new Fraction(1, 3);
        console.WriteLine(f4.GetFractionString());
        console.WriteLine(f4.GetFractionString());

    }
}