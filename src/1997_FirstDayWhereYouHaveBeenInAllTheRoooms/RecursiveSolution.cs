namespace _1997_FirstDayWhereYouHaveBeenInAllTheRoooms;

/*
 * An example of a recursive solution, using a cache
 */
public class RecursiveSolution : ISolution
{
    private Dictionary<int, int> _cache = new();
    private const int Mod = 1000000007;

    public int FirstDayBeenInAllRooms(int[] nextVisit)
    {
        _cache.Clear();
        return DaysToRoom(nextVisit, nextVisit.Length - 1);
    }

    // Recursive function
    int DaysToRoom(int[] nextVisit, int room)
    {
        // Check for a cache result (the time to get to a given room is stable)
        if (_cache.TryGetValue(room, out var toRoom))
            return toRoom;
        
        if (room == 0)
            return 0;
        
        // This is the number of days to get to the room before this one
        var timeToPreviousRoom = (DaysToRoom(nextVisit, room - 1) + 1);
        
        // The second time we reach the previous room, it only has to go from
        // The room it jumps to, so we can remove those days
        var previousRoomTimeSkip = DaysToRoom(nextVisit, nextVisit[room - 1]);

        var daysToRoom =
            // Have to go to previous room twice
            2 * timeToPreviousRoom
            // Minus how long much time we skip the second time around
            - previousRoomTimeSkip;
        
        // Apply modulo magic to avoid negative numbers, and avoid
        // Big numbers
        daysToRoom = ((daysToRoom % Mod) + Mod) % Mod;
        
        // Update cache
        _cache[room] = daysToRoom;
        
        return daysToRoom;
    }
}
