using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDemo : MonoBehaviour
{
    [SerializeField] List<GameObject> interactables = new List<GameObject>();
    List<Vector3> posList = new List<Vector3>();
    List<Quaternion> rotList = new List<Quaternion>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject interactable in interactables)
        {
            posList.Add(interactable.transform.position);
            rotList.Add(interactable.transform.rotation);
        }
    }

    public void ResetInteractables()
    {
        for (int i = 0; i < interactables.Count; i++)
        {
            interactables[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            interactables[i].transform.position = posList[i];
            interactables[i].transform.rotation = rotList[i];
        }
    }

}
