using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightwewanttochange; // specific light assigned in inspector 

    public Vector3 lightmovedirection; // defined in inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightwewanttochange.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        lightwewanttochange.transform.position += lightmovedirection * Time.deltaTime; //move it based on the framerate
        lightwewanttochange.transform.localScale += Vector3.one * Time.deltaTime; // (1,1,1) honestly dpesn't change the light, but in the inspector shows its increase
        lightwewanttochange.intensity += 40f * Time.deltaTime;
        lightwewanttochange.spotAngle += 10F * Time.deltaTime;
    }
}
