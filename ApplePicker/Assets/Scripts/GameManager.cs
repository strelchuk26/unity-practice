using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        // Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

