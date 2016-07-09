using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvioFRBA.Modelo
{
    
    public abstract class CambioEstado
    {
          public static Estado getEstado(string codEstado)
          {
              Estado unEstado = new Pausada();

              if (codEstado.Equals("A"))
                  unEstado = new Activa();
              if (codEstado.Equals("B"))
                  unEstado = new Borrador();
              if (codEstado.Equals("F"))
                  unEstado = new Finalizada();
         
              return unEstado;
          }
    }

    public abstract class Estado
    {
        public List<string> cambiosEstadosPermitidos { get; set; }
        public string cod_estadoPubli { get; set; }
        public string descripcion { get; set; }

        public Estado() 
        {
            this.cambiosEstadosPermitidos = new List<string>();
        }


        internal static List<Estado> getEstados()
        {
            List<Estado> lista = new List<Estado>();
            lista.Add(new Borrador());
            lista.Add(new Activa());
            lista.Add(new Pausada());
            lista.Add(new Finalizada());

            return lista;
        }

        internal List<Estado> nuevosEstadosPermitidos()
        {
            List<Estado> lista = new List<Estado>();
            lista.Add(CambioEstado.getEstado(this.cod_estadoPubli));
            this.cambiosEstadosPermitidos.ForEach( e => lista.Add(CambioEstado.getEstado(e)));
            return lista;
        }
    }

    public class Borrador : Estado
    {
        public Borrador() : base()
        {
            this.cod_estadoPubli = "B";
            this.descripcion = "Borrador";
            this.cambiosEstadosPermitidos.Add("A");
        }
    }

    public class Activa : Estado
    {
        public Activa() : base()
        {
            this.cod_estadoPubli = "A";
            this.descripcion = "Activa";
            this.cambiosEstadosPermitidos.Add("P");
            this.cambiosEstadosPermitidos.Add("F");
        }
    }

    public class Pausada : Estado
    {
        public Pausada() : base()
        {
            this.cod_estadoPubli = "P";
            this.descripcion = "Pausada";
            this.cambiosEstadosPermitidos.Add("A");
        }
    }

    public class Finalizada : Estado
    {
        public Finalizada() : base()
        {
           this.cod_estadoPubli = "F";
           this.descripcion = "Finalizada";
        }
    }
}
