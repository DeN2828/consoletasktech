using calculate_braking_distance;

bool a = true;
while (a)
{
    float number = 0;
    Console.WriteLine("Enter num (1 - icy; \n2 - snowy; \n3 - wet; \n4 - dry \n0 - Exit): ");
    int num = int.Parse(Console.ReadLine());
    switch (num)
    {
        case 0:
            a = false;
            break;
        case 1:
            number = 0.1F;
            break;
        case 2:
            number = 0.2F;
            break;
        case 3:
            number = 0.4F;
            break;
        case 4:
            number = 0.7F;
            break;
        default:
            Console.WriteLine("Error");
            break;
    }

    if (number == 0.1F || number == 0.2F || number == 0.4F || number == 0.7F)
    {
        Calculate calculate = new Calculate(1F, number, 100);
        Console.WriteLine(calculate.Calculates());
    }
    else
        Console.WriteLine("Error");
}