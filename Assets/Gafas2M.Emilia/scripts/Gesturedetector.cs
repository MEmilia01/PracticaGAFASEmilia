using UnityEngine;

public class GestureDetector : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private MenuManager menuManager;

    [Header("Testing")]
    [SerializeField] private KeyCode debugConfirmKey = KeyCode.Space;

    private void Update()
    {
        if (Input.GetKeyDown(debugConfirmKey))
        {
            ConfirmGesture();
        }
    }

    public void ConfirmGesture()
    {
        if (menuManager == null) return;
        menuManager.ConfirmSelection();
    }

    public void SimulateThumbsUp()
    {
        ConfirmGesture();
    }
}