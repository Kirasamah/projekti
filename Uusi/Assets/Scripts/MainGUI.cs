using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class MainGUI : MonoBehaviour {

	// Use this for initialization
	void OnGUI () 
	{
		GUILayout.BeginHorizontal ();
		GUILayout.Label ("Bye cruel world");
		GUILayout.EndHorizontal ();
	}

}
