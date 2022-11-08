using System;
using System.Collections.Generic;
using System.Linq;
public class BananaCounter {
    public static int Solution(string S) {        

        if (S == null || S.Length == 0) {
            return 0;
        }
        var counter = new Dictionary<char, int>();
        var move = new Dictionary<char, int>();
        move.Add('A', 3);
        move.Add('B', 1);
        move.Add('N', 2);

        var array = S.ToCharArray();
        foreach(char c in array) {
            if (counter.ContainsKey(c)) {
                counter[c]++;
                continue;
            } 
            counter[c] = 1;
        }
        
        if (!move.Keys.All(k => counter.Keys.Contains(k))) {
            return 0;
        }

        // Console.WriteLine($"A: {counter['A']}, B: {counter['B']}, N: {counter['N']}");

        return counter.ToList().Where(pair => move.Keys.Contains(pair.Key))
            .Select(pair => pair.Value/ move[pair.Key])
            .Min();
    }
}
