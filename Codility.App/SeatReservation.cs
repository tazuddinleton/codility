using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class SeatReservation {
    public static int Solution(int N, string S) {
        
        var possibility1 = "BCDE";
        var possibility2 = "DEFG";
        var possibility3 = "FGHJ";

        // Gather all possible combination.
        var possibilities = new Dictionary<int, List<string>>();
        for (int i = 1; i <= N; i++) {
            possibilities.Add(i, new List<string>(){possibility1, possibility2, possibility3});
        }

        // Remove the ones already reserved.
        if (S != null && S.Length > 0) {
            var reservations =  S.Split(' ');        
            reservations.ToList().ForEach(seat => {  
                var rowNum = seat.Length == 2 ? int.Parse(seat.Substring(0, 1)) : int.Parse(seat.Substring(0, 2));                
                if (possibilities.TryGetValue(rowNum, out var row)) {
                    var colNum = seat[seat.Length - 1].ToString();
                    var filtered = row.Where(p => !p.Contains(colNum)).ToList();
                    possibilities[rowNum] = filtered;
                }
            });
        }
        
        
        // Filter out any remaining invalid seat combination.
        return possibilities.ToList()
            .Select(pair => pair.Value)
            .Select(possibilities => {
                var d = new HashSet<char>();
                possibilities.ForEach(possibility => {
                    var array  = possibility.ToCharArray();
                    foreach(var c in  array) {
                        d.Add(c);
                    }
                });
                return d.Count/4;
            }).ToList().Sum();
    }
}
