using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    public GameObject player;
    public Image healthbar;

    private Health health;
    private float constHealth = 500;

    void Start()
    {
        health = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        float per = health.HP / constHealth;
        if (player!= null)
        healthbar.fillAmount = per;
        
    }
}
