using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlowManager : MonoBehaviour
{
    [Header("Scene Names")]
    [SerializeField] private string menuSceneName = "Menu";
    [SerializeField] private string level1SceneName = "Level1";
    [SerializeField] private string level2SceneName = "Level2";

    public void LoadMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(level1SceneName);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(level2SceneName);
    }

    public void LoadSelectedLevel(LevelSelector.LevelOption level)
    {
        switch (level)
        {
            case LevelSelector.LevelOption.Level1:
                LoadLevel1();
                break;
            case LevelSelector.LevelOption.Level2:
                LoadLevel2();
                break;
            default:
                LoadMenu();
                break;
        }
    }
}