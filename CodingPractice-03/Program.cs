using System;
using System.Globalization;

// 1. 익명 메서드와 람다식 비교
{
    Calculator cDelegate = delegate(int x) {
        return x * x;
    };
    Calculator cLambda = (int x) => {
        return x * x;
    };
    Calculator cLambda2 = (int x) => x * x;

    Console.WriteLine($"익명 메서드 : {cDelegate(5)}");
    Console.WriteLine($"람다식 (블록) : {cLambda(5)}");
    Console.WriteLine($"람다식 (표현식) : {cLambda2(5)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 매개변수 생략 : 익명 메서드만 가능
{
    EventHandler onEvent= delegate {
        Console.WriteLine($"이벤트 처리됨");
    };

    onEvent(123, EventArgs.Empty);
    onEvent(123, EventArgs.Empty);
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 빈 이벤트 핸들러 초기화
{
    GameEvent onScoreChange = delegate { };
    GameEvent onGameOver = delegate { };

    onScoreChange = (str, val) => Console.WriteLine($"[이벤트] : {str} : {val}");
    onGameOver = (str, val) => Console.WriteLine($"[게임 종료] : {str} : {val}");

    onScoreChange("점수 변경", 100);
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 콜백 함수로 사용
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int sum = 0;

    ProcessData(numbers, (x) => {
        sum += x;
        Console.WriteLine($"처리 중 : {x}, 누적 {sum}");        
    });

    Console.WriteLine($"최종 합계 : 15");
    Console.WriteLine();
    Console.WriteLine();
    
    void ProcessData(int[] numbers, Action<int> callback) {
        foreach (var num in numbers) { callback(num); }
    }
}

delegate void GameEvent(string str, int val);
delegate void EventHandler(object obj, EventArgs e);
delegate int Calculator(int x);