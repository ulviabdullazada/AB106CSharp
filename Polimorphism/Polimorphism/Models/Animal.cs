namespace Polimorphism.Models
{
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();
        public override string ToString()
        {
            return $"{{Name : {Name}}}";
        }
    }
}
