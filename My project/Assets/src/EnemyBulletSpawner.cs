using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    public GameObject sphere;

    private float nextActionTime;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (nextActionTime < 1.3)
        {
            nextActionTime += Time.deltaTime;
        }
        else
        {
            nextActionTime = 0;
            var t = new Vector3(
                transform.localPosition.x,
                transform.localPosition.y,
                transform.localPosition.z
            );

            Instantiate(
                sphere,
                t,
                Quaternion.identity
            );
        }
    }
}