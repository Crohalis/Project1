using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        { print("Hi,sphere");
     
                if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy (this.gameObject);
        }
        }

    }
}
