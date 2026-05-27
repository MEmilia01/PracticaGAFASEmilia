using UnityEngine;

public class TargetCube : MonoBehaviour
{
    [Header("Colors")]
    [SerializeField] private Color inactiveColor = Color.gray;
    [SerializeField] private Color activeColor = Color.red;
    [SerializeField] private Color successColor = Color.green;
    [SerializeField] private Color failColor = Color.black;

    private Renderer cubeRenderer;
    private int activeTime;

    private void Awake()
    {
        cubeRenderer = GetComponent<Renderer>();
        SetInactive(3);
    }

    public void SetInactive(int time)
    {
        activeTime = time;
        SetColor(inactiveColor);
    }

    public void Activate()
    {
        SetColor(activeColor);
    }

    public void Success()
    {
        SetColor(successColor);
    }

    public void Fail()
    {
        SetColor(failColor);
    }

    private void SetColor(Color color)
    {
        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = color;
        }
    }
}