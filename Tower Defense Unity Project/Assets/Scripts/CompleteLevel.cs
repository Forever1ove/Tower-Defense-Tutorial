using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CompleteLevel : MonoBehaviour {

	public string menuSceneName = "MainMenu";

    public int gameLevel;
	public string nextLevel = "Level02";
    public string nextLevel2 = "Level03";
    public string nextLevel3 = "Level04";
    public int levelToUnlock = 4;

	public SceneFader sceneFader;

	public void Continue ()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock);
		sceneFader.FadeTo(nextLevel);

        

            
        //SceneManager.LoadScene(gameLevel);
        


    }

	public void Menu ()
	{
		sceneFader.FadeTo(menuSceneName);
	}

}
