using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDamage : MonoBehaviour
{
    public float DMG = 50;
    public bool damage = false;
    

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (!damage)
        {
            Debug.Log("DAMAGE ON");
            Health hp = collision.gameObject.GetComponent<Health>();
            if (hp != null)
            {
                hp.HP -= DMG;
            }
        }
        damage = false;
    }
}
