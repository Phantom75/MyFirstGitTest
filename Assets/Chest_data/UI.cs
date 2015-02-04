using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnGUI()
    {
        if (GUILayout.Button("Open Chest"))
        {
            transform.animation.Play("Chest_Open");
        }

        if (GUILayout.Button("Close Chest"))
        {
            transform.animation.Play("Chest_Close");
        }
    }
}
