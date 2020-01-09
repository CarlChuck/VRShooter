using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : StatBlock
{
    [SerializeField] private Fracture fracture;
    [SerializeField] private BoxCollider bCollider;

    public override void Start()
    {
        base.Start();
    }

    public override void TakeDamage()
    {
        base.TakeDamage();
    }


    public override void OnDeath()
    {
        Destroy(bCollider);
        fracture.OnDestruction();
    }
}
