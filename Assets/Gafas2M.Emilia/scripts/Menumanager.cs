using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private LevelSelector levelSelector;
    [SerializeField] private SceneFlowManager sceneFlowManager;

    private void Start()
    {
        levelSelector = FindAnyObjectByType<LevelSelector>();
        sceneFlowManager = FindAnyObjectByType<SceneFlowManager>();
    }

    public void ConfirmSelection()
    {
        if (levelSelector == null || sceneFlowManager == null) return;
        sceneFlowManager.LoadSelectedLevel(levelSelector.GetSelectedLevel());
    }

    public void GoToLevel1()
    {
        if (sceneFlowManager == null) return;
        sceneFlowManager.LoadLevel1();
    }

    public void GoToLevel2()
    {
        if (sceneFlowManager == null) return;
        sceneFlowManager.LoadLevel2();
    }
}
