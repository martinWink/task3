using UnityEngine;

public class Sun : MonoBehaviour
{
    public float maxRange = 11;
    public float minRange = 6;
    public float flickerSpeed = 0.5f;

    private Light lightSource;

    // Start is called before the first frame update
    private void Start()
    {
        lightSource = GetComponent<Light>();
    }

    // Update is called once per frame
    private void Update()
    {
        lightSource.intensity = Mathf.Lerp(minRange, maxRange, Mathf.PingPong(Time.time, flickerSpeed));
    }
}