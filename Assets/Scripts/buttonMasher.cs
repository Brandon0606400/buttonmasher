using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click
    public TextMesh scoreText; // display text for the player's score

    private int score = 0; // The numerical data value of the score

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
        // increase the score by 1
        score = score + 1;
        // update visual score
        scoreText.text = score.ToString();
    } // End of OnMouseDown

} // End of buttonMasher class
