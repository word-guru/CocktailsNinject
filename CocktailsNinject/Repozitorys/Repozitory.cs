using CocktailsNinject.Models;
using CocktailsNinject.Repozitorys.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CocktailsNinject.Repozitorys
{
    public class Repozitory : IRepozitory
    {
        public List<Cocktails> _cocktails { get; set; }

        public Repozitory()
        {
            _cocktails = new List<Cocktails>()
            {
                new Cocktails()
                {
                    Name = "Кровь палача",
                    Information = "пивной коктейль, приготовленный из джина, виски, рома, портвейна, бренди, стаута и шампанского."
                },
                 new Cocktails()
                {
                    Name = "Черный бархат",
                    Information = " пивной коктейль, приготовленный из сочетания крепкого пива (часто Гиннесса) и" +
                    " белого игристого вина (часто шампанского)."
                },
                  new Cocktails()
                {
                    Name = "Микелада",
                    Information = "мексиканский напиток, приготовленный из пива, сока лайма," +
                    " различных соусов (часто на основе чили), специй и перца чили." +
                    " Подается в охлажденном бокале с соленой каемочкой." +
                    " По всей Мексике существует множество разновидностей этого напитка."
                }


            };

        }

        public List<string> GetNameCocktails()
        {
            List<string> name = new List<string>();

            foreach (var cocktail in _cocktails)
            {
                name.Add(cocktail.Name);
            }
            return name;
        }

        public List<string> GetInformationCocktails()
        {
            List<string> info = new List<string>();

            foreach (var cocktail in _cocktails)
            {
                info.Add(cocktail.Information);
            }
            return info;
        }

        public void SevaFile()
        {
            string path = "CocktailsFile.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach(var cocktail in _cocktails)
                {
                    writer.WriteLine($"Name: {cocktail.Name} Information: {cocktail.Information}");
                }
               
            }
            Console.WriteLine("Запись в файл выполнена");
        }
    }
}
