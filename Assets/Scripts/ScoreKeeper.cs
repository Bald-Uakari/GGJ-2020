using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    // Scoreboard will render with the GUI. Add a point by calling `ScoreKeeper.Score++;` inside the event.

    private int _score;
    public int Score() 
    {
        return _score;
    }

    void Awake()
    {
        _score = 0;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 25), "Score: " + _score);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScoreToZero()
    {
        _score = 0;
    }

    public void AddPointsToScore(int changeInPoints)
    {
        _score += changeInPoints;
    }

    public void SubtractPointsFromScore(int changeInPoints)
    {
        _score += changeInPoints;
    }

}

/**
public ScoreKeeper : MonoBehaviour
 {
      public static int Score;
      
      void Awake()
      {
           Score = 0;
      }
 
     void OnGUI()
     {
         GUI.Label(new Rect(0, 0, 100, 25), "Score: " + Score);
     }
 }
*/