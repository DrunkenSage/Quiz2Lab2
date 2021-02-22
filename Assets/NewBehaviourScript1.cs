using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
   
 public InputField playerNameInput;
 public InputField playerInputAge;
 public string playerName;
 public int playerAge;

 public void setName()
 {
    playerName = playerNameInput.text;
   
 }

 public void SetAge()
 {
    playerAge =  int.Parse(playerInputAge.text);
    Debug.Log(playerAge);
 }

 public void StartGame()
 {
    PlayerPrefs.SetString("ThisPlayer", playerName);
    PlayerPrefs.SetInt("ThisAge", playerAge);
    SceneManager.LoadScene("New Scene");
 }
    
}
