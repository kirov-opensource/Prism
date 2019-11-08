using Kirov.Prism.Abstrictions;
using Xunit;

namespace Kirov.Prism.Dapper.MySQL.Test
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            var queryableProvider = new QueryProvider(null);
            var queryable = new Queryable<int>(queryableProvider);
            //queryable.Where(x => x == 1024).Where(c => c == 999).Sum();
        }
    }
}
