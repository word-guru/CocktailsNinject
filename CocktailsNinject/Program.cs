using CocktailsNinject.Repozitorys;
using CocktailsNinject.Repozitorys.Interface;
using Ninject;

using (IKernel kernel = new StandardKernel())
{
    kernel.Bind<IRepozitory>().To<Repozitory>();
    var cocktail = kernel.Get<IRepozitory>();

    for(int i =0; i < cocktail.GetNameCocktails().Count; i++)
    {
        Console.WriteLine($"Name: {cocktail.GetNameCocktails()[i]}\n " +
            $"Information: {cocktail.GetInformationCocktails()[i]}");
        Console.WriteLine("|-----------------------------------------------------------|");
    }
    cocktail.SevaFile();
}
