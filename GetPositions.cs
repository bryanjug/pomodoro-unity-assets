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
        //transform is used to spawn object as child of planet 
        for (var i = 0; i < 100; i++) {
            Vector3 randomPosition = Random.onUnitSphere;
            Instantiate(Tree, randomPosition, Random.rotation, transform); 
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
