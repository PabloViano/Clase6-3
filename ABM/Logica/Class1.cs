using Entidades;

namespace Logica
{
    public class ComputadoraEventArgs : EventArgs
    {
        public string Procesador { get; set; }
        public string PlacadeVideo { get; set; }
        public decimal TamañoMemoriaRAM { get; set; }
        public decimal TamañoDiscoDuro { get; set; }
    }
    public class Class1
    {
        private static Class1 instance = null;
        public List<Computadora> Computadoras = new List<Computadora>();
        private Class1() { }
        public static Class1 Instance
        {
            get
            {
                if (instance == null) { instance = new Class1(); } return instance;
            }
        }
        public void Alta(string proce, string placa, decimal ram, decimal disco)
        {
            Computadora computadora = new Computadora(Computadoras.Count + 1,proce, placa, ram, disco);
            Computadoras.Add(computadora);
        }
        public void Baja(string proce, string placa, decimal ram, decimal disco)
        {
            Computadoras.Remove(Computadoras.Find(x => x.PlacadeVideo == placa && x.Procesador == proce && x.TamañoDiscoDuro == disco && x.TamañoMemoriaRAM == ram));
        }
        public void Modificacion (string proce, string placa, decimal ram, decimal disco)
        {
            Computadoras.Find(x => x == computadora).Procesador = proce;
            Computadoras.Find(x => x == computadora).PlacadeVideo = placa;
            Computadoras.Find(x => x == computadora).TamañoMemoriaRAM = ram;
            Computadoras.Find(x => x == computadora).TamañoDiscoDuro = disco;
        }
    }
}