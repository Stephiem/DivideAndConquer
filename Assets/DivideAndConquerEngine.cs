using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquerEngine : MonoBehaviour {

    public int Guess;
    public int Max;
    public int Min;

    // Use this for initialization
    void Start() {
        Debug.Log("Welcome to Divide And Conquer Game");
        Debug.Log("Pick a number in your mind. Let's see how good you are in hiding numbers");
        //Fancy way to format string :)
        Debug.Log(string.Format("The highest number you can pick is: {0}", Max));
        //Not Fancy way to format string :/
        Debug.Log("The lowest number you can pick is:" + Min);
        Debug.Log("Is the number > or < that" + Guess + "?");
        Debug.Log("Up arrow == >, Down arrow == <, Enter == equal");

        Debug.Log(string.Format("Up {1} {0} >{2} Down {1} {0} <{2} Enter {0} equal", ":)", "arrow", ","));

    }

    // Update is called once per frame
    void Update() {
        Engine();
    }
    void Engine() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Min = Guess;
            Algorithm();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Max = Guess;
            Algorithm();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I won!!!");
        }
    }

    void Algorithm(){

        Guess = (Max + Min) / 2;
        Debug.Log("Higher > or lower than:" + Guess + "?");
    }
}