using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                
        for (int i=0;i<this.transform.childCount;i++) {
            transform.GetChild(i).gameObject.name = "Wall ("+i+")";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
