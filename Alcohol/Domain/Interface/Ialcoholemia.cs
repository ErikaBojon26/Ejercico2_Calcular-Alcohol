using System;
namespace Alcohol.Domain.Interface
{
        public interface Ialcoholemia
    {
        void TotaldeAlcohol(string  _Bebida, int cantidadAlcohol);
        void Pesoper(int pesopersona);
        String Result();
    }
}