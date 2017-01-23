using Adapter.Human;
using Adapter.Monkey;

namespace Adapter
{
    public class HumanAdapter : IMonkey
    {
        private readonly IHuman _human;

        public HumanAdapter(IHuman human)
        {
            _human = human;
        }

        public void Screech()
        {
            _human.Speak();
        }
    }
}