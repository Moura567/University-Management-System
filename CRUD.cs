using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal interface CRUD<T>
    {
        int Add(T obj, Context context)
        { return 4; }
         int update(T obj,Context context)
        { return 5; }
        int Delete(T obj,Context context)
        { return 4; }

    }
}
