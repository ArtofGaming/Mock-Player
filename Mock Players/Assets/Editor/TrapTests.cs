using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using NSubstitute;

public class TrapTests
{
    [Test]
    public void PlayerEnteringTrapReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover1 player = Substitute.For<ICharacterMover1>();
        player.IsPlayer.Returns(true);
        trap.HandleCharacterEntered(player, TrapType.Player);
        Assert.AreEqual(-1, player.health);
    }

    [Test]
    public void NpcEnteringTrapReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover1 player = Substitute.For<ICharacterMover1>();
        trap.HandleCharacterEntered(player, TrapType.Npc);
        Assert.AreEqual(-1, player.health);
    }
}
