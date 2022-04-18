namespace TECAir_API.Models
{
    public sealed class Singleton
    {
        private static Singleton instance;
        public string usuario;

        public Singleton()
        {}

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
