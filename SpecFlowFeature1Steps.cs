using System;
using TechTalk.SpecFlow;
using Xunit;
using System.Linq;

namespace ExamRQE
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number;
        String choose;
        [Given(@"the number is pi")]
        public void GivenTheNumberIsPi()
        {
            number = Math.PI;
                
        }
        
        [Given(@"I choose sinus")]
        public void GivenIChooseSinus()
        {
            choose = "sin";
        }
        
        [Given(@"I choose cosinus")]
        public void GivenIChooseCosinus()
        {
            choose = "cos";
        }
        
        [Given(@"I choose tangens")]
        public void GivenIChooseTangens()
        {
            choose = "tan";
        }
        
        [When(@"the calculator calculates")]
        public void WhenTheCalculatorCalculates()
        {
           switch(choose)
            {
               case "sin":
                    Assert.Equal(Math.Sin(number), 0, 5);   
                break;
                case "cos":
                    Assert.Equal(Math.Sin(number), -1, 5);
                    break;
                case "tan";
                    Assert.Equal(Math.Sin(number), 0, 5);
                    break;
                default:
                   break;
                
            }
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
//asd