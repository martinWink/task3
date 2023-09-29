using UnityEngine;

public class PlayerBulletSpawner : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Space))
        {
            if (nextActionTime < 0.13)
            {
                nextActionTime += Time.deltaTime;
            }
            else
            {
                nextActionTime = 0;
                var t = new Vector3(
                    transform.parent.localPosition.x + 15,
                    transform.parent.localPosition.y,
                    transform.parent.localPosition.z
                );

                Instantiate(
                    sphere,
                    t,
                    Quaternion.identity
                );
            }
        }
    }
}