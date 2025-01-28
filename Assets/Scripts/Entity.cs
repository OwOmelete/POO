using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected int pv;
    
    // colisions
    private void OnTriggerEnter2D(Collider2D other)
    {
        var collectible = other.GetComponent<Collectible>();
            
        if (collectible != null)
        {
            CollisionCollectible(collectible);
        }
            
        var npc = other.GetComponent<NPC>();
            
        if (npc != null)
        {
            CollisionNpc(npc);
        }
    }

    protected virtual void CollisionCollectible(Collectible collectible)
    {
        Debug.Log($"collision with collectible {collectible.name}");
    }

    protected virtual void CollisionNpc(NPC npc)
    {
        Debug.Log($"collision with npc {npc.name}");
    }

    public virtual string Collided(Collider2D other)
    {
        return other.tag;
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }

    public virtual void ChangePv(int dmg)
    {
        pv -= dmg;
        if (pv <= 0)
        {
            Die();
        }
    }
}