namespace Guesstimate
{
    public class ProjectTaskMinMax
    {
        public decimal MinHours { get; set; }
        public decimal MaxHours { get; set; }

        public ProjectTaskMinMax(decimal minHours, decimal maxHours)
        {
            MinHours = minHours;
            MaxHours = maxHours;
        }
    }
}
