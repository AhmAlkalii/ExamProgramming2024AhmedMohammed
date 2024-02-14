namespace Geometry
{
    interface IReflectable
    {
        void ReflectX();
        void ReflectY();
    }

    public class Point : IReflectable
    {
        private double _x, _y;
        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public Point(double z)
        {
            _x = z;
            _y = 0;
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void ReflectX()
        {
            _x = -_x;
        }

        public void ReflectY()
        {
            _y = -_y;
        }

        public enum PointColour
        {
            Red,
            Green,
            Blue
        }
    }

    public class ColourfulPoint : Point
    {
        private Point _colour;

        public Point Colour { get { return _colour; } }
        public ColourfulPoint(double x, double y, Point colour) : base(x,y)
        {
            _colour = colour;
        }
    }

}

//Stopped at task with Grade 4.0