using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.Cheques;

namespace persistenciaArchivos.UNA.Cheques
{
    class ArchivoManager
    {
        private readonly List<Cheque> ChequesList = new List<Cheque>();
        public string CrearArchivo(string rutaBase) { 
            string path = $"{rutaBase}/{DateTime.Now.ToString()}.csv";

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Cheque cheque in ChequesList) 
                { 
                    var line =  $"{cheque.Nombre},{cheque.Numero},{cheque.Monto},{cheque.Descripcion}";
                    streamWriter.WriteLine(line);
                }
                    streamWriter.Flush();
                return path;
            }

        }
        public void LeerArchivo() {
        }
    }
}
