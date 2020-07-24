using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingTree : MonoBehaviour
{
    public float maxGrowth;
        //= 0.006f;
    public float speedGrowth;
        //= Random.Range(0.0001f, 0.001f);
    public static float currentGrowth = 0.0f;
    public static bool[] triggerFruit = new bool[] { false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,};

    Vector3 tempScale;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i<= SpawnPlantTree.treeCounter; i++)
        {
            if (WateringParticleFx.trigger[i] == true)
            {
                Grow(GameObject.FindWithTag(i.ToString()), i);
            }
        } 
    }

    public void Grow(GameObject tree, int i)
    {
         tempScale = tree.gameObject.transform.localScale;
            if (tempScale.x < maxGrowth)
            {
                tempScale.x += speedGrowth;
                tempScale.y += speedGrowth;
                tempScale.z += speedGrowth;
                currentGrowth = tempScale.x;
                tree.gameObject.transform.localScale = tempScale;
            }

            if (currentGrowth >= maxGrowth)
            {
            triggerFruit[i] = true;
            }
    }
}
