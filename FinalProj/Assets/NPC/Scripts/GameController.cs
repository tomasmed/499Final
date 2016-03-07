using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public static GameController S; // Singleton class

    public int team1_pts = 0;
    public int team_2pts = 0;

    void Awake()
    {
        S = this;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
