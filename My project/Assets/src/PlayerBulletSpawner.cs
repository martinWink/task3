using UnityEngine;

public class PlayerBulletSpawner : MonoBehaviour
{
    public GameObject sphere;

    private float nextActionTime = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            if (nextActionTime < 0.13) {
                nextActionTime += Time.deltaTime;
            } else {
                nextActionTime = 0;
                Vector3 t = new Vector3(
                    transform.parent.localPosition.x + 15,
                    transform.parent.localPosition.y,
                    transform.parent.localPosition.z
                ) ;
                
                Instantiate(
                    sphere,
                    t,
                    Quaternion.identity
                );
            }
        }
    }
}
