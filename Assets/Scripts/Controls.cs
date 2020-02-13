using UnityEngine;

public class Controls : MonoBehaviour
{
    public float Speed = 5f; //Скорость перемещения коробля по оси X
    private float xBound; //Граница экрана
    private float playerWidth; //Ширина спрайта игрока

    void Start()
    {
        Vector2 screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = transform.GetChild(0).transform.GetComponent<SpriteRenderer>().bounds.size.x;
        xBound = screenBound.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position; //Временная переменная
        if (Input.GetKey("a") && transform.position.x >= 0-xBound + playerWidth/2) //Нажатие кнопки A
        {
            pos.x -= Speed * Time.deltaTime; //Перемещение влево по оси X
        }
        if (Input.GetKey("d") && transform.position.x <= xBound - playerWidth/2) //Нажатие кнопки D
        {
            pos.x += Speed * Time.deltaTime; //Перемещение вправо по оси X
        }
        transform.position = pos; //Изменение положения объекта в пространстве
    }
}
