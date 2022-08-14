using CocktailsNinject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsNinject.Repozitorys.Interface
{
    public interface IRepozitory
    {
        List<string> GetNameCocktails();
        List<string> GetInformationCocktails();
        void SevaFile();
    }
}
