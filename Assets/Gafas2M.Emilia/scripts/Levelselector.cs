using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public enum LevelOption
    {
        None = 0,
        Level1 = 1,
        Level2 = 2
    }

    [SerializeField] private LevelOption selectedLevel = LevelOption.None;

    public LevelOption GetSelectedLevel()
    {
        return selectedLevel;
    }

    public void SelectLevel1()
    {
        selectedLevel = LevelOption.Level1;
    }

    public void SelectLevel2()
    {
        selectedLevel = LevelOption.Level2;
    }

    public void ClearSelection()
    {
        selectedLevel = LevelOption.None;
    }
}