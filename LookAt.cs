using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Vector3 p;   

    void Start() {
        if (transform.position.y > 0) {
            p[1] = 1f;
        }
        if (transform.position.y < 0) {
            transform.LookAt(Vector3.down);
        }    
        Debug.Log("p: " + p);
        Debug.Log("Position: " + transform.position.y);
    }

    void Update()
    {
        if (transform.position.y < 0) {
            transform.LookAt(Vector3.down);
            transform.Rotate(180.0f, 0.0f, 0.0f, Space.Self);
        } else {
            transform.LookAt(p);
        }
        
    }
}
