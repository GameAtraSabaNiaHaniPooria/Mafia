using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShowRole : MonoBehaviour
{
    public Text Role; 
    
    
    

    private void Start()
    {
       
        if (Role == null)
        {
            
            Role = new GameObject("Role").AddComponent<Text>(); 
            Role.text = "Default Player "; //for error Handeling
        }
        else
        {
            
            Role.text =  GameManager.roles[0];
            GameManager.roles.RemoveAt(0);
           
            Debug.Log( GameManager.roles.Count);
       
        }

        
        

      
    }

    public void GotoShow()
    {
        SceneManager.LoadScene("ShowScene"); 
    }
    public void WaitforNextPlayer()
    {
        if (GameManager.roles.Count > 0)
    {
      
        SceneManager.LoadScene("WaitingRoomNextPlayer"); 
         
    }
    else
    {
    
        SceneManager.LoadScene("SampleScene"); 
    }
       
    }
     public void Show()
    {
        SceneManager.LoadScene("ShowScene"); 
    }
}
