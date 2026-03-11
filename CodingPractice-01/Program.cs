using System;

// 1. 명명된 메서드를 대리자에 전달
{
    Calculator cal = square;

    Console.WriteLine(cal(5));

    Console.WriteLine();
    Console.WriteLine();
}

// 2. 반환 타입이 있는 익명 메서드
{
    TransFormer tf1 = delegate (int x) {
        return x * x;
    };
    TransFormer cube = delegate (int x) {
        return x * x * x;
    };

    Console.WriteLine($"3의 제곱 : {tf1(3)}");
    Console.WriteLine($"3의 세제곱 : {cube(3)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 반환 타입이 없는 익명 메서드
{
    Printer p1 = delegate (string message) {
        Console.WriteLine($"[메세지] : {message}");
    };

    p1("안녕하세요!");
    p1("익명 메서드를 사용 중입니다.");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. Func와 Action 델리게이트 사용
{
    Func <int, int> doubleTime = delegate (int x) {
        return x * 2;
    };

    Action<string> printMsg = delegate (string msg) {
        Console.WriteLine($"[LOG] {msg}");
    };

    Console.WriteLine($"{doubleTime(10)}");
    printMsg("작업 시작");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 매개변수 생략
{
    SimpleDelegate sd = delegate {
        Console.WriteLine($"매개변수를 사용하지 않습니다.");
    };

    sd(100, "테스트");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 이벤트 핸들러에서의 매개변수 생략
{
    EventHandler onClick = delegate {
        Console.WriteLine("클릭 이벤트 발생!");
    };

    onClick(null, EventArgs.Empty);
    Console.WriteLine();
    Console.WriteLine();
}


int square(int x) => x * x;

delegate void EventHandler(object obj, EventArgs args);
delegate void SimpleDelegate(int val, string str);
delegate void Printer(string s);
delegate int TransFormer(int x);
delegate int Calculator(int a);