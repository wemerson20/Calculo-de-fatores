using System;
using System.Collections.Generic;
using FatoresLib.Interfaces;

namespace fatoreslib
{
    public class FatoresService
    {
        private readonly ICalculos _calculos;

        FatoresService(ICalculos calculos){
            _calculos = calculos;
        }

        public List<int> RetornaFatoresNumero(int numero)
        {
            List<int> fatores = new List<int>();
            _calculos.RetornaFatores(numero, fatores);
            return fatores;
        } 
    }
}
