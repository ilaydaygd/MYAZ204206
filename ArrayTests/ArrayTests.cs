namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]

        public void Array_Count_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("İlayda");
            array.Add("Alp");
            array.Add("Can");


            //Act
            int count = array.Count;

            //Assertion
            Assert.Equal(3, count);
            Assert.Equal(4, array.Capacity);
        }
        [Fact]

        public void Array_Add_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("İlayda");
            array.Add("Alp");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");



            //Act
            int count = array.Count;

            //Assertion
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);

        }




    }
}