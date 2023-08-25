namespace SamsRecipes.Services.Implementation
{
    public class ExtractFromFolder : IExtractFromFolder
    {
        public string Extract(string filePath)
        {
            return File.ReadAllText(@"./Recipes/Bolognese.json");

        }
    }
}
