using System;
using FatoresLib;

namespace FatoresApp
{
    private readonly ICalculos _calculos;
    public class FatoresApp
    {
        FatoresApp(ICalculos calculos)
        {
            this._calculos = calculos;
        }

        public int RetornaFatores(int numero, List<int> fatores)
        {          
            return this._calculos.RetornaFatores(numero,fatores);
        }
    }
}
