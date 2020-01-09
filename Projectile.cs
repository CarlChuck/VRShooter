using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Projectile movement
    private Vector3 spawnPosition;
    public Vector3 direction;
    public float range;
    public int speed;

    //Required Extras
    public AudioClip attackSound;
    public AudioSource soundSource;

    private void Start()
    {
        if (soundSource != null && attackSound != null)
        {
            soundSource.PlayOneShot(attackSound, 1f);
        }
        spawnPosition = transform.position;
    }

    private void Update()
    {
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + direction * Time.deltaTime * speed);
        }
        if (Vector3.Distance(spawnPosition, transform.position) >= range)
        {
            EndProjectile();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.GetComponent<StatBlock>())
        {
            StatBlock target = collision.transform.GetComponent<StatBlock>();
            target.TakeDamage(); 
            EndProjectile();
        }
    }

    private void EndProjectile()
    {
        Destroy(gameObject);
    }
}
