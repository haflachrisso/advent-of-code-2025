using ClassLibrary1;

namespace DialTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestCorrectRotationsCount()
    {
        var rotations = File.ReadAllLines("RotationFiles/rotationExample.txt").ToList();
        int totalRotations = SecretCodeCracker.RotationsCount(rotations);

        Assert.AreEqual(10, totalRotations);
    }

    [TestMethod]
    public void TestCorrectTimesDialPointsAtZero()
    {
        var rotations = File.ReadAllLines("RotationFiles/rotationExample.txt").ToList();
        int totalRotations = SecretCodeCracker.TimesDialPointsAtZero(rotations);

        Assert.AreEqual(3, totalRotations);
    }
}
