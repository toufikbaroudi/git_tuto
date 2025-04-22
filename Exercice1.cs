using UnityEngine;

public class Exercice1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] redSquares = GameObject.FindGameObjectsWithTag("red");
        GameObject[] blueSquares = GameObject.FindGameObjectsWithTag("blue");
        GameObject[] greenSquares = GameObject.FindGameObjectsWithTag("green");

        foreach (GameObject r in redSquares)
        {
            r.GetComponent<Renderer>().material.color = Color.red;
        }
        foreach (GameObject r in blueSquares)
        {
            r.GetComponent<Renderer>().material.color = Color.blue;
        }
        foreach (GameObject r in greenSquares)
        {
            r.GetComponent<Renderer>().material.color = Color.green;
        }

    }

   
}
