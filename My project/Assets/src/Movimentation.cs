using System.Collections;
using UnityEngine;

public class T : MonoBehaviour
{
    private int hp = 10;

    private readonly ArrayList names = new();

    private readonly int speed = 50;

    // Start is called before the first frame update
    private void Start()
    {
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

    // Update is called once per frame
    private void Update()
    {
        if (hp <= 0) Destroy(gameObject);

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 135)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -140)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < 60)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -80)
            transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (names.Contains(collision.gameObject.name)) Destroy(gameObject);

        if (collision.gameObject.name == "EnemyBullet(Clone)") hp--;
    }
}