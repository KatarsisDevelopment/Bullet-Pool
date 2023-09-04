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
        GameObject ýnstantinateObject = BulletPool.instance.GetBullet();
        if (ýnstantinateObject != null)
        {
            ýnstantinateObject.transform.forward = FirePos.transform.forward;
            ýnstantinateObject.transform.position = FirePos.transform.position;
            ýnstantinateObject.SetActive(true);
            AudioShoot.PlayOneShot(AudioShoot.clip);
        }
    }
}
