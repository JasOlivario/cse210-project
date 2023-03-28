using System;

class Program
{
    static void Main(string[] args)
    {

    

       Fraction f1 = new Fraction();
       f1.SetTop(1);
       f1.GetTop();
       f1.SetBottom(1);
       f1.GetBottom();
       f1.GetFractionString();
       f1.GetDecimalValue(1,1);

       Fraction f2 = new Fraction(5);
       f2.SetBottom(1);
       f2.GetBottom();
       f2.GetFractionString();
       f2.GetDecimalValue(5,1);

       Fraction f3 = new Fraction(3,4);
       f3.GetFractionString();
       f3.GetDecimalValue(3,4);

       Fraction f4 = new Fraction(1,3);
       f4.GetFractionString();
       f4.GetDecimalValue(1,3);



    }
}