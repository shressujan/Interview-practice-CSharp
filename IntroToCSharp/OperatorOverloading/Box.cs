namespace OperatorOverloading
{
    public class Box
    {
        public double length;
        public double breadth;
        public double height;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }


        public static Box operator+ (Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length + b.Length;
            c.breadth = a.breadth + b.breadth;
            c.height = a.height + b.height;
            
            return c;
        }
        
    }
}