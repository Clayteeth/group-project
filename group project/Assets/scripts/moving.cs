using UnityEngine;

public class moving : MonoBehaviour
{
    void Start()
    {
        Debug.Log("she's moving maybe yay");
    }

    // move time?

    public float moveSpeedVariable = 5f;
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 moveVariable = new Vector3(horizontalMove, 0f, verticalMove);
        transform.Translate(moveVariable * moveSpeedVariable * Time.deltaTime, Space.Self);
    }
}
