using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDTOPattern
{
    class ValidationManager
    {

        public  bool IsValid<T>(T entity)
        {
            bool result = false;
            Type type = entity.GetType();

            foreach (var item in type.GetProperties())
            {
                if (item.Name == "OrderID" && Convert.ToInt32(item.GetValue(entity)) != 0)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
