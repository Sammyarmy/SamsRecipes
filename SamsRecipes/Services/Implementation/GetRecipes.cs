using System.Text.Json;

namespace SamsRecipes.Services.Implementation
{
    public class GetRecipes : IGetRecipes
    {
        private readonly IExtract _extract;

        public GetRecipes(IExtract extractFromFolder)
        {
            _extract = extractFromFolder;
        }

        public List<Recipe> Get()
        {
            var filesInDirectory = Directory.GetFiles(@"./Recipes");

            var recipes = new List<Recipe>();

            foreach (var recipePath in filesInDirectory)
            {
                var jsonRecipe = _extract.ExtractFile(recipePath);
                recipes.Add(JsonSerializer.Deserialize<Recipe>(jsonRecipe));
            }

            return recipes;
        }
    }
}