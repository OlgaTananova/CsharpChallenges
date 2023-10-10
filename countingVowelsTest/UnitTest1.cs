using countingvowels;
namespace countingVowelsTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string text1 = "This is text";
        string text2 = "letter";
        Assert.That(countingvowels.MainClass.VowelCount(text1), Is.EqualTo(8));
        Assert.That(countingvowels.MainClass.VowelCount(text2), Is.EqualTo(4));
    }
    
    
}