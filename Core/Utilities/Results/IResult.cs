using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel Voidler için başlangıç VOID ler için listeler için başka yapcaz
    public interface IResult
    {

        //İşlem Sonucu
        bool Success { get; }

        //Bilgilendirme
        string Message { get; }
    }
}
