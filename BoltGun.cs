using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltGun : HeldItem
{
    public Projectile boltGunBullet;
    public Transform emitter;
    public AudioClip attackSound;
    public AudioSource source;

    public GameObject gunFlash;

    public override void OnTriggerPress()
    {
        base.OnTriggerPress();
        if (timer < 0)
        {
            FireBullet();
            ActivateFlash();
            timer = coolDownOnTrigger;
        }
    }

    public override void LeftHandPickup()
    {
        base.LeftHandPickup();

    }

    public override void LeftHandDrop()
    {
        base.LeftHandDrop();

    }

    private void FireBullet()
    {
        Projectile projectileInstance = Instantiate(boltGunBullet, emitter.position, emitter.rotation);

        projectileInstance.attackSound = attackSound;
        projectileInstance.soundSource = source;
        projectileInstance.direction = emitter.forward;
    }

    private void ActivateFlash()
    {
        StartCoroutine(FlashDelay());
    }

    IEnumerator FlashDelay()
    {
        gunFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        gunFlash.SetActive(false);
    }
}
