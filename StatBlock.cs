using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StatBlock : MonoBehaviour
{

    public virtual void Start()
    {

    }
    public virtual void Update()
    {

    }


    //Apply damage calculation
    public virtual void TakeDamage()
    {
        OnDeath();
    }


    public virtual void OnDeath()
    {
        //To Override
    }

}
