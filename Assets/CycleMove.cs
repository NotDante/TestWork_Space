using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleMove : MonoBehaviour
{
    public float Speed = 5f; //Скорость перемещения коробля по оси X
    private float xBound; //Граница экрана
    private float shipWidth; //Ширина спрайта коробля

    private bool left = true;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        xBound = screenBound.x;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(xBound.ToString());

        if (transform.position.x <= 0 - xBound)
        {
            left = false;
        }
        if (transform.position.x >= xBound)
        {
            left = true;
        }

        if (left)
        {
            MoveLeft();
        } else
        {
            MoveRight();
        }
    }

    void MoveRight()
    {
        Vector2 pos = transform.position; //Временная переменная
        pos.x += Speed * Time.deltaTime; //Перемещение влево по оси X
        transform.position = pos;
    }

    void MoveLeft()
    {
        Vector2 pos = transform.position; //Временная переменная
        pos.x -= Speed * Time.deltaTime; //Перемещение влево по оси X
        transform.position = pos;
    }
}
