using System.ComponentModel.DataAnnotations;

namespace DrinkWater.Components.ComponentModel
{
    public class WaterIntakeGoal
    {
        [Required]
        [Range(1, 20, ErrorMessage = "Goal should be between 1 and 20 glasses.")]
        public int Goal { get; set; } = 8; // Default value
    }
}
