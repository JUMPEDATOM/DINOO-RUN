using UnityEngine;

public class Cactus : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * Ground.golobalSpeed * Time.deltaTime;
        // destroy GameObject
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
