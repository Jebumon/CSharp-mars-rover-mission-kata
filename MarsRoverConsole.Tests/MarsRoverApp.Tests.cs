namespace MarsRoverConsole.Tests;
using FluentAssertions;
using MarsRoverConsole.MarsMissionApp;

public class MarsRoverAppTests
{
    private MarsMissionAppManager MarsRoverApp;

    [SetUp]
    public void Setup()
    {
        MarsRoverApp = new MarsMissionAppManager(5,5);
    }

    [Test]
    public void Decode_Command_N_LL_should_S()
    {
        MarsRoverApp.MarsManager(1,1,"N","LL").Should().Be("1 1 S");
    }

    [Test]
    public void Decode_Command_N_RR_should_S()
    {
        MarsRoverApp.MarsManager(3,3,"N","MRMR").Should().Be("4 4 S");
    }

    [Test]
    public void DDecode_Command_00N_MMRMMLLR_should_22W()
    {
        MarsRoverApp.MarsManager(0,0,"N","MMRMMLLR").Should().Be("2 2 N");
    }

    [Test]
    public void Decode_Command_11E_LL_should_11W()
    {
        MarsRoverApp.MarsManager(1,1,"E","LL").Should().Be("1 1 W");
    }

    [Test]
    public void Decode_Command_22E_RR_should_22W()
    {
        MarsRoverApp.MarsManager(2,2,"E","RR").Should().Be("2 2 W");
    }

    [Test]
    public void Decode_Command_55R_RR_should_ArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => MarsRoverApp.MarsManager(5,5,"R", "RR"));
        Assert.That(ex.Message, Is.EqualTo("Please enter a valid direction"));
    }

    [Test]
    public void Decode_Command_55N_RQQ_should_ArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => MarsRoverApp.MarsManager(5,5,"N", "RQQ"));
        Assert.That(ex.Message, Is.EqualTo("Please enter valid command"));
    }

    [Test]
    public void Decode_Command_10_10_N_RQQ_should_ArgumentException_Rover_Outside()
    {
        var ex = Assert.Throws<ArgumentException>(() => MarsRoverApp.MarsManager(10, 10, "N", "MMMRMM"));
        Assert.That(ex.Message, Is.EqualTo("Can't place rover outside the Plateau"));
    }
}