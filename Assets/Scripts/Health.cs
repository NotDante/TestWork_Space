using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float Points = 0;
    public float HP = 100f;
    public GameObject Explosion;

    void OnTriggerEnter2D(Collider2D collisionInf)
    {
        Damage dmg = collisionInf.GetComponent<Damage>();
        if (dmg != null)
        {
            HP -= dmg.Dmg;
            //Debug.Log("Damage Taken! " + HP.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            ScoreCounter.StartScore += (int)Points;
            Destroyer();
        }
    }

    void Destroyer()
    {
        GameObject GO = Instantiate(Explosion, transform.position, Quaternion.identity);
        UIHealth uh = GetComponent<UIHealth>();
        if (uh != null)
        {
            uh.healthbar.fillAmount = 0;
        }
        Destroy(gameObject);
        Destroy(GO, 0.08f);
    }
}
