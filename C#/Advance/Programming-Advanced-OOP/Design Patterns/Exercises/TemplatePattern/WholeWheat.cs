namespace TemplatePattern
{
    public class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingrediants for Whole Wheat Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }
    }
}