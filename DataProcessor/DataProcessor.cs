using System;
using System.Collections.Generic;

class DataProcessor {
    private int[] _arr;

    public int[] Arr {
        get => _arr;
    }

    public DataProcessor(int[] arr) {
        _arr = arr;
    }

    public void ForEach(Action<int> action) {
        foreach(var a in _arr) { action(a); }
    }

    public int[] Transform(Func<int, int> transformer) {
        int[] newArray = new int[_arr.Length];

        for (int i = 0; i < _arr.Length; i++) {
            newArray[i] = transformer(i);
        }
        
        return newArray;
    }

    public List<int> Filter(Func<int, bool> predicate) {
        var result = new List<int>();
        foreach (var a in _arr) {
            if (predicate(a)) {
                result.Add(a);
            }
        }
        
        return result;
    }

    public int Reduce(Func<int, int, int> reducer, int initialValue) {
        foreach (int val in _arr) {
            initialValue = reducer(val, initialValue);
        }
        
        return initialValue;
    }
}