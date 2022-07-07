using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //Mesaj ve Datayı verir
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        //Sadece datayı verir
        public SuccessDataResult(T data):base(data,true)
        {

        }
        //Sadece mesaj verir
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //Hiç bir şey vermez
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
