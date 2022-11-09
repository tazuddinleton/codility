using Xunit;

public class SeatReservationTest
{

    [Theory]
    [InlineData(1, "", 2)]
    [InlineData(2, "", 4)]
    [InlineData(2, "1A 2F 1C", 2)]
    public void ShouldReturnPossibleReservationCount_WhenAlreadyBookedSeatsAreGiven(int numRows, string booked, int expected) {
        Assert.Equal(expected, SeatReservation.Solution(numRows, booked));
    }
    
}