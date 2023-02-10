using UnityEngine;

public class LookAt : MonoBehaviour
{
    // public Transform target;
    
    // private void Start () {
    //     Vector3 direction = target.position - transform.position;
    //     Debug.Log("direction" + direction);
    //     Quaternion rotation = Quaternion.LookRotation(direction);
    //     Debug.Log("rotation" + rotation);
    //     transform.rotation = rotation;
    //     Debug.Log("transform.rotation" + transform.rotation);
    // }

    // tree = GameObject.Find("Tree").GetComponent<UIComponentType>();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        transform.LookAt(Vector3.up);
    }
}
