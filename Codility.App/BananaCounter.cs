using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class BananaCounter {
    public static int Solution(string S) {        
        // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)

        if (S == null || S.Length == 0) {
            return 0;
        }
        var counter = new Dictionary<char, int>();
        var move = new Dictionary<char, int>();
        move.Add('A', 3);
        move.Add('B', 1);
        move.Add('N', 2);

        var charArray = S.ToCharArray();
        foreach(char item in charArray) {
            if (counter.ContainsKey(item)) {
                counter[item]++;
            } else {
                counter[item] = 1;
            }
        }
        
        if (!move.Keys.All(k => counter.Keys.Contains(k))) {
            return 0;
        }

        // Console.WriteLine($"A: {counter['A']}, B: {counter['B']}, N: {counter['N']}");

        var min = counter.ToList()
        .Where(pair => move.Keys.Contains(pair.Key))
        .Select(pair => pair.Value/ move[pair.Key])
        .Min();
        
        return min;
    }
}
