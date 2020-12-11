using UnityEngine;

public class Ground : MonoBehaviour
{
    public static float golobalSpeed = 7.5f;
    private float groundWidth = 17.5f;
    void Update()
    {
        transform.position -= new Vector3(golobalSpeed * Time.deltaTime, 0, 0);
        
        if (transform.position.x <= -groundWidth)
        {
            transform.position += new Vector3(2 * groundWidth, 0, 0);
        }
        //Increase speed constantly
        golobalSpeed += 0.01f * Time.deltaTime;
    }
}
