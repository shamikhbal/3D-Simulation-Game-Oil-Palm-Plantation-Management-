using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrowingFruit : MonoBehaviour
{

    public float maxGrowth;
    //= 0.006f;
    public float speedGrowth=1f;
    //= Random.Range(0.0001f, 0.001f);
    public static float currentFruitGrowth;
    //= 0.0f;
    
    public static bool[] triggerInstCut = new bool[] { false, false, false, false, false,
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

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
     //       GameObject tree = GameObject.FindWithTag(CutFruit.currentTree);
     //       GameObject fruit = tree.gameObject.transform.GetChild(0).GetChild(12).GetChild(0).gameObject;

    /*        if (GrowingTree.triggerFruit == true)
            {
                GrowFruit();
            }
            if (CutFruit.triggerCutFruit == true)
            {
                Cut(fruit);
            }
    */
        for (int i = 0; i <= SpawnPlantTree.treeCounter; i++)
        {
            if (GrowingTree.triggerFruit[i] == true)
            {
                GameObject tree = GameObject.FindWithTag(i.ToString());
                GameObject fruit = tree.gameObject.transform.GetChild(0).GetChild(12).GetChild(0).gameObject;
                GrowFruit(fruit, i);
            }
        }

               GameObject ctree = GameObject.FindWithTag(CutFruit.currentTree);
               GameObject cfruit = ctree.gameObject.transform.GetChild(0).GetChild(12).GetChild(0).gameObject;

                if (CutFruit.triggerCutFruit == true)
                {
                    Cut(cfruit);
                    CutFruit.triggerCutFruit = false;
                }


        
    }

    void GrowFruit(GameObject F, int i)
    {
        tempScale = F.transform.localScale;
        if (tempScale.x < maxGrowth)
        {
            tempScale.x += speedGrowth;
            tempScale.y += speedGrowth;
            tempScale.z += speedGrowth;
            currentFruitGrowth = tempScale.x;
            F.transform.localScale = tempScale;
        }

        if (currentFruitGrowth >= maxGrowth)
        {
            triggerInstCut[i] = true;
        }
    }

    void Cut(GameObject F)
    {
        

        tempScale = F.transform.localScale;
        tempScale.x = 0;
        tempScale.y = 0;
        tempScale.z = 0;
        currentFruitGrowth = tempScale.x;
        F.transform.localScale = tempScale;
    }
}
