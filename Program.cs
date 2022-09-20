// ISM 4300
// Deliverable 4 Arrays
// 09/20/2022

int[] Fibonacci = new int[2];

Fibonacci[0] = 0;
Fibonacci[1] = 1;

int User_Range = 25;

while (Fibonacci.Length < User_Range)
{

    int next = Fibonacci[Fibonacci.Length-1] + Fibonacci[Fibonacci.Length-2];

    Fibonacci = Fibonacci.Append(next).ToArray();


   
}
for (int i = 0; i < Fibonacci.Length; i++)
{
    Console.WriteLine($"Fibonacci Number ({i})= {Fibonacci[i]}");
}

