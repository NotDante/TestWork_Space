using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Renderer renderView = this.GetComponent<Renderer>(); //Компонент отрисовки
        if (!renderView.isVisible) //Если компонент выходит за поле зрения, то он уничтожается 
        {
            Destroy(gameObject);
        }        
    }
}
