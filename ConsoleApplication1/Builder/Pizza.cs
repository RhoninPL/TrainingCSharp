namespace ConsoleApplication1.Builder
{
    public class Pizza
    {
        private string topping;

        private string sauce;

        public string Topping
        {
            get
            {
                return topping;
            }
            set
            {
                topping = value;
            }
        }
        public string Sauce
        {
            get
            {
                return sauce;
            }
            set
            {
                sauce = value;
            }
        }
 
        public override string ToString()
        {
            return string.Format(
                    "Sos: {0} z dodatkami: {1}",
                    Sauce,
                    Topping);
        }
    }
}