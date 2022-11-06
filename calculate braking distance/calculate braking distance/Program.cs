using calculate_braking_distance;

Calculate calculate = new Calculate();
calculate.GetResult();
calculate = new Calculate(1F, calculate.number, calculate.Speed);
Console.WriteLine(calculate.Calculates());