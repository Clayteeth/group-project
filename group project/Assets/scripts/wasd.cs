using UnityEngine;

public class wasd : MonoBehaviour
{
    
    void Start()
    {
       Debug.Log("she's can understand inputs maybe yay");
    }

    public float secondMoveSpeedQuestionMark = 5f;

    // ok time for key imputs
    void Update()
    {
        Vector3 moveVariableTwo = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveVariableTwo += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVariableTwo += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVariableTwo += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVariableTwo += Vector3.right;
        }

        transform.Translate(moveVariableTwo * secondMoveSpeedQuestionMark * Time.deltaTime);
    }
}
