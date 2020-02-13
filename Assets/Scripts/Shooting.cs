using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint; //Место произведения выстрела

    public GameObject BulletPref; //Префаб пули

    public float BulletSpeed = 20f; //Скорость пули

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); //В случае нажатия проблема генерируется выстрел
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPref, firePoint.position, BulletPref.transform.rotation); //Спавн выстрела
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); //Ищим компонент Rigidbody
        rb.AddForce(firePoint.up * BulletSpeed, ForceMode2D.Impulse); //Придаем импульс
    }
}
