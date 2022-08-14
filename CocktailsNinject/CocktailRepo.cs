using CocktailsNinject.Models;
using CocktailsNinject.Repozitorys.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsNinject
{
    public class CocktailRepo
    {
        private readonly IRepozitory _repozitory;

        public CocktailRepo(IRepozitory repozitory)
        {
            _repozitory = repozitory;
        }   

        public void Disply()
        {
            for (int i = 0; i < _repozitory.GetNameCocktails().Count; i++)
            {
                Console.WriteLine($" Name: {_repozitory.GetNameCocktails()[i]}\n " +
                    $"Information: {_repozitory.GetInformationCocktails()[i]}");
                Console.WriteLine("\n|-----------------------------------------------------------|\n");
            }
        }
        public void Save()
        {
            _repozitory.SevaFile();
        }
    }
}
