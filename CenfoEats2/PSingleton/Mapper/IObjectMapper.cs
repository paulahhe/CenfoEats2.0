using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2.PSingleton.Mapper
{
    public interface IObjectMapper
    {
        //1 metodo para construir varios objetos de un tipo de Model
        List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);

        // Metodo para construir 1 objeto de un tipo de Model
        BaseEntity BuildObject(Dictionary<string, object> row);
    }
}
