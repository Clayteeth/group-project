using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public int testValue = 168;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(x, 0f, z);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);
   
    }



}
