using UnityEngine;

public class EndGameHandler : MonoBehaviour
{
    [Header("End Screen")]
    public GameObject endScreen;

    public void ShowEndScreen()
    {
        if (endScreen != null)
        {
            endScreen.SetActive(true);
        }
        else
        {
            Debug.LogWarning("End Screen is not assigned!");
        }
    }
}