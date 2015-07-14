using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI () {

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 3, Screen.width / 5, Screen.height / 10), "Start the Game")) {

			Application.LoadLevel ("SlingshooterScene");

		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2, Screen.width / 5, Screen.height / 10), "erm...no?")) {
			
			Application.LoadLevel ("Start...?");
			
		}

	}
}
