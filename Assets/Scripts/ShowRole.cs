using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShowRole : MonoBehaviour
{
    public Text Role; 
    public Text Description; 
    public Image displayImage; 

    public Sprite Godfather;
    public Sprite Mafia;
    public Sprite Framer;
    public Sprite Killer;
    public Sprite Detective;
    public Sprite Doctor;
    public Sprite Sniper;
    public Sprite Mayor;
    public Sprite Citizen;
    public Sprite Mason;
    public Sprite Coroner;
    
    
    
    

    private void Start()
    {
       
        if (Role == null)
        {
            
            Role = new GameObject("Role").AddComponent<Text>(); 
            Role.text = "Default Player "; //for error Handeling
           
        }
          if (Description == null)
        {
            
            Description = new GameObject("Description").AddComponent<Text>(); 
            //for error Handeling
            Description.text = "Default";
        }

        else
        {
            
            Role.text =  GameManager.roles[0];

            if (Role.text == "Mafia")
            {
                displayImage.sprite = Mafia;
                Description.text = "A regular mafia member who is identified as mafia during the detective's investigation.";
            }
            else if (Role.text == "Godfather")
            {
                displayImage.sprite = Godfather;
                 Description.text = "The mafia leader who appears as a citizen in the detective's investigation. ";
            }
             else if (Role.text == "Framer")
            {
                displayImage.sprite = Framer;
                 Description.text = "A special mafia member who may appear as a citizen in the detective's investigation.";
            }
               else if (Role.text == "Killer")
            {
                displayImage.sprite = Killer;
                 Description.text = "Has the ability to kill and acts as an aggressive force for the mafia.";
            }
               else if (Role.text == "Detective")
            {
                displayImage.sprite = Detective;
                 Description.text = "Responsible for nightly investigations and identifying mafia members.";
            }
               else if (Role.text == "Doctor")
            {
                displayImage.sprite = Doctor;
                 Description.text = "Can save one person each night.";
            }
               else if (Role.text == "Sniper")
            {
                displayImage.sprite = Sniper;
                 Description.text = "An aggressive character who can identify and eliminate mafia members from the game, but risks losing a citizen if they make a mistake. ";
            }
               else if (Role.text == "Mayor")
            {
                displayImage.sprite = Mayor;
                 Description.text = "A person who can save players from daily execution or influence their morale by choosing individuals.";
            }
               else if (Role.text == "Citizen")
            {
                displayImage.sprite = Citizen;
                 Description.text = "Their main role in the game is reasoning and identifying mafia members through discussion.";
            }
               else if (Role.text == "Mason")
            {
                displayImage.sprite = Mason;
                 Description.text = "A special citizen who is connected with one of the other citizens and can exchange information at night. ";
            }
               else if (Role.text == "Coroner")
            {
                displayImage.sprite = Coroner;
                 Description.text = "A person who can prevent execution or death once during the game.";
            }
          
              
                
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
