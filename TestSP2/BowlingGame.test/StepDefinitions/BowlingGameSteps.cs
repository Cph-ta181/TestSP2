using BowlingGame;

namespace StringUtility.test.StepDefinitions
{
    [Binding]
    public sealed class BowlingGameSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public BowlingGameSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("A fresh game of bowling")]
        public void GivenFreshGame()
        {
            _scenarioContext["game"] = new Game();
        }

        [When("Player has not yet rolled")]
        public void WhenNoRolls()
        {
            
        }

        [When("Player rolls 20 1's")]
        public void WhenGameOfOnes()
        {
            Game game = (Game)_scenarioContext["game"];
            for (int i = 0; i < 20; i++)
            {
                game.roll(1);
            }
        }

        [When("Player rolls (.*) (.*) (.*)")]
        public void WhenGettingASpare(int one, int two, int three)
        {
            Game game = (Game)_scenarioContext["game"];
            game.roll(one);
            game.roll(two);
            game.roll(three);
        }

        [When("Player rolls strikes only")]
        public void WhenGettingStrikesOnly()
        {
            Game game = (Game)_scenarioContext["game"];
            for (int i = 0; i < 12; i++)
            {
                game.roll(10);
            }
        }

        [Then("The score is (.*)")]
        public void ThenScoreIs(int score)
        {
            Game game = (Game)_scenarioContext["game"];
            Assert.AreEqual(score, game.score());
        }

    }
}
