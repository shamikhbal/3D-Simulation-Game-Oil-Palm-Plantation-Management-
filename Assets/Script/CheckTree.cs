using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTree : MonoBehaviour
{
    public static bool trigger = false;
    

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name);
    }
}
