using System;
using System.Collections.Generic;

List<int> Filter(int[] source, Func<int, bool> predicate) {
        List<int> result = new List<int>();
        foreach (var val in source) {
            if (predicate(val)) { result.Add(val); }
        }
        return result;
    }

// 1. 표현식 구문 : 람다식만 가능
{
    Calculator ananymous = delegate (int x) {
        return x * x;
    };
    Calculator lambda = x => x * x;
    Console.WriteLine($"익명 메서드 : {ananymous(4)}");
    Console.WriteLine($"람다식 : {lambda(4)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 조건부 필터링
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    List<int> evens = Filter(numbers, (x) => x % 2 == 0);
    List<int> over5 = Filter(numbers, x => x > 5);
    Console.Write($"짝수 : ");
    for (int i = 0; i < evens.Count; i++) { Console.Write($"{evens[i]} "); }
    Console.WriteLine();

    Console.Write($"5보다 큰 수 : ");
    for (int i = 0; i < over5.Count; i++) { Console.Write($"{over5[i]} "); }
}

// 3. 정적 익명 메서드
{
    int factor = 10;
    Func<int, int> normalMethod = delegate (int n) {
        return n * factor;
    };

    Func<int, int> staticMethod = static delegate (int n) {
        return n * 2;
    };

    Console.WriteLine(normalMethod(5));
    Console.WriteLine(staticMethod(5));
    Console.WriteLine();
    Console.WriteLine();
}

delegate int Calculator(int x);