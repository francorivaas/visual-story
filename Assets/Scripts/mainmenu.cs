using UnityEngine;

public class mainmenu : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;

    private float timeToSpawn = 6.0f;

    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if (timeToSpawn <= 0)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetActive(true);
            }
        }

        else
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetActive(false);
            }
        }
    }
}
