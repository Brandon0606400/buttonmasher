using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click
    public TextMesh scoreText; // display text for the player's score
    public TextMesh timeText; // display text for the player's time
    public float gameLength; // how many seconds the game will last

    private int score = 0; // The numerical data value of the score
    private float timeRemaining = 0; // The numerical data value of the time
    private bool gameRunning = true;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

        timeRemaining = gameLength;
	} // End of start
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update method called");

        // update the numerical time remaining
        timeRemaining = timeRemaining - Time.deltaTime;

        // update the visual time remaining
        timeText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        // Check to see if we have run out of time
        if (timeRemaining <= 0)
        {
            gameRunning = false;

            //Stop out game from going negative
            timeRemaining = 0;
        } // end of if timeRunning

    } // End of update

    // Responds to event from unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");

        //Check to see if game is still running
        if(gameRunning == true)
        {
            // Trigger the clicking sound to play
            clickSound.Play();
            // increase the score by 1
            score = score + 1;
            // update visual score
            scoreText.text = score.ToString();
        } //End of if(gameRunning == true)
        
    } // End of OnMouseDown

} // End of buttonMasher class
