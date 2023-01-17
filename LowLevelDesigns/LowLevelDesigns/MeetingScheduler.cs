using System;
using System.Collections.Generic;

namespace LowLevelDesigns
{
    public class Meeting
    {
        public Meeting(int start, int end, Room meetingRoom)
        {
            StartHour = start;
            EndHour = end;
            MeetingRoom = meetingRoom;
        }
        public int StartHour { get; set; }

        public int EndHour { get; set; }

        public Room MeetingRoom { get; set; }
    }

    public class Room
    {
        public Room(string name)
        {
            Name = name;
            MeetingsCalender = new List<Meeting>();
        }

        public List<Meeting> MeetingsCalender { get; set; }
        public string Name { get; set; }

        public bool BookRoom(int start, int end)
        {
            foreach (Meeting meeting in MeetingsCalender)
            {
                if (meeting.EndHour > start && end > meeting.StartHour)
                {
                    return false;
                }
            }
            MeetingsCalender.Add(new Meeting(start, end, this));
            return true;
        }
    }

    public class Scheduler
    {
        public Scheduler(List<Room> allRooms)
        {
            AllRooms = allRooms;
        }
        public List<Room> AllRooms { get; set; }
        public string BookRoom(int start, int end)
        {
            foreach (Room room in AllRooms)
            {
                if (room.BookRoom(start, end))
                {
                    return room.Name;
                };
            }
            return "No Rooms";
        }

        //internal void BookRoom(int v1, int v2)
        //{
        //    throw new NotImplementedException();
        //}
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Create Rooms
    //        List<Room> rooms = new List<Room> {
    //            new Room("Vivant"),
    //            new Room("Digras"),
    //            new Room("Ghantibaba")
    //        };

    //        Scheduler scheduler = new Scheduler(rooms);

    //        Console.WriteLine(scheduler.BookRoom(2, 5));
    //        Console.WriteLine(scheduler.BookRoom(5, 8));
    //        Console.WriteLine(scheduler.BookRoom(4, 8));
    //        Console.WriteLine(scheduler.BookRoom(3, 6));
    //        Console.WriteLine(scheduler.BookRoom(7, 8));

    //        Console.ReadLine();
    //    }
    //}
}
