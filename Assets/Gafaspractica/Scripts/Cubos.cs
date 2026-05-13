using System.Collections;
using UnityEngine;

public class Cubos : MonoBehaviour
{
    [SerializeField] public GameObject Cubo;
    [SerializeField] private Transform player;
    [SerializeField] public float Distancia = 10f;
    [SerializeField] private float AngCubo = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(spawnCubo), 0f, 4f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spawnCubo()
    {

        Camera cam = Camera.main;

        Vector3 playerForward = player.forward;
        playerForward.y = 0f;
        playerForward.Normalize();

        float randAngle = Random.Range(AngCubo / 2f, -AngCubo / 2f);
        Quaternion rot = Quaternion.AngleAxis(randAngle, Vector3.up);
        Vector3 direction = rot * playerForward;

        Vector3 pos = player.position + direction * Distancia;
        pos.y = cam.transform.position.y;

        Instantiate(Cubo, pos, Quaternion.identity);
    }

}
