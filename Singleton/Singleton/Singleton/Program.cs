using System.Collections.Generic;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

            var tasks = new List<Task>();
            for (int i = 0; i < 50; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => boiler.Fill()));
                tasks.Add(Task.Factory.StartNew(() => boiler.Drain()));
                tasks.Add(Task.Factory.StartNew(() => boiler.Boil()));
            }
            Task.WaitAll(tasks.ToArray());
        }
    }
}
