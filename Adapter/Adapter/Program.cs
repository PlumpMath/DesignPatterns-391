using Adapter.Human;
using Adapter.Monkey;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman human1 = new Man();
            IHuman human2 = new Woman();

            IMonkey monkey1 = new Baboon();
            IMonkey monkey2 = new Chimpanzee();
            IMonkey monkey3 = new Gorilla();
            IMonkey humanMonkey1 = new HumanAdapter(human1);
            IMonkey humanMonkey2 = new HumanAdapter(human2);

            monkey1.Screech();
            monkey2.Screech();
            monkey3.Screech();
            humanMonkey1.Screech();
            humanMonkey2.Screech();
        }
    }
}
