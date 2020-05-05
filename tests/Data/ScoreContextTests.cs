using Xunit;
using openrmf_scoring_api.Data;
using openrmf_scoring_api.Models;
using Microsoft.Extensions.Options;

namespace tests.Data
{
    public class ScoreContextTests
    {
        private readonly ScoreContext _scoreContext;

        public ScoreContextTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmfscore:openrmf1234!@localhost/openrmfscore?authSource=admin";
            settings.Database = "openrmfscore";

            _scoreContext = new ScoreContext(Options.Create<Settings>(settings));
        }

        [Fact]
        public void Test_ScoreContextIsValid()
        {
            // Testing
            Assert.False(_scoreContext == null);
            Assert.False(_scoreContext.Scores == null);
        }
    }
}
