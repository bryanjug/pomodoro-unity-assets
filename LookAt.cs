using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Vector3 p;   

    void Start() {
        if (transform.position.y > 0) {
            p[1] = 1f;
            transform.LookAt(Vector3.down);

            System.Random ran = new System.Random();
            int x = ran.Next(230, 270);
            float xf = (float)x;

            transform.Rotate(xf, 0.0f, 0.0f, Space.Self);
        }
        if (transform.position.y < 0) {
            transform.LookAt(Vector3.down);
            //randomize x slightly to make bottom trees more straight
            System.Random ran = new System.Random();
            int x = ran.Next(190, 230);
            float xf = (float)x;

            transform.Rotate(xf, 0.0f, 0.0f, Space.Self);
        }    
    }

    void Update()
    {
        
    }
}
