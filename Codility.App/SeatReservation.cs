using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class SeatReservation {
    public static int solution(int N, string S) {
        // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
        
        var validComb1 = "BCDE";
        var validComb2 = "DEFG";
        var validComb3 = "FGHJ";

        var possibilities = new Dictionary<int, List<string>>();
        for (int i = 1; i <= N; i++) {
            possibilities.Add(i, new List<string>(){validComb1, validComb2, validComb3});
        }

        if (S != null && S.Length > 0) {
            var reservations =  S.Split(' ');        
            reservations.ToList().ForEach(seat => {  
                var rowNum = seat.Length == 2 ? int.Parse(seat.Substring(0, 1)) : int.Parse(seat.Substring(0, 2));
                if (rowNum == 20) {
                    Console.WriteLine("Here");
                }
                if (possibilities.TryGetValue(rowNum, out var row)) {
                    var col = seat[seat.Length - 1].ToString();
                    var p = row.Where(comb => !comb.Contains(col)).ToList();
                    possibilities[rowNum] = p;
                }
            });
        }
        
        var values = possibilities.ToList()
        .Select(pair => pair.Value)
        .Select(list => {
            var d = new HashSet<char>();
            list.ForEach(str => {
                var ch  = str.ToCharArray();
                foreach(char item in  ch) {
                    d.Add(item);
                }
            });
            return d.Count/4;
        }).ToList();;
        
       return values.Sum();

        // return possibilities.ToList().Select(pair => pair.Value.Count()).Sum();
    }
}
