using Microsoft.AspNetCore.Components;

namespace DrinkWater.Components.ComponentModel
{
    public class ImageListBase : ComponentBase
    {
        public IEnumerable<ImageListBase> Images { get; set; }
    }
}
