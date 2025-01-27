using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Vector3 movedirection;

    public Vector3 startingPosition;

    public float speed;

    // Start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        // writes msg in console
        Debug.Log("Hello World!");
        
        // in ref to the object, get ref to it's transform position and set it (=)
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {

        // movedirection is currently (1,0,1) and the speed is 5, thus it will move at (5,0,5) and then slowed down by the delta time 
        this.transform.position += movedirection * speed * Time.deltaTime; // multiplying by time.deltatime means per sec instead of per frame in update

        Debug.Log("Goodbye Now!");
    }
}