using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRun : MonoBehaviour
{

    public GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(unitychan.transform.position.x, 1, -10);   
    }
}
