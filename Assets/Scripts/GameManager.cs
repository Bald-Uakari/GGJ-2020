using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
     List<Transform> _wayPoints;
    public List<Transform> Waypoints { get { return _wayPoints; } set { _wayPoints = value; } }
 
    static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;
            }
            return _instance;
        }
        set { _instance = value; }
    }
 
    void Awake()
    {
        Instance = this;      
     }
 
     void Start()
     {
        // Initialise waypoints here
        // _waypoints =

     }
}
