using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightwewanttochange; // specific light assigned in inspector 

    public Vector3 lightmovedirection; // defined in inspector

    public bool isitorisntit = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.blue);
        //ChangeLightColor(color.green); //both of these colors will show up as "apple" as we defined it as the placeholder name
        this.gameObject.SetActive(isitorisntit);// can prevent things from happening, requires a boolean(?)
        //lightwewanttochange.gameObject.SetActive(false); //things will still function even when it's off if the light changer itself is still on
        //destroy(lightwewanttochange.gameObject);// this is how you destroy an object
    }

    // Update is called once per frame
    void Update()
    {
       AdjustLight(); // the function we made is called!
       Debug.Log("LightObject has been adjusted!"); // will only show in console once the ENTIRE function has been completed 

       if(Input.GetKeyDown(KeyCode.W));
       {
            ChangeLightColor(Color.white);
       }

       if(Input.GetKeyDown(KeyCode.G));
       {
            ChangeLightColor(Color.green);
       }

       if(Input.GetKeyDown(KeyCode.Space))
       {
        lightwewanttochange.gameObject.SetActive(false);
       }

       if(Input.GetKeyDown(KeyCode.V));
       {
        lightwewanttochange.gameObject.SetActive(true);
       }
    }

    private void AdjustLight()
    {
        lightwewanttochange.transform.position += lightmovedirection * Time.deltaTime; //move it based on the framerate
        lightwewanttochange.transform.localScale += Vector3.one * Time.deltaTime; // (1,1,1) honestly doesn't change the light too much visually, but in the inspector shows its increase
        lightwewanttochange.intensity += 40f * Time.deltaTime;
        lightwewanttochange.spotAngle += 10F * Time.deltaTime;
    }
    public void ChangeLightColor(Color apple)
    {
        lightwewanttochange.color = apple;
    }
}