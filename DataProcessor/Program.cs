using System;
using System.Collections.Generic;

DataProcessor dp = new DataProcessor(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

Action<int> print = (val) => Console.Write($"{val} ");

Console.WriteLine($"=== 원본 배열 출력 ===");
dp.ForEach(print);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 2배로 변환 ===");
dp.Transform((val) => val * 2);
dp.ForEach(print);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 짝수만 필터링 ===");
List<int> result = dp.Filter((val) => val % 2 == 0);
foreach (var res in result) { Console.Write($"{res} "); }
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 합계 계산 ===");
Console.WriteLine($"{dp.Reduce((a, b) => (a + b), 0)}");
Console.WriteLine();
Console.WriteLine();
