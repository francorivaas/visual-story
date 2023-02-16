using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] private GameObject nameTextPannel;
    [SerializeField] private GameObject dialogueTextPannel;
    [SerializeField] private GameObject text;

    void Start()
    {
        nameTextPannel.SetActive(false);
        dialogueTextPannel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            nameTextPannel.SetActive(true);
            dialogueTextPannel.SetActive(true);
            Destroy(text);
        }
    }
}
