using prjKpopIndexers;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestName()
        {
            Groups group = new Groups("ATEEZ", "Male",8,222, "BOUNCY (K-HOT CHILI PEPPERS)");
            Assert.AreEqual(group["name"], "ATEEZ");
        }

        [TestMethod]
        public void TestGender()
        {
            Groups group = new Groups("IVE", "Female",6,39,"I AM");
            Assert.AreEqual(group["gender"], "Female");
        }



        [TestMethod]
        public void TestNumberOfMembers()
        {
            Groups group = new Groups("Stray Kids", "Male", 8, 281, "God's Menue");
            Assert.AreEqual(group[3], 7);
        }


        [TestMethod]
        public void TestNumberOfSongs()
        {
            Groups group = new Groups("Blackpink", "Female", 4, 33, "Ice Cream");
            Assert.AreEqual(group[4], 33);
        }

        [TestMethod]
        public void TestPopularSong()
        {
            Groups group = new Groups("ATEEZ", "Male", 8, 222, "BOUNCY (K-HOT CHILI PEPPERS)");
            Assert.AreEqual(group["popularSong"], "BOUNCY (K-HOT CHILI PEPPERS)");
        }

    }
}

