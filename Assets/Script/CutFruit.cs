using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutFruit : MonoBehaviour
{
    public float cutTime = 2f;
    public Text cutInst;
    public Text fruits;
    public static int countFruits=0;
    public bool entrance;
    public static bool instEntrance;
    public static bool triggerCutFruit=false;
    public static string currentTree;

    public AudioSource cutSource;
    public AudioClip cutFx;

    // Start is called before the first frame update
    void Start()
    {
        this.tag = transform.parent.tag;
        entrance = false;
        instEntrance = false;
        cutInst.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(entrance== true)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                cutSource.PlayOneShot(cutFx);
                countFruits++;
                cutInst.enabled = false;
                triggerCutFruit = true;
                GrowingFruit.triggerInstCut[int.Parse(this.tag)] = false;
            }
        }

        fruits.text = "Oil Palm Fruits : " + countFruits;
    }

    public void OnTriggerEnter(Collider other)
    {

        if ((other.gameObject.CompareTag("Player")) && (GrowingFruit.triggerInstCut[int.Parse(this.tag)] == true))
        {
            entrance = true;
            instEntrance = entrance;
            cutInst.text = "Press X Button To Pick The Fruit";
            cutInst.enabled = true;
            currentTree = this.tag;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            entrance = false;
            cutInst.enabled = false;
        }
    }
}
