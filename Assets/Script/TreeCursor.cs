using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeCursor : MonoBehaviour
{

    public Image treeCursor;

    // Start is called before the first frame update
    void Start()
    {
        treeCursor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemSelector.item == "Planting")
        {
            treeCursor.enabled = true;
        }
    }
}
