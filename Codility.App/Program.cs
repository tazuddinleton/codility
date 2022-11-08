internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // var possibility = SeatReservation.solution(2, "1A 2F 1C");
        var possibility = SeatReservation.Solution(22, "1A 3C 2B 20G 5A");
        // var possibility = SeatReservation.solution(2, "2G");
        Console.WriteLine("solution: ", possibility);
    }
}
