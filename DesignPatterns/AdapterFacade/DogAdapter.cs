using DesignPatterns.AdapterFacade.Interfaces;

namespace DesignPatterns.AdapterFacade
{
    public class DogAdapter : Cat
    {
        Dog dog;
        public DogAdapter(Dog dog)
        {
            this.dog = dog;
        }

        public void Meow()
        {
            dog.Bark();
        }

        public void Run()
        {
            dog.Run();
        }
    }
}
