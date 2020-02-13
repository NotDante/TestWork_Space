using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    public GameObject Explosion;

    void OnCollisionEnter2D (Collision2D collision)
    {
        GameObject GO = Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(GO, 0.08f);
    }
}
