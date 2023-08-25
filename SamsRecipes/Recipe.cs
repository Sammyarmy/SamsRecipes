namespace SamsRecipes
{
    public class Recipe
    {
        public Dictionary<string, string> Ingredients { get; set; }
        
        public List<string> Steps { get; set; }

        public string? Title { get; set; }

    }
}