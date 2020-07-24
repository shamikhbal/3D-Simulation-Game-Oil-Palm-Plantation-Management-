using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTree : MonoBehaviour
{
    public static bool trigger = false;
    

    private void OnParticleTrigger()
    {
        trigger = true;
        Debug.Log(trigger);
    }
}
