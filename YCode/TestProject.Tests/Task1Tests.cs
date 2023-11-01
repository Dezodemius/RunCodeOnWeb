using NUnit.Framework;

namespace TestProject.Tests;

public class Tests
{
  [Test]
  public void Test1()
  {
    var task1 = new Task1();

    var actualResult = task1.GetZero();

    Assert.That(actualResult, Is.EqualTo(0));
  }
}