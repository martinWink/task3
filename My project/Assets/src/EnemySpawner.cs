using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] randomObjects;
    private float nextActionTime = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int index = Random.Range(0, randomObjects.Length);

        if (nextActionTime < 1.3) {
            nextActionTime += Time.deltaTime;
        } else {
            nextActionTime = 0;
            Vector3 randomPosition = new Vector3(270, 0, Random.Range(60, -80));
            
            Instantiate(
                randomObjects[index],
                randomPosition,
                Quaternion.Euler(new Vector3(0, -90, 0))
            );
        }

    }
}
