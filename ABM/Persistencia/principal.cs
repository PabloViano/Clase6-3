using Entidades;
using ArgumentosEventos;
using Newtonsoft.Json;

namespace Persistencia
{
    public sealed class principal
    {
        private static principal? instancia = null;
        private principal() { }
        public EventHandler<ArgumentosEventos.Class1.GuardadoCompletadoEventArgs> GuardadoCompleto;
        public static principal Instancia
        {
            get
            {
                if (instancia == null) { instancia = new principal(); }
                return instancia;
            }
        }

        const string path = @"A:\User\Pablo\Universidad\Programacion ll\Clase6-3\ABM\Computadoras.txt";
        List<Computadora> computadoras = new List<Computadora>();
        public List<Computadora> LeerComputadoras()
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string computadora = reader.ReadToEnd();
                    if (computadora != "")
                    {
                        computadoras = JsonConvert.DeserializeObject<List<Computadora>>(computadora);
                    }
                }
            }
            return computadoras;
        }
        public void GuardarComputadoras(List<Computadora> Computadoras)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    string ComputadorasjSON = JsonConvert.SerializeObject(Computadoras);
                    writer.Write(ComputadorasjSON);
                    if (GuardadoCompleto != null)
                    {
                        this.GuardadoCompleto(this, new ArgumentosEventos.Class1.GuardadoCompletadoEventArgs() { Completo = true });
                    }
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    string ComputadorasjSON = JsonConvert.SerializeObject(Computadoras);
                    writer.Write(ComputadorasjSON);
                    if (GuardadoCompleto != null)
                    {
                        this.GuardadoCompleto(this, new ArgumentosEventos.Class1.GuardadoCompletadoEventArgs() { Completo = true });
                    }
                }
            }
        }
    }
}