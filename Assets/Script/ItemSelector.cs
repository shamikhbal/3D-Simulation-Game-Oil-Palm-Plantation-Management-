using System;
using UnityEngine.UI;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    public int selectedItem = 0;
    public Text tool;
    public static String item = "None";
    public Image treeCursor;
    
    // Start is called before the first frame update
    void Start()
    {
        SelectItem();
        tool.text = "Tool : " + item;
        treeCursor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedItem = selectedItem;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedItem = 1;
            item = "Planting";
            Item();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectedItem = 2;
            item = "Watering";
            Item();
            treeCursor.enabled = false;
        }

        if (previousSelectedItem != selectedItem)
        {
            SelectItem();
        }
    }

    private void SelectItem()
    {
        int i = 0;
        foreach(Transform item in transform)
        {
            if (i == selectedItem)
                item.gameObject.SetActive(true);
            else
                item.gameObject.SetActive(false); 
            i++;
        }
    }

    void Item()
    {
        tool.text = "Tool : " + item;
        
    }
}
