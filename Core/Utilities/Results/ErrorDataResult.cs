using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
            //Mesaj ve Datayı verir
            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }

            //Sadece datayı verir
            public ErrorDataResult(T data) : base(data, false)
            {

            }
            //Sadece mesaj verir
            public ErrorDataResult(string message) : base(default, false, message)
            {

            }
            //Hiç bir şey vermez
            public ErrorDataResult() : base(default, false)
            {

            }

    }
}
