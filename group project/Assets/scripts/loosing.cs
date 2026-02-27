using UnityEngine;
using UnityEngine.SceneManagement;
public class loosing : MonoBehaviour
{
    public Transform player;
    public Transform DeathPlane;
    public float looseDistance = 1.5f;
    public static bool hasLost = false;
    void Update()
    {
        if (hasLost) return;
        float distance = Vector3.Distance(player.position, DeathPlane.position);
        if (distance <= looseDistance)
        {
            hasLost = true;
            LooseGame();
        }
    }   
    void LooseGame()
    {
        Debug.Log("womp womp");
        SceneManager.LoadScene("DeathScreen");
    }
}
