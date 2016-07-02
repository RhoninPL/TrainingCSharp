namespace ConsoleApplication1.Prototype
{
    public class BasePrototype
    {
        public string color;
        public int width;
        public int height;

        public BasePrototype()
        {
            color = "red";
            height = 200;
            width = 400;
        }

        public BasePrototype Clone()
        {
            return (BasePrototype) this.MemberwiseClone();
        }
    }
}