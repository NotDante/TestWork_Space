using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnShip : MonoBehaviour
{
    public int Points;
    public float HP = 100f;
    public GameObject Explosion;
    public GameObject BigExplosion;

    private void Update()
    {
        if (HP <= 0)
        {
            if (HP <= 0)
            {
                ScoreCounter.StartScore += (int)Points;
                Destroyer();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("PlayerShot"))
        {
            Damage dmg = collision.GetComponent<Damage>();
            HP -= dmg.Dmg;
            GameObject GO = Instantiate(Explosion, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(GO, 0.08f);
        }
    }

    void Destroyer()
    {
        GameObject GO = Instantiate(BigExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(GO, 0.08f);
    }
}
