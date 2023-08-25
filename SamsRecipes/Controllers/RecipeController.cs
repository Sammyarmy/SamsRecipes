using Microsoft.AspNetCore.Mvc;
using SamsRecipes.Services;
using System.Text.Json;

namespace SamsRecipes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {

        private readonly ILogger<RecipesController> _logger;
        private readonly IExtractFromFolder _extractFromFolder;

        public RecipesController(ILogger<RecipesController> logger, IExtractFromFolder extractFromFolder)
        {
            _logger = logger;
            _extractFromFolder = extractFromFolder;
        }

        [HttpGet(Name = "Recipes")]
        public IEnumerable<Recipe> Get()
        {
            var recipes = new List<Recipe>();
            var jsonRecipe = _extractFromFolder.Extract("");

                recipes.Add(JsonSerializer.Deserialize<Recipe>(jsonRecipe));
            

            return recipes;
        }
    }
}