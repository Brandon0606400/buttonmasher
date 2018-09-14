using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click
    public TextMesh scoreText; // display text for the player's score
    public TextMesh timeText; // display text for the player's time
    public float gameLength; // how many seconds the game will last
    public AudioSource gameOverSound; // sound that will play when it game overs
    public TextMesh messageText; // display text for the player's time

    private int score = 0; // The numerical data value of the score
    private float timeRemaining = 0; // The numerical data value of the time
    private bool gameRunning = false;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

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

            if (gameRunning == true)
            {
                Debug.Log("Attempting to play game over");

                // play the game over sound
                gameOverSound.Play();

                //show the player their score
                messageText.text = "Time up! Final Score = " + score.ToString();
            } // End of (gameRunning == true)

            //stop the game running
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
        else
        {
            //game is not running and we click the button
            gameRunning = true;

            //Set the timer to the full length of the game
            timeRemaining = gameLength;

            messageText.text = "Mash the button!";

            //reset the score
            score = 0;

            // update visual score
            scoreText.text = score.ToString();

        } //End of game else
    } // End of OnMouseDown

} // End of buttonMasher class
