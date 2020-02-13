using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.name.Contains("Enemy"))
        {
            EnemyStart1 ES = collision.GetComponent<EnemyStart1>();
            ES.move = false;
            CycleMove CM = collision.GetComponent<CycleMove>();
            CM.enabled = true;
            EnemyShooting EnS = collision.GetComponent<EnemyShooting>();
            if (EnS != null)
            {
                EnS.enabled = true;
            }
            LaserShoot las = collision.GetComponent<LaserShoot>();
            if (las != null)
            {
                las.enabled = true;
            }
        } 
    }
}
