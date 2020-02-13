using System.Linq;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemies; //Массив префабов врагов
    public float Pause; //Пауза между врагами
    public float StartTime = 10f;

    private float xBound;

    void Start()
    {
        Vector2 screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        xBound = screenBound.x;
        InvokeRepeating("SpawnObject", StartTime, Pause);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        float rnd = Random.Range(0 - xBound, xBound); //Рандомный выбор спавна объекта
        Vector3 spawnVector = new Vector3(rnd, transform.position.y, transform.position.z);
        int index = Random.Range(0, Enemies.Count()-1);
        Debug.Log(index.ToString());
        GameObject enemy = Instantiate(Enemies[index], spawnVector, Enemies[index].transform.rotation);
    }
}
