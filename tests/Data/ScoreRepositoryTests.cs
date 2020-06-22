using Xunit;
using openrmf_scoring_api.Data;
using openrmf_scoring_api.Models;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using System;

namespace tests.Data
{
    public class ScoreRepositoryTests
    {
        private readonly ScoreRepository _scoreRepository;

        public ScoreRepositoryTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmfscore:openrmf1234!@localhost/openrmfscore?authSource=admin";
            settings.Database = "openrmfscore";

            _scoreRepository = new ScoreRepository(Options.Create<Settings>(settings));
        }

        [Fact]
        public async Task Test_ScoreRepositoryIsValid()
        {
            // Testing
            /*
            await _scoreRepository.GetAllScores();
            await _scoreRepository.GetScore("id");
            await _scoreRepository.GetScorebyArtifact("id");
            await _scoreRepository.GetScoresbySystem("id");
            await _scoreRepository.GetScore("test", DateTime.Now, 1024);
            */

            Assert.True(_scoreRepository.HealthStatus());
        }
    }
}
