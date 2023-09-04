using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject FirePos;
    public AudioSource AudioShoot;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }
    void Shot()
    {
        GameObject �nstantinateObject = BulletPool.instance.GetBullet();
        if (�nstantinateObject != null)
        {
            �nstantinateObject.transform.forward = FirePos.transform.forward;
            �nstantinateObject.transform.position = FirePos.transform.position;
            �nstantinateObject.SetActive(true);
            AudioShoot.PlayOneShot(AudioShoot.clip);
        }
    }
}
