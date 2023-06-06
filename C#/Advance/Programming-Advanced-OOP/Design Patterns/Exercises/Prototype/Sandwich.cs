namespace Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngridients();
            
            Console.WriteLine("Cloning sandwich with ingridients: {0}", ingredientList);
            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngridients()
        {
            return $"{bread}, {meat}, {cheese}, {veggies}";
        }
    }
}