using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : NPC
{
    [SerializeField] private float speed = 0.1f;
    private bool rightMovement;
        
    protected override void UpdateMovement()
    {
        base.UpdateMovement();
        transform.position += new Vector3(rightMovement ? speed : -speed, 0, 0);
    }

    protected override void CollisionCollectible(Collectible collectible)
    {
        base.CollisionCollectible(collectible);
        rightMovement = !rightMovement;
    }
}