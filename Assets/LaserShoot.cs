using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public Transform FirePoint;
    public float DMG = 20;
    public float pause = 2;
    public LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Boom", 0, pause);
    }

   IEnumerator Shoot()
    {
        CycleMove moves = GetComponent<CycleMove>();
        moves.enabled = false;
        yield return new WaitForSeconds(3);
        Debug.Log("Shot");

        line.enabled = true;
        OnTriggerDamage OTD = line.GetComponent<OnTriggerDamage>();
        OTD.damage = true;
        yield return new WaitForSeconds(0.2f);
        line.enabled = false;
        OTD.damage = false;
        moves.enabled = true;
    }

    void Boom()
    {
       StartCoroutine(Shoot());
    }
}
