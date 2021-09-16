using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoTestNameScope.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoTestNameScope.App(), args);
            host.Run();
        }
    }
}
