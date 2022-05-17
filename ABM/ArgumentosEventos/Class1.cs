using Entidades;

namespace ArgumentosEventos
{
    public class Class1
    {
        public class AccionComputadoraEventArgs : EventArgs
        {
            public string Accion { get; set; }
        }
        public class GuardadoCompletadoEventArgs : EventArgs
        {
            public bool Completo { get; set; }
        }
    }
}