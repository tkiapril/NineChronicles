using Libplanet.Action;

namespace Tests.EditMode
{
    public class Random : System.Random, IRandom
    {
        public Random(int seed = int.MaxValue) : base(seed)
        {
        }
    }
}
