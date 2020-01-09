using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItem : MonoBehaviour
{
    public float coolDownOnTrigger;
    public float timer;

    public virtual void Update()
    {
        timer -= Time.deltaTime;
    }
    public virtual void OnTriggerPress() 
    { 

    }

    public virtual void LeftHandPickup()
    {

    }
    
    public virtual void LeftHandDrop()
    {

    }
}
