using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using NSubstitute;

public class TrapTests
{
    [Test]
    public void PlayerEnter_PlayerTargetedTrap_ReduceHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover cm = Substitute.For<ICharacterMover>();
        cm.IsPlayer.Returns(true);

       // trap.HandleCharacterEntered(cm, TrapTargetType.Player);

        Assert.AreEqual(-1, cm.Health);
    }

    [Test]
    public void NPCEnter_NPCTargetedTrap_ReduceHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover cm = Substitute.For<ICharacterMover>();
        trap.HandleCharacterEntered(cm, TrapTargetType.NPC);
        Assert.AreEqual(-1, cm.Health);
    }
}
