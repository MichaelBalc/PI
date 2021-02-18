using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Berechnungen
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double pi;
        double result;

        [Given(@"the number PI")]
        public void GivenTheNumberPI()
        {
            pi = (double)Math.PI;
        }
        
        [When(@"the function is Sinus")]
        public void WhenTheFunctionIsSinus()
        {
            result = (double)Math.Sin(pi);
        }
        
        [When(@"the function is Cosinus")]
        public void WhenTheFunctionIsCosinus()
        {
            result = (double)Math.Cos(pi);
        }
        
        [When(@"the function is Tangens")]
        public void WhenTheFunctionIsTangens()
        {
            result = (double)Math.Tan(pi);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            double expected = p0;
            double actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
