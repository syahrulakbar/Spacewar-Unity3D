using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterPick : MonoBehaviour
{
    public GameObject[] characters;
    // Start is called before the first frame update
    void Start()
    {
        int index = PlayerPrefs.GetInt("selectedCharacter");
        characters[index].SetActive(true) ;

    }

}
