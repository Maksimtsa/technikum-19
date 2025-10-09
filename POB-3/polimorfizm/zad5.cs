using System.Threading.Channels;

namespace zad4
{
    public interface IPlayable
    {
        void Play();
    }
    class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("gitara");
        }
    }
    class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("pianino");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var instruments = new List<IPlayable>
            {
                new Guitar(),
                new Piano()
            };

            foreach(var instr in instruments)
            {
                instr.Play();
            }
        }
    }
}
