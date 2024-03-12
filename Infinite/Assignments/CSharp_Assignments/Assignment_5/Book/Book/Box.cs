using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public static Box Add_Dimensions(Box box1, Box box2)
    {
        double Add_Length = box1.Length + box2.Length;
        double Add_Breadth = box1.Breadth + box2.Breadth;
        return new Box(Add_Length, Add_Breadth);
    }

    public void Display_Box()
    {
        Console.WriteLine($"The Dimensions for Box 3 is Lenght: {Length}, Breadth: {Breadth}");

    }

}




    






