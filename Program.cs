//#:package Microsoft.Extensions.Configuration.Binder@9.0.10
#:package Microsoft.Extensions.Configuration.Binder@10.0.0-rc.1.25517.107

using Microsoft.Extensions.Configuration;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            var configuration = builder.Build();

            var settings1 = new Foo.Settings();
            configuration.Bind(settings1);

            var settings2 = new Bar.Settings();
            configuration.Bind(settings2);
        }
    }
}

namespace Foo
{
    public class Settings
    {
    }
}

namespace Bar
{
    public class Settings
    {
    }
}
