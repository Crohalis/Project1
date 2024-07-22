using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log ("Goodnight World"); 
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }
}
