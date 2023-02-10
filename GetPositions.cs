using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPositions : MonoBehaviour
{
    public GameObject Tree;
    Transform target;

    // Start is called before the first frame update
    public void Start()
    {
        // Creates an object with a random rotation
        //Instantiate(objectToSpawn, transform.position, Random.rotation); 
        for (var i = 0; i < 20; i++) {
            Vector3 randomPosition = Random.onUnitSphere;
            Instantiate(Tree, randomPosition, Random.rotation, transform); 
        }
        
        // if (randomPosition[1] > 0) {
        //     Tree.transform.LookAt(Vector3.up);
        // } 
        // if (randomPosition[1] < 0) {
        //     Tree.transform.LookAt(Vector3.down);
        // } 
        //if (y is negative) = Vector3.down
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Tree.transform.LookAt(Vector3.up);
    // }
}
