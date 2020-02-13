using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStart1 : MonoBehaviour
{
    public float StartSpeed;

    public bool move = true;

    private void Update()
    {
        if (move)
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 pos = transform.position;
        pos.y -= StartSpeed * Time.deltaTime;
        transform.position = pos;
    }

}
