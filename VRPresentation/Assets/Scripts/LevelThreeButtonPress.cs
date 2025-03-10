using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThreeButtonPress : MonoBehaviour
{
    [SerializeField] GameObject WallOne;

    public void DisableWall()
    {
        WallOne.SetActive(false);
    }
}
