using System;
using Alcohol.Domain.Interface;

namespace Alcohol.Domain.entities
{
    public class Cantidad  : Ialcoholemia
    {
        private int _cantidadAlcohol;
        private int _Cantidadliquido;
        private int _pesopersona;
        private double _TotaldeAlcohol;
        private double _cantidad_directoSangre;
        private double etanol_en_sangre = 0.789;
        private double etanoensangre;
        private double volumenSangre;
        private double Alcohol_Sangre;
        private double _gradodeAlcohol;
        private string _Bebida;
        public void TotaldeAlcohol(string  Bebida, int cantidadAlcohol)
        {
            _cantidadAlcohol = cantidadAlcohol;
            _Bebida = Bebida.ToLower();
            switch (_Bebida)
            {
                    case "cerveza":
                    _Cantidadliquido = 330;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 5;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
                    case "vino": 
                    _Cantidadliquido = 100;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 12;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
                    case "cava": 
                    _Cantidadliquido = 100;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 12;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
                    case "vermu":
                    _Cantidadliquido = 70;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 17;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
                    case "licor":
                    _Cantidadliquido = 45;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 23;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
                    case "brandy":
                    _Cantidadliquido = 45;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 38;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
                    case "combinado":
                    _Cantidadliquido = 50;
                    _cantidadAlcohol = _cantidadAlcohol * _Cantidadliquido;
                    _gradodeAlcohol = 38;
                    _TotaldeAlcohol = _gradodeAlcohol / 100 * _cantidadAlcohol;
                    break;
        }
        }
        public void Pesoper(int pesopersona)
        {
           _pesopersona = pesopersona;
            _cantidad_directoSangre = 0.15 * _TotaldeAlcohol;
            etanoensangre = etanol_en_sangre * _cantidad_directoSangre;
            volumenSangre = 0.8 * _pesopersona;
            Alcohol_Sangre = etanoensangre / volumenSangre;
        
        }
        
        public string Result()
        {
                if (Alcohol_Sangre >  0.8)
                {
                    return $" Nivel de alcohol en la sangre: {Alcohol_Sangre}  Limite Alto, no es apto para manejar :(";
                }
                    return $" Nivel de alcohol en la sangre: {Alcohol_Sangre}  Limite Bajo es apto para manejar, que tenga un buen viaje :)";
               
        }
    }
}