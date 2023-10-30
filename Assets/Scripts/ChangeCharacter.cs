using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] private Material material1;
    [SerializeField] private Material material2;
    [SerializeField] private Material material3;
    [SerializeField] private Material material4;

    [SerializeField] private SkinnedMeshRenderer playerMesh;

    private int selectedCharacter = 0;

    private void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt("Character", 0);
    }

    public void ChangeMesh(int selected)
    {
        if(selected == 1)
        {
            playerMesh.material = material1;
        }
        else if(selected == 2)
        {
            playerMesh.material = material2;
        }
        else if (selected == 3)
        {
            playerMesh.material = material3;
        }
        else
        {
            playerMesh.material = material4;
        }

        selectedCharacter = selected;
    }

}
