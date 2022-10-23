// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1=Promt("Input x1:");
int y1=Promt("Input y1:");
int z1=Promt("Input z1:");
int x2=Promt("Input x2:");
int y2=Promt("Input y2:");
int z2=Promt("Input z2:");

int x=x2-x1;
int y=y2-y1;
int z=z2-z1;
double Lenght=Math.Sqrt(x*x+y*y+z*z);
Console.WriteLine($"Расстояние между точками-> {Lenght:f2}");
