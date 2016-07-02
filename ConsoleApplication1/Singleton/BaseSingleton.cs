namespace ConsoleApplication1.Singleton
{
    public class BaseSingleton
    {
        private static BaseSingleton instance;
        private BaseSingleton() { }

        private string text;

        public string Text { get; set; }

        public static BaseSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseSingleton();
                }
                return instance;
            }
        }
    }
}