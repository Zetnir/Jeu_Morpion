using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public static UIManager instance;

    private List<Button> cases;


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

    private void initialiserBoutons()
    {
        int i = 1;
        while(GameObject.Find("Btn_Grille" + i))
        {
            cases.Add(GameObject.Find("Btn_Grille" + i).GetComponent<Button>());
            i++;
        }
    }


}
