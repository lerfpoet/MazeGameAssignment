using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    private float winDistance = 1.5f;

    private bool hasWon = false;

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
    }
}
