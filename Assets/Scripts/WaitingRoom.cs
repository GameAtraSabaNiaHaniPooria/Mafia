using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;
public class WaitingRoom : MonoBehaviour
{
    public Text playerCountText; 

    private void Start()
    {
        
        if (playerCountText == null)
        {
            
            playerCountText = new GameObject("PlayerCountText").AddComponent<Text>(); 
            playerCountText.text = "Default Player Count"; //for error Handeling
        }
        else
        {
            playerCountText.text = GameManager.playerCount.ToString() + " Players";
        }
    }

    public void GotoShow()
    {
        SceneManager.LoadScene("ShowScene"); 
    }
}
