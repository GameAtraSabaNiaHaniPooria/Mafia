using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int playerCount;
    public static List<string> roles;
  

  

    public void BacktoMenu()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void SelectPlayerCount(int count)
    {
        playerCount = count;
        SceneManager.LoadScene("WaitingRoom"); 
        
        roles = new List<string>();
        switch (playerCount)
        {
            case 8:
                roles.Add("Godfather");
                roles.Add("Mafia");
                roles.Add("Framer");
                roles.Add("Detective");
                roles.Add("Doctor");
                roles.Add("Sniper");
                roles.Add("Citizen");
                roles.Add("Citizen");
                break;
            case 10:
                roles.Add("Godfather");
                roles.Add("Mafia");
                roles.Add("Framer");
                roles.Add("Detective");
                roles.Add("Doctor");
                roles.Add("Sniper");
                roles.Add("Mayor");
                roles.Add("Citizen");
                roles.Add("Citizen");
                roles.Add("Citizen");
                break;
            case 12:
                roles.Add("Godfather");
                roles.Add("Mafia");
                roles.Add("Framer");
                roles.Add("Killer");
                roles.Add("Detective");
                roles.Add("Doctor");
                roles.Add("Sniper");
                roles.Add("Mayor");
                roles.Add("Citizen");
                roles.Add("Citizen");
                roles.Add("Mason");
                roles.Add("Coroner");
                break;
        }
        roles.Shuffle();

        
    }
}
