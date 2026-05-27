using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] private GameObject cubePrefab;

    [Header("Grid Settings")]
    [SerializeField] private int rows = 3;
    [SerializeField] private int columns = 3;
    [SerializeField] private float spacing = 0.25f;
    [SerializeField] private Vector3 startPosition = Vector3.zero;

    [Header("Level Settings")]
    [SerializeField] private int level1ActiveTime = 3;
    [SerializeField] private int level2ActiveTime = 1;

    private GameObject[,] cubes;

    public void SpawnLevel1()
    {
        rows = 3;
        columns = 3;
        SpawnGrid(level1ActiveTime);
    }

    public void SpawnLevel2()
    {
        rows = 5;
        columns = 5;
        SpawnGrid(level2ActiveTime);
    }

    private void SpawnGrid(int activeTime)
    {
        if (cubePrefab == null) return;

        ClearGrid();

        cubes = new GameObject[rows, columns];

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                Vector3 position = startPosition + new Vector3(x * spacing, 0f, y * spacing);
                GameObject cube = Instantiate(cubePrefab, position, Quaternion.identity);
                cube.name = $"Cube_{x}_{y}";

                TargetCube targetCube = cube.GetComponent<TargetCube>();
                if (targetCube != null)
                {
                    targetCube.SetInactive(activeTime);
                }

                cubes[x, y] = cube;
            }
        }
    }

    public void ClearGrid()
    {
        if (cubes == null) return;

        foreach (GameObject cube in cubes)
        {
            if (cube != null)
            {
                Destroy(cube);
            }
        }
    }
}