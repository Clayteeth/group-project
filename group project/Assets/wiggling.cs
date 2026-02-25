using UnityEngine;

//public class wiggling : MonoBehaviour
//{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        Debug.Log("she's been activated yay");
//    }

//}
public class wiggling : MonoBehaviour
{
    public float degreesPerSecond = 50.0f;
    void Start()
    {
          Debug.Log("she's been activated yay");
    }
    void Update()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);

    }
}