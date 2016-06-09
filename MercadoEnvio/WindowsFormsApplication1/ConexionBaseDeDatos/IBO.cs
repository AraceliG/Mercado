using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MercadoEnvioFRBA.ConexionBaseDeDatos
{
    public interface IBO<T> where T: new()
    {
    
        T setData(DataRow dr);
    }
}
