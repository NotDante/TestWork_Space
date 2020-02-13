using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorDestoyer : MonoBehaviour
{
    private float MeteorWidth;
    private float yBound;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        MeteorWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x;
        yBound = screenBound.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0 - yBound - MeteorWidth) 
        {
            Destroy(gameObject);
        }
    }
}
