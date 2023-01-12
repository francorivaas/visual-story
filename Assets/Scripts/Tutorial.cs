using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject tutorialText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Destroy(tutorialText);
    }
}
