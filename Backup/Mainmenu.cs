/// q: sample code for main menu    ///

using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle buttonStyle;
	public GUIStyle titleStyle;

	void OnGUI(){
		//display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		//display title
		GUI.Label(new Rect(Screen.width/2-100,Screen.height/2-300,200,100),"Pirate's Life",titleStyle);

		//display buttons
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2-100,200,50),"Start Game",buttonStyle)){
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2-25,200,50),"Options",buttonStyle)){
			Application.LoadLevel(2);
		}
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2+50,200,50),"Credits",buttonStyle)){
			Application.LoadLevel(3);
		}
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2+125,200,50),"Exit Game",buttonStyle)){
			Application.Quit();
		}
	}
}
