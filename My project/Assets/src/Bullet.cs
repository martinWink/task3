using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;

    private readonly ArrayList names = new();

    // Start is called before the first frame update
    private void Start()
    {
        if (gameObject.name == "PlayerBullet(Clone)")
        {
            direction = Vector3.right;
            names.Add("2.1(Clone)");
            names.Add("3.1(Clone)");
            names.Add("4.1(Clone)");
            names.Add("5.1(Clone)");
            names.Add("6.1(Clone)");
            names.Add("7.1(Clone)");
            names.Add("8.1(Clone)");
            names.Add("9.1(Clone)");
            names.Add("10.1(Clone)");
            names.Add("11.1(Clone)");
            names.Add("12.1(Clone)");
            names.Add("13.1(Clone)");
        }
        else
        {
            direction = Vector3.left;
            names.Add("Player");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(direction * 95 * Time.deltaTime);
        if (transform.position.x > 160 || transform.position.x < -150) Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (names.Contains(collision.gameObject.name)) Destroy(gameObject);
    }
}