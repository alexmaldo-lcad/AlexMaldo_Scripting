using UnityEngine;

public class Glassesbunner : MonoBehaviour
{
    public GameObject glassesbun;
    public float scaleincrease = .5f;
    public GameObject youdiedscreen;

    //public Vector3 rotationAmount;
    //public Vector3 teleportTransform; //i forgot what datatype to declare this as :( so this isn't working rn

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        glassesbun.transform.localScale += Vector3.one * scaleincrease * Time.deltaTime;

        if(glassesbun.transform.localScale.x > 40) //once it checks that it has hit a scale of 40, the you died screen will overlay everything else
        {
            youdiedscreen.SetActive(true);
        }
    }

    public void resetBun()
    {
        glassesbun.transform.localScale = Vector3.one; //does not need delta time because it needs to happen immediatly after the input
        scaleincrease += .5f;
    }

    public void rotateglassesbun()
    {
        glassesbun.transform.Rotate(new Vector3(0f, 0f, -90f)); // will rotate glassesbun by -90 degrees in the z direction by creating a new Vector3 variable
        //to be used at run time
        //glassesbun.transform.Rotate(rotationAmount); makes it so you can change functionality in inspector
    }

    public void Teleportbun()
    {
        //glassesbun.transform.position = teleportTransform.position;
    }
}
