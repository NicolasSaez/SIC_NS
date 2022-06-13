using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SitiosController
    {
        //esta es la entidad
        SIC_NS_LOCALEntities context = new SIC_NS_LOCALEntities();

        //GET
        public List<Sitio> GetAllSitosActive(bool p_Activo = true)
        {
            return context.Sitio.Where(x => x.Activo == true).ToList();
        }

        //SET
    }
}
