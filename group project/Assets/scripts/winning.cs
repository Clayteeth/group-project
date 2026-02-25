using UnityEngine;

public class winning : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("winning script is online");
    }
    public Transform rock;
    public Transform goalRock;
    public float winDistanceVariable = 1.0f;

    public bool thisGuyFucks = false;

    void Update()
    {
        if (thisGuyFucks) return;

        //you need to define this so the lowercase distance function works otherwise it doesnt know where the objects it's supposed to keep track of are
        //(rockGuy.position, goalRock.position) is telling it the position of the two objects are in the world
        float distance = Vector3.Distance(rock.position, goalRock.position);

        if (distance <= winDistanceVariable);
        {
            thisGuyFucks = true;
            WinDaGame();
        }

    }

    void WinDaGame()
    { 
            Debug.Log("winning script is online");
    }
}
