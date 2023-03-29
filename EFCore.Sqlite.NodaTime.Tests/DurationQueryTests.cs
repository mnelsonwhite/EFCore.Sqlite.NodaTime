using System.Linq;
using NodaTime;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Sqlite
{
    public class DurationQueryTests : QueryTests<Duration>
    {
        public static readonly Duration Value = Duration.FromSeconds(1123456789);

        public DurationQueryTests() : base(x => x.Duration)
        {
        }

        [Fact]
        public void Roundtrip() => Assert.Equal(Value, Query.Single());
    }
}
