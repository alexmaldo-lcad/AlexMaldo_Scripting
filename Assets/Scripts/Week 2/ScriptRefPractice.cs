using UnityEngine;

public class ScriptRefPractice : MonoBehaviour
{
    public Glassesbunner bunnyController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bunnyController.scaleincrease = 5f;
        bunnyController.rotateglassesbun();
        bunnyController.rotateglassesbun();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
