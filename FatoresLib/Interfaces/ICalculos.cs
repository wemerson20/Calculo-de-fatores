using System.Collections.Generic;

namespace FatoresLib.Interfaces
{
    public interface ICalculos
    {
        bool EhPrimo(int numero);

        int RetornaFatores(int numero, List<int> fatores);
    }
}