using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class SeatReservation {
    public static int Solution(int N, string S) {
        
        var possibility1 = "BCDE";
        var possibility2 = "DEFG";
        var possibility3 = "FGHJ";

        // First all possible combinations are gathered, then start cancelling out as the
        // reserved seat number is read from the string S
        var possibilities = new Dictionary<int, List<string>>();
        for (int i = 1; i <= N; i++) {
            possibilities.Add(i, new List<string>(){possibility1, possibility2, possibility3});
        }

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
        
        // Now that we have canceled out all the reserved seats from potentially reservable list of seats, we need to 
        // filter out any remaining invalid seat combination.
        var values = possibilities.ToList().Select(pair => pair.Value).Select(list => {
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
