//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TryWritingClass
//{
//    internal class Class2
//    {
//    }
//}

//?想要使用方法，但是不知道要怎麼寫?
Circle cir = new Circle();

//--------------------

//【多型】方法覆寫（Method Overriding）
//當我們創建一個 Circle 或 Rectangle 對象並調用 Draw 方法時，
//將會執行該子類別中的方法，而不是父類別中的方法。
//這種行為稱為動態多型（Dynamic Polymorphism），因為在運行時才決定要執行哪個方法。

class Shape //父類別Parent Class
{
    public virtual void Draw() 
    //定義Draw方法，使用 virtual 關鍵字表示這是一個可以被覆寫的方法。
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle:Shape //繼承父類別為子類別Child Class
{
    public override void Draw()
    //重新定義了 Draw 方法，並使用 override 關鍵字表示覆寫了父類別的方法。
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : Shape //繼承父類別為子類別Child Class
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}