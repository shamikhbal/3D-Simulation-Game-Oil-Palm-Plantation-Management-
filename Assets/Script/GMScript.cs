using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    public static string currentTool = "none";
    public Text instruction;
    public Image inst1;
    public Image inst2;
    public Image inst3;
    public Image inst4;
    public Image inst5;
    private int instIndex;

    // Start is called before the first frame update
    void Start()
    {
        inst1.enabled = false;
        inst2.enabled = false;
        inst3.enabled = false;
        inst4.enabled = false;
        inst5.enabled = false;
    }

    void Update()
    {

        if (instIndex == 0)
        {
            inst1.enabled = true;
            instruction.text = "Press W, A, S, D To Move Around. Press Spacebar To Jump";
            if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)))
            {
                inst1.enabled = false;
                instIndex++;
            }
        }
        else if (instIndex == 1)
        {
            inst2.enabled = true;
            instruction.text = "Press 1 To Select Planting Tool";
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                inst2.enabled = false;
                instIndex++;
            }
        }
        else if (instIndex == 2)
        {
            inst3.enabled = true;
            instruction.text = "Aim The Mouse To The Ground And Left Click Mouse To Plant";
            if (Input.GetMouseButton(0))
            {
                inst3.enabled = false;
                instIndex++;
            }
        }
        else if (instIndex == 3)
        {
            inst4.enabled = true;
            instruction.text = "Press 2 To Select Planting Tool";
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                inst4.enabled = false;
                instIndex++;
            }
        }
        else if (instIndex == 4)
        {
            instruction.text = "Aim The Water To The Tree To Start Grow The Tree";
            if(GrowingTree.currentGrowth != 0.0f)
            {
                instruction.text = "";
                instIndex++;

            }
        }
        else if ((instIndex == 5) && (GrowingFruit.triggerInstCut[0]))
        {
            instruction.text = "Move Toward The Tree";
            if (CutFruit.instEntrance==true)
            {
                instruction.text = "";
                instIndex++;

            }
        }
        else if ((instIndex == 6) && (Input.GetKeyDown(KeyCode.X)))
        {
            inst5.enabled = true;
            instruction.text = "Suggested Planting Structure";
            StartCoroutine(closeInst());
        }
    }

    IEnumerator closeInst()
    {
        yield return new WaitForSeconds(4.0f);
        instruction.text = "";
        inst5.enabled = false;
        instIndex++;
    }
}
