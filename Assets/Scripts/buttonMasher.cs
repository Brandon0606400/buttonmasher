using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

	} // End of start
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update method called");
    } // End of update

    // Responds to event from unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        // Trigger the clicking sound to play
        clickSound.Play();
    } // End of OnMouseDown

} // End of buttonMasher class
