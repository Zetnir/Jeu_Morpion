using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private enum GameState
    {
        MENU,
        INGAME,
        ENDGAME
    }
    private GameState gameState;

    public static GameManager instance;

    void Awake()
    {
        if (!instance)
            instance = this;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LancerJeu()
    {

    }
}
