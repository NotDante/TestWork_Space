using System.Linq;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform[] firePoint; //Места произведения выстрела

    public GameObject BulletPref; //Префаб пули

    public float BulletSpeed = 20f; //Скорость пули

    public float pause = 0.5f;

    private void Start()
    {
        InvokeRepeating("Shoot", 0, pause);
    }

    void Shoot()
    {
        for (int i = 0; i < firePoint.Count(); i++) {
            GameObject bullet = Instantiate(BulletPref, firePoint[i].position, BulletPref.transform.rotation); //Спавн выстрела
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); //Ищим компонент Rigidbody
            rb.AddForce((-1 * firePoint[i].up * BulletSpeed), ForceMode2D.Impulse); //Придаем импульс
        }
    }
}
