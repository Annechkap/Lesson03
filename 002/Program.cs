// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

const int X = 0;
const int Y = 1;
const int C = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];
    answer[X] = Prompt($"Введите x {point}  ");
    answer[Y] = Prompt($"Введите y {point}  ");
    answer[C] = Prompt($"Введите c {point}  ");
    return answer;
}
double Power2(int arg)
{
    return arg * arg;
}
int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + Power2(p1[Y] - p2[Y]) + Power2(p1[C] - p2[C]));

System.Console.WriteLine($"{lenght:f2}");
