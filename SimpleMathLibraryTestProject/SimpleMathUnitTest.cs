using SimpleMathLibrary;

namespace SimpleMathLibraryTestProject
{
    [TestClass] // test suite
    public class SimpleMathUnitTest
    { 
        [TestMethod] //test case

        //feature_Circumstance_ExpResult

        public void Sum_WithValidInput_ShouldGiveValidResult()
        {
            //Write Test Code

            //AAA Approache
            // A - Arrange
            int fno = 10;
            int sno = 20;
            int expected = 20;

            SimpleMath tsrget = new SimpleMath();

            // A - Act
            int actual = tsrget.Sum(fno, sno);

            // A - Assert

            Assert.AreEqual(expected, actual);


        }
    

    [TestMethod]
    [ExpectedException(typeof(InvalidEvenNumberException))]
    public void Sum_WithOddNumbers_ThrowsExp()
    {
        SimpleMath target = new SimpleMath();
        target.Sum(1, 1);
    }

        [TestMethod]
        [ExpectedException(typeof(InvalidPositiveNonZeroNumberException))]

        public void Sum_WithZeroOrNegative_ThrowsExp()
        {
            SimpleMath sm = new SimpleMath();
            sm.Sum(1, 1);
        }



    }
}