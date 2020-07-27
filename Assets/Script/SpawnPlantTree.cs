using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlantTree : MonoBehaviour
{
    public GameObject prefab;
    public Camera mainCamera;
    public static int treeCounter = 0;
    public Text totalTree;
    public AudioSource plantSource;
    public AudioClip plantFx;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
           
            if (Input.GetMouseButtonDown(0))
            {
              plantSource.PlayOneShot(plantFx);
              Vector3 worldPos;
              Ray ray = mainCamera.ScreenPointToRay(mousePos);
              RaycastHit hit;

              if (Physics.Raycast(ray, out hit, 1000f))
              {
                worldPos = hit.point;
              }

              else
              {
                worldPos = mainCamera.ScreenToWorldPoint(mousePos);
              }

              GameObject seed = Instantiate(prefab, worldPos, Quaternion.identity);
              seed.gameObject.tag = treeCounter.ToString();
              treeCounter++;
            }

        totalTree.text = "Tree Planted : " + treeCounter;
        
    }

}
