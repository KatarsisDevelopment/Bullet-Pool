using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Gun Gun;
    // Start is called before the first frame update
    void Start()
    {
        Gun = FindObjectOfType<Gun>();
    }
    void Update()
    {
        transform.position += Gun.FirePos.transform.forward * 10 * Time.deltaTime;
        if (Vector3.Distance(transform.position,Gun.transform.position) > 5f)
        {
            gameObject.SetActive(false);
        }
    }
}
