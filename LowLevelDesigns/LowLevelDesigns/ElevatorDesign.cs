using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LowLevelDesigns
{
    public enum Direction
    {
        Up,
        Down
    }

    public enum LiftState
    {
        Moving,
        Paused,
        NoRequest
    }

    public class OutSiderRequest
    {
        public int FromFloor { get; set; }

        public Direction ToDirection { get; set; }
    }

    public class InsiderRequest
    {
        public int ToFloor { get; set; }
    }

    public class Elevator
    {
        public Direction CurrentDirection { get; set; }
        public LiftState State { get; set; }
        public int CurrentFloor { get; set; }


        public void Start()
        {
            while (true)
            {

            }
        }

        //public void stop()
        //{
        //    //stop elevator
        //}

        //public void addJob() { }
    }

    public class Request
    {

    }

    //public class RequestComparer : IComparable<RequestComparer>
    //{
    //    public int CompareTo(RequestComparer other)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class ProcessJobWorker : IRunnable
    public class TestElevatorDesign
    {
        public static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            Thread worker = new Thread(new ThreadStart(elevator.Start));
            worker.Start();
            Request request = new Request();
            Thread buttonPanel = new Thread(new DispatchRequest(elevator, request).AddRequestToQueue);
            buttonPanel.Start();
        }
    }

    internal class DispatchRequest
    {
        private Elevator elevator;
        public Request Request { get; set; }

        public DispatchRequest(Elevator elevator, Request request)
        {
            this.elevator = elevator;
            Request = request;
        }

        public void AddRequestToQueue()
        {
            //elevator.AddJob()
        }
    }
}
