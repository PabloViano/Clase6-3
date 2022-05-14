using Entidades;
using ArgumentosEventos;

using Persistencia;

namespace Logica
{
    public class Class1
    {
        private static Class1? instance = null;
        List<Computadora> Computadoras = Persistencia.principal.Instance.LeerComputadoras();
        private Class1() { }
        public static Class1 Instance
        {
            get
            {
                if (instance == null) { instance = new Class1(); } return instance;
            }
        }
        public EventHandler<ArgumentosEventos.Class1.AccionComputadoraEventArgs> AccionCompletada;
        
        public void Alta(string proce, string placa, decimal ram, decimal disco)
        {
            Computadora computadora = new Computadora(Computadoras.Count + 1,proce, placa, ram, disco);
            Computadoras.Add(computadora);
            GuardadoEventHandler(this, new ArgumentosEventos.Class1.AccionComputadoraEventArgs() { Accion = "Agregada", computadoras = this.Computadoras });
        }
        public void Baja(int id)
        {
            Computadoras.Remove(Computadoras.Find(x => x.ID == id));
            GuardadoEventHandler(this, new ArgumentosEventos.Class1.AccionComputadoraEventArgs() { Accion = "Eliminada", computadoras = this.Computadoras });
        }
        public void Modificacion (int id,string proce, string placa, decimal ram, decimal disco)
        {
            foreach (var item in Computadoras)
            {
                if (item.ID == id)
                {
                    item.TamañoDiscoDuro = disco;
                    item.Procesador = proce;
                    item.TamañoMemoriaRAM = ram;
                    item.PlacadeVideo = placa;
                }
            }
            GuardadoEventHandler(this, new ArgumentosEventos.Class1.AccionComputadoraEventArgs() { Accion = "Modificada", computadoras = this.Computadoras });
        }
        public static void GuardadoEventHandler(object? sender, ArgumentosEventos.Class1.AccionComputadoraEventArgs e)
        {
            
        }
    }
}