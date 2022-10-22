using calculate_braking_distance;

Console.WriteLine("Enter coating condition: (0,1 - icy; 0,2 - snowy; 0,4 - wet; 0,7 - dry)");
float input = float.Parse(Console.ReadLine());
if (input == 0.1F || input == 0.2F || input == 0.4F || input == 0.7F)
{
    Calculate calculate = new Calculate(1F, input, 100);
    Console.WriteLine(calculate.Calculates());
}
else
{
    Console.WriteLine("Error");
}