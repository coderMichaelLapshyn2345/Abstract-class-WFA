// Географічний об'єкт 
using System;
namespace Geography
{
    abstract class Geographical_Object
    {
        public int X_coor;
        public int Y_coor;
        public string description;
        public string name;
        public Geographical_Object(int X, int Y, string des, string n)
        {
            X_coor = X;
            Y_coor = Y;
            description = des;
            name = n;
        }
        public virtual void GetInformation()
        {
            Console.WriteLine($"X: {X_coor}\n Y: {Y_coor} \n Name: {name} \n Description: {description}");
        }
        
    }
    class River : Geographical_Object
    {
        public double speed;
        public int len;

        public River(int X_coor, int Y_coor, string description, string name, double speed, int len) : base(X_coor, Y_coor, description, name)
        {
        }
    }
    class Mountain : Geographical_Object
    {
        public int highest_point;
        public Mountain(int X_coor, int Y_coor, string description, string name, int highest_point): base(X_coor, Y_coor, description, name)
        {
            this.highest_point = highest_point;
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 5, y = 7;
            double s1 = 20;
            int l1 = 300;
            int high = 5000;
            string d = "a", n = "b";
            // Geographical_Object g = new Geographical_Object(x, y, d, n);
            River r = new River(x, y, d, n, s1, l1);
            Mountain m = new Mountain(x,y,d,n, high);
            r.X_coor = 20;
            r.Y_coor = 30;
            r.description = "River of Ukraine ";
            r.name = "Dnipro";
            r.len = 2000;
            r.speed = 15;
            r.GetInformation();
            Console.Write($"Lenght: {r.len} \n Speed: {r.speed} \n");
            m.X_coor = 4;
            m.Y_coor = 10;
            m.description = "The highest mountain in Ukraine";
            m.name = "Hoverla";
           // m.highest_point = 5000;
            m.GetInformation();
            Console.Write($"Max height: {m.highest_point}");

        }
    }

}

