using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTagScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.tag = transform.parent.tag;
    }

}
