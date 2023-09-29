using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] randomObjects;
    private float nextActionTime;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        var index = Random.Range(0, randomObjects.Length);

        if (nextActionTime < 1.3)
        {
            nextActionTime += Time.deltaTime;
        }
        else
        {
            nextActionTime = 0;
            var randomPosition = new Vector3(270, 0, Random.Range(60, -80));

            Instantiate(
                randomObjects[index],
                randomPosition,
                Quaternion.Euler(new Vector3(0, -90, 0))
            );
        }
    }
}