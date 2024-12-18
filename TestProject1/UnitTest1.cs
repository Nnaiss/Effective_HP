using project;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            double hp = 1000;
            double def = 100;
            int lvl = 95;
            double temp=Srez(hp, def, lvl);
            Math.Round(temp,2);   
            static double Srez(double hp, double def, int lvl)
            {
                double srez;
                srez = 1 - (def / (def + 200 + 10 * lvl));
                return srez;
            }

            Assert.AreEqual(temp,0.92); 

        }
        
    }
}