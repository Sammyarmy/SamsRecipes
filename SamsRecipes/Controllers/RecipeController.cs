using Microsoft.AspNetCore.Mvc;
using SamsRecipes.Services;

namespace SamsRecipes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly ILogger<RecipesController> _logger;
        private readonly IGetRecipes _getRecipes;

        public RecipesController(ILogger<RecipesController> logger,
                IGetRecipes getRecipes)
        {
            _logger = logger;
            _getRecipes = getRecipes;
        }

        [HttpGet(Name = "Recipes")]
        public IEnumerable<Recipe> Get()
        {
            return _getRecipes.Get();
        }
    }
}