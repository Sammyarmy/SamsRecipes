namespace SamsRecipes.Services
{
    public interface IGetRecipes
    {
        List<Recipe> Get();

        Recipe GetRecipe(string recipe);
    }
}