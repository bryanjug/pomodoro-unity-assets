using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPositions : MonoBehaviour
{
    public GameObject Tree;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = Random.onUnitSphere;
        // rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        Debug.Log("Random point on Sphere: " + randomPosition);
        Debug.Log("Vector3.up: " + Vector3.up);
        // Creates an object with a random rotation
        //Instantiate(objectToSpawn, transform.position, Random.rotation); 
        
        Instantiate(Tree, randomPosition, Random.rotation, transform); 
        // Tree.transform.LookAt(Vector3.up);
        //if (y is positive) = Vector3.up
        //if (y is negative) = Vector3.down
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Tree.transform.LookAt(Vector3.up);
    // }
}
