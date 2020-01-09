using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float time;

    private void Awake()
    {
        StartCoroutine(selfDestruct(time));
    }

    IEnumerator selfDestruct(float aTime)
    {
        yield return new WaitForSeconds(aTime);
        Destroy(gameObject);
    }

}
