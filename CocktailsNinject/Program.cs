using CocktailsNinject;
using CocktailsNinject.Repozitorys;
using CocktailsNinject.Repozitorys.Interface;
using Ninject;

using (IKernel kernel = new StandardKernel())
{
    kernel.Bind<IRepozitory>().To<Repozitory>();
    var cocktail = kernel.Get<CocktailRepo>();

    cocktail.Disply();
    cocktail.Save();
   
}
