using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    [SerializeField]
    private TrapType trapType;
    private Trap trap;
    private void Awake()
    {
        trap = new Trap();
    }
    private void OnTriggerEnter(Collider other)
    {
        var characterMover = other.GetComponent<Player>();
        trap.HandleCharacterEntered(characterMover, trapType);
    }
}
public class Trap
{
    public void HandleCharacterEntered(ICharacterMover1 player, TrapType trapType)
    {
        if (player.IsPlayer)
        {
            if(trapType == TrapType.Player) 
            {
                player.health--;
            }           
        }
        else
        {
            if (trapType == TrapType.Npc)
            {
                player.health--;
            }
        }

    }

}

public enum TrapType { Player, Npc }
