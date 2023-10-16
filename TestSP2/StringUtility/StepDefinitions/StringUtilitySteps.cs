namespace StringUtility.test.StepDefinitions
{
    [Binding]
    public sealed class StringUtilitySteps
    {
        StringUtility stringUtil = new StringUtility();

        private readonly ScenarioContext _scenarioContext;

        public StringUtilitySteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("The input string (.*)")]
        public void GivenInputIsAString(string input)
        {
            _scenarioContext["input"] = input;
        }

        [When("The string is reversed")]
        public void WhenStringIsReversed()
        {
            _scenarioContext["reversed"] = stringUtil.reverse((string)_scenarioContext["input"]);
        }

        [Then("The contents of the input string is reversed")]
        public void ThenTheInputStringIsReversed()
        {
            char[] charArr = _scenarioContext["input"].ToString().ToCharArray();
            Array.Reverse(charArr);
            string input = new string(charArr);
            string reversed = (string)_scenarioContext["reversed"];
            Assert.AreEqual(input, reversed);
        }

        [When("The string is capitalized")]
        public void WhenStringIsCapitalized()
        {
            _scenarioContext["capitalized"] = stringUtil.capitalize((string)_scenarioContext["input"]);
        }

        [Then("The contents of the input string is capitalized")]
        public void ThenTheInputStringIsCapitalized()
        {
            Assert.AreEqual(_scenarioContext["input"].ToString().ToUpper(), _scenarioContext["capitalized"]);
        }

        [When("The string is lowercased")]
        public void WhenStringIsLowercased()
        {
            _scenarioContext["lower"] = stringUtil.lowercase((string)_scenarioContext["input"]);
        }

        [Then("The contents of the input string is lowercased")]
        public void ThenThInputStringShouldBeLowercase()
        {
            Assert.AreEqual(_scenarioContext["input"].ToString().ToLower(), _scenarioContext["lower"]);
        }
    }
}
