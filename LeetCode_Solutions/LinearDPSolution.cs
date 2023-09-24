namespace _1997_FirstDayWhereYouHaveBeenInAllTheRoooms;

public class LinearDPSolution : ISolution
{
    const int Mod = 1000000007;

    public int FirstDayBeenInAllRooms(int[] nextVisit)
    {
        var daysToRooms = new int[nextVisit.Length];
        
        for (var i = 1; i < nextVisit.Length; i++)
        {
        
            // This is the number of days to get to the room before this one
            var timeToPreviousRoom = daysToRooms[i - 1] + 1;
        
            // The second time we reach the previous room, it only has to go from
            // The room it jumps to, so we can remove those days
            var previousRoomTimeSkip = daysToRooms[nextVisit[i - 1]];

            var daysToRoom =
                // Have to go to previous room twice
                2 * timeToPreviousRoom
                // Minus how long much time we skip the second time around
                - previousRoomTimeSkip;
            
            // Apply modulo magic to avoid negative numbers, and avoid
            // Big numbers
            daysToRoom = ((daysToRoom % Mod) + Mod) % Mod;

            daysToRooms[i] = daysToRoom;

        }
        return daysToRooms[^1];
    }
}
