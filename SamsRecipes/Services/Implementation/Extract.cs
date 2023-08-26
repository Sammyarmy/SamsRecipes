namespace SamsRecipes.Services.Implementation
{
    public class Extract : IExtract
    {
        public string ExtractFile(string fileName)
        {
            return File.ReadAllText($@"./{fileName}");
        }
    }
}