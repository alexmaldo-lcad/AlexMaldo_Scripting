using UnityEngine;

public class DataTypePractice : MonoBehaviour
{
    int SantaClaus;

    // floats are floating point numbers (decimals) 
    float total;
    public float mario;
    public float yoshi = 4.8f; // declare a number as float with "f" at the end

    // chars can only be one letter or char on keyboard and use apostrophes
    char bee = 'B';

    string fullsentence;
    string intro = "Hello World!";
    string outro = "I'm outta here!";

    public string chestName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SantaClaus = 56;

        SantaClaus = (SantaClaus + 5) * 2 / (3 - 7);

        Debug.Log(SantaClaus); // will display solution

       // subtracts 2 from value of yoshi
        yoshi = yoshi - 2;

        // same thing as the line above 
        yoshi -= 2;

        Debug.Log("Yoshi's value is " + yoshi); // will display 2.8

        total = mario + yoshi;

        Debug.Log(total);

        fullsentence = intro + " " + outro;

        Debug.Log(fullsentence);
    }

    // Update is called once per frame
    void Update()
    {

    }
}