using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuMorpion : MonoBehaviour {

    private static int MAX_LIGNES = 3;
    private static int MAX_COLONNES = 3;

    private enum Couleurs
    {
        VIDE,
        ROND,
        CROIX
    }
     

    //private enum Joueurs
    private Couleurs[][] grille = new Couleurs[MAX_LIGNES][];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool placerUneCroix(int ligne, int colonne)
    {
        return placerUnCoup(ligne, colonne, Couleurs.CROIX);
    }

    public bool placerUnRond(int ligne, int colonne)
    {
        return placerUnCoup(ligne, colonne, Couleurs.ROND);
    }

    private void initialisationGrille()
    {
        for(int i = 0; i < MAX_LIGNES; i ++)
        {
            grille[i] = new Couleurs[MAX_COLONNES];
            for(int j = 0; j < MAX_COLONNES; j++)
            {
                grille[i][j] = Couleurs.VIDE;
            }
        }
    }

    private bool placerUnCoup(int ligne, int colonne, Couleurs coup)
    {
        if(ligne < 0 || ligne > MAX_LIGNES || colonne < 0 || colonne > MAX_COLONNES)
        {
            return false;
        }

        if(grille[ligne][colonne] == Couleurs.VIDE)
        {
            grille[ligne][colonne] = coup;
            return true;
        }
        else
        {
            return false;
        }
    }

    private Couleurs GagnantJeu()
    {
        for(int i = 0; i < MAX_LIGNES; i++)
        {
            for(int j = 0; j < MAX_COLONNES; j++)
            {
                if(grille[i][j]!= Couleurs.VIDE)
                {

                }
            }
        }
    }

    private Coul
}
