using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IRuselt implement ettik çünkü mesajda dönüdrmek isteyebiliriz kimee neeee
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
