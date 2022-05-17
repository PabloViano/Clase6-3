using Entidades;
using ArgumentosEventos;

using Persistencia;

namespace Logica
{
    public sealed class Class1
    {
        private static Class1? instance = null;
        List<Computadora> Computadoras = Persistencia.principal.Instancia.LeerComputadoras();
        private Class1() { }
        public static Class1 Instance
        {
            get
            {
                if (instance == null) { instance = new Class1(); }
                return instance;
            }
        }
        public EventHandler<ArgumentosEventos.Class1.AccionComputadoraEventArgs> AccionCompletada;

        public void Alta(string proce, string placa, decimal ram, decimal disco)
        {
            Computadora computadora = new Computadora(Computadoras.Count + 1, proce, placa, ram, disco);
            Computadoras.Add(computadora);
            ActualizarListado();
            if (AccionCompletada != null)
            {
                this.AccionCompletada(this, new ArgumentosEventos.Class1.AccionComputadoraEventArgs { Accion = "Alta" });
            }
        }
        public void Baja(int id)
        {
            Computadoras.Remove(Computadoras.Find(x => x.ID == id));
            ActualizarListado();
            if (AccionCompletada != null)
            {
                this.AccionCompletada(this, new ArgumentosEventos.Class1.AccionComputadoraEventArgs { Accion = "Baja" });
            }
        }
        public void Modificacion(int id, string proce, string placa, decimal ram, decimal disco)
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
            ActualizarListado();
            if (AccionCompletada != null)
            {
                this.AccionCompletada(this, new ArgumentosEventos.Class1.AccionComputadoraEventArgs { Accion = "Modificacion" });
            }
        }
        public void ActualizarListado()
        {
            Persistencia.principal.Instancia.GuardarComputadoras(this.Computadoras);
        }
    }
}