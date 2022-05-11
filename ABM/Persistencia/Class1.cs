namespace Persistencia
{
    public class Class1
    {
        private static Class1 instance = null;
        private Class1() { }
        public static Class1 Instance
        {
            get
            {
                if (instance == null) { instance = new Class1(); }
                return instance;
            }
        }
    }
}