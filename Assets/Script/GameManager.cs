using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Seeds = 1;
    public GameObject Tree;
    public GameObject Seed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (Seeds >= 1)
                {
                    GameObject tree = Instantiate(Tree, hit.point, Quaternion.identity);
                    Seeds--;
                }
            }
        }
    }
}
