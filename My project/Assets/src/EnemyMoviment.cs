using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMoviment : MonoBehaviour
{
    private int hp = 10;
    private int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(50, 70);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x <  -180 || hp <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Player") {
            hp = -1;
        }
        if (collision.gameObject.name == "PlayerBullet(Clone)") {
            hp--;
        }
    }
}
