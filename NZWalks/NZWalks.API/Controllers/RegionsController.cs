using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Wellington",
                    Code="WLG",
                    Area=227755,
                    Lat=-1.8822,
                    Long=299.88,
                    Population=50000,
                   
                },
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Auckland",
                    Code="Auck",
                    Area=227755,
                    Lat=-1.8822,
                    Long=299.88,
                    Population=50000,
                }
            };
            return Ok(regions);
        }
    }
}
