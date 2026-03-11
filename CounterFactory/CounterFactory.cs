using System;

static class CounterFactory {
    public static Func<int> CreateSimpleCounter() {
        int count = 0;
        return () => ++count;
    }

    public static Func<int> CreateStepCounter(int step) {
        int count = 0;
        return () => {
            count += step;
            return count;
        };
    }

    public static Func<int> CreateBoundedCounter(int min, int max) {
        int count = min - 1;
        return () => {
            if (++count > max) count = min;
            return count;
        };
    }

    public static void CreateResettableCounter(out Action reset, out Func<int> func) {
        int count = 0;
        reset = () => count = 0;
        func = () => ++count;
    }
    
}