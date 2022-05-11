namespace Entidades
{
    public class Computadora
    {
        public int ID { get; set; }
        public string Procesador { get; set; }
        public string PlacadeVideo { get; set; }
        public decimal TamañoMemoriaRAM { get; set; }
        public decimal TamañoDiscoDuro { get; set; }
        public Computadora() { }
        public Computadora(int id,string proce, string placa, decimal ram, decimal disco)
        {
            this.ID = id;
            this.Procesador = proce;
            this.PlacadeVideo = placa;
            this.TamañoMemoriaRAM = ram;
            this.TamañoDiscoDuro = disco;
        }
    }
}