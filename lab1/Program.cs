// See https://aka.ms/new-console-template for more information
Console.Write("Введите количество капель: ");
int amount = Convert.ToInt32(Console.ReadLine());
Double horseMass = 420000.0;
Double mouseMass = 19.0;
int calcMices(int amount) {
    return (int)Math.Truncate((horseMass * amount) / mouseMass);
}
Console.WriteLine($"Если средняя масса лошади 420кг, а средняя масса мыши 19г, то {amount} капель убьет {calcMices(amount)} мышей");

