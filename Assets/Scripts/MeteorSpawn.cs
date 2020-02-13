using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public GameObject MeteorPrefab; //Префаб для метеоров

    public float MeteorMaxSpeed = 15f; //Максимальная скорость метеоров
    public float MeteorMinSpeed = 5f; //Минимальная скорость метеоров

    public float MaxScale = 1.5f; //Максимальный размер метеоров
    public float MinScale = 0.7f; //Минимальный размер метеоров

    public float pause = 2; //Пауза между спавномметеоров

    private float xBound;



    // Start is called before the first frame update
    void Start()
    {
        Vector2 screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        xBound = screenBound.x;
        InvokeRepeating("SpawnObject", 0, pause);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        float rnd = Random.Range(0 - xBound, xBound); //Рандомный выбор спавна объекта
        Vector3 spawnVector = new Vector3(rnd, transform.position.y, transform.position.z);
        GameObject meteor = Instantiate(MeteorPrefab, spawnVector, this.transform.rotation);
        float scale = Random.Range(MinScale, MaxScale);
        meteor.transform.localScale *= scale;
        Health hp = meteor.GetComponent<Health>();
        hp.HP = 100 * scale;
        hp.Points = 10 * scale;
        Rigidbody2D rb = meteor.GetComponent<Rigidbody2D>(); //Ищим компонент Rigidbody
        float MeteorSpeed = Random.Range(MeteorMinSpeed, MeteorMaxSpeed); //Рандомная скорость
        rb.AddForce(this.transform.up * (0 - MeteorSpeed), ForceMode2D.Impulse); //Придаем импульс
    }
}
