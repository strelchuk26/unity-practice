using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyManager : MonoBehaviour
{
    public static float appleDropSpeed = 1f;

    public void SetEasyDifficulty()
    {
        appleDropSpeed = 1f;
        LoadGameScene();
    }

    public void SetMediumDifficulty()
    {
        appleDropSpeed = 0.75f;
        LoadGameScene();
    }

    public void SetHardDifficulty()
    {
        appleDropSpeed = 0.5f;
        LoadGameScene();
    }

    void LoadGameScene()
    {
        // Loading the game
        SceneManager.LoadScene("_Scene0_");
    }
}

