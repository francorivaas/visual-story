using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] private GameObject dialogueTextPannel;
    //[SerializeField] private GameObject text;

    void Start()
    {
        dialogueTextPannel.SetActive(true);
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    dialogueTextPannel.SetActive(true);
        //    Destroy(text);
        //}
    }
}
