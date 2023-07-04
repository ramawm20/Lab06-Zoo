using System.Xml.Linq;
using Zoo;
using Zoo.Interface;

namespace TestZoo
{
    public class UnitTest1
    {
       
        [Fact]
        public void TestCats() 
        {
            //Arrange
            Cats cat = new Cats("LULU", 9);

            //Assert
            Assert.Equal("LULU", cat.Name);
            Assert.Equal(9, cat.age);

        }
        [Fact]
        public void TestLions()
        {
            //Arrange
            Lions lion = new Lions("Semon", 3);
         
            //Assert
            Assert.Equal("Semon", lion.Name);
            Assert.Equal(3, lion.age);
            Assert.Equal($"Semon is a Lion it's from Mammals", lion.Type());

        }
        [Fact]
        public void TestOwl() 
        {
            //Arrange
            Owl owl1 = new Owl("Lumi", 8);

            //Assert
            Assert.Equal("Lumi", owl1.Name);
            Assert.Equal (8, owl1.age);
            Assert.Equal($"{owl1.Name} Sound is Hoots!",owl1.Sound());


        }
        [Fact]
        public void TestTurtules()
        {
            //Arrange
            Turtules turtule1 = new Turtules("Speedy", 3);

            //Assert
            Assert.Equal("Speedy", turtule1.Name);
            Assert.Equal(3, turtule1.age);
            Assert.Equal($"{turtule1.Name} sound is Hissing!", turtule1.Sound());


        }
        [Fact]
        public void TestPenguins()
        {
            //Arrange
            Penguin p1 = new Penguin("Hops", 3);

            //Assert
            Assert.Equal("Hops", p1.Name);
            Assert.Equal(3, p1.age);
        }
        [Fact]
        public void TestImplementingInteface()
        {
            // Arrange
            Cats cat = new Cats("Lulu",8);
            Owl owl = new Owl("koke", 3);

            // Act & Assert
            Assert.True(cat is IBirth);
            Assert.True(owl is IFly&& owl is ILayEggs);
            Assert.False(owl is IBirth);

        }
        [Fact]
        public void TestInheritance()
        {
            Cats cat = new Cats("Lulu", 8);

            Assert.Equal($"{cat.Name} sound is Meow!", cat.Sound());
            Assert.Equal("The animal is sleeping", cat.sleep());

        }
        [Fact]
        public void TestPolymorphism()
        {
            Lions lion1 = new Lions("simba", 2);

            //Test Overridden
            Assert.Equal($"{lion1.Name} sound is Roar!", lion1.Sound());

            //Test Is an Animal
            Assert.True(lion1 is Animals);
        }

    }
}