using UnityEngine;
using UnityEngine.SceneManagement;
public class Winner : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    public float winDistance = 1.5f;
    public static bool hasWon = false;
    void Update()
    {
        if (hasWon) return;
        float distance = Vector3.Distance(player.position, goal.position);
        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }
    }
    void WinGame()
    {
        Debug.Log("You Win!");
        SceneManager.LoadScene("EndScreen");
    }
}