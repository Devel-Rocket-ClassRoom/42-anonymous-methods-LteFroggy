using System;

Func<int> baseCounter = CounterFactory.CreateSimpleCounter();
Func<int> stepCounter = CounterFactory.CreateStepCounter(3);
Func<int> boundedCounter = CounterFactory.CreateBoundedCounter(1, 3);
Func<int> resettableCounter;
Action reset;

CounterFactory.CreateResettableCounter(out reset, out resettableCounter);

Console.WriteLine($"=== 단순 카운터 ===");
Console.Write($"{baseCounter()} ");
Console.Write($"{baseCounter()} ");
Console.Write($"{baseCounter()} ");
Console.Write($"{baseCounter()} ");
Console.Write($"{baseCounter()} ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 스텝 카운터 (step = 3) ===");
Console.Write($"{stepCounter()} ");
Console.Write($"{stepCounter()} ");
Console.Write($"{stepCounter()} ");
Console.Write($"{stepCounter()} ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 범위 카운터 (1 ~ 3) ===");
Console.Write($"{boundedCounter()} ");
Console.Write($"{boundedCounter()} ");
Console.Write($"{boundedCounter()} ");
Console.Write($"{boundedCounter()} ");
Console.Write($"{boundedCounter()} ");
Console.Write($"{boundedCounter()} ");
Console.Write($"{boundedCounter()} ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 리셋 가능 카운터 ===");
Console.Write($"호출 : ");
Console.Write($"{resettableCounter()} ");
Console.Write($"{resettableCounter()} ");
Console.Write($"{resettableCounter()} ");
Console.WriteLine();
reset();
Console.Write($"리셋 후 : ");
Console.Write($"{resettableCounter()} ");
Console.Write($"{resettableCounter()} ");
Console.WriteLine();



