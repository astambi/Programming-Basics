using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Light_the_Torches
{
    class _04_Light_the_Torches
    {
        static void Main(string[] args)
        {
            int roomsCount = int.Parse(Console.ReadLine()); // odd number
            string roomsInput = Console.ReadLine();         // string could be shorted than number of rooms = > loop string
            string endOfInput = "END";
            string input = "";
            int currentIndex = roomsCount / 2;              // middle room in array [0, n-1]
            int prevIndex = currentIndex;

            // set initial light in rooms
            char[] rooms = new char[roomsCount];            // L/D chars for lighted/dark state
            SetLightInRooms(rooms, roomsInput);
            // get commands and update light in destination room
            while ((input = Console.ReadLine().ToUpper()) != endOfInput)
            {
                string[] inputDetails = input.Split(' ');
                bool goRight = inputDetails[0] == "RIGHT";
                int step = int.Parse(inputDetails[1]);
                // calc destination room
                if (goRight)
                    currentIndex = Math.Min(prevIndex + step + 1, roomsCount - 1);  // last room
                else
                    currentIndex = Math.Max(prevIndex - step - 1, 0);               // first room
                // update light in dest room
                bool sameRoom = currentIndex == prevIndex;
                if (!sameRoom) rooms[currentIndex] = UpdateLightInRoom(rooms[currentIndex]);
                prevIndex = currentIndex;
            }
            // count dark rooms and calculate number of prayers
            int darkroomsCount = CountDarkRooms(rooms);
            int prayers = (int)('D') * darkroomsCount;
            Console.WriteLine(prayers);
        }
        static void SetLightInRooms(char[] rooms, string roomsInput)
        {
            int roomsCount = rooms.Length;
            for (int i = 0; i < roomsCount; i++)
                rooms[i] = roomsInput[i % roomsInput.Length];
        }
        static char UpdateLightInRoom(char room)
        {
            bool isLighted = room == 'L';
            if (isLighted)   room = 'D';
            else room = 'L';
            return room;
        }
        static int CountDarkRooms(char[] rooms)
        {
            int count = 0;
            foreach (char room in rooms)
                if (room == 'D') count++;
            return count;
        }
    }
}