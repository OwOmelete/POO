using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC : Entity
{
    private void Update()
    {
        UpdateBehavior();
        UpdateMovement();
    }

    public virtual void UpdateBehavior()
    {
            
    }
        
    protected virtual void UpdateMovement()
    {
            
    }
        
    protected override void CollisionCollectible(Collectible collectible)
    {
        base.CollisionCollectible(collectible);
        Debug.Log("npc collision collectible");
    }
}