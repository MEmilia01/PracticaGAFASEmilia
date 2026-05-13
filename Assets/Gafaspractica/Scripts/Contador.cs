using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI Puntos;
    private int puntosconseguidos = 0;
    private const int fin = 20;

    void Awake()
    {
        Instance = this;
    }

    public void Contador()
    {
        puntosconseguidos++;
        Puntos.text = puntosconseguidos + " / " + fin;

        if (puntosconseguidos >= fin)
        {
            Puntos.text = "¡Has ganadoooo!";
            FindAnyObjectByType<Cubos>().CancelInvoke(nameof(Cubos.spawnCubo));
        }
    }

    public bool MetaAlcanzada() => puntosconseguidos >= fin;
}
