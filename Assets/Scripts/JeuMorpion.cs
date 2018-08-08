using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuMorpion : MonoBehaviour {

    private const int MAX_LIGNES = 3;
    private const int MAX_COLONNES = 3;

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
    
    // Permet a un des joueur de placer une croix a la position indiqué
    public bool placerUneCroix(int ligne, int colonne)
    {
        return placerUnCoup(ligne, colonne, Couleurs.CROIX);
    }

    // Permet a un des joueur de placer un rond a la position indiqué
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

    private Couleurs Gagnant()
    {
        for(int i = 0; i < MAX_LIGNES; i++)
        {
            for(int j = 0; j < MAX_COLONNES; j++)
            {
                if(TrouveAlignement(grille[i][j],i,j))
                {
                    return grille[i][j];
                }
            }
        }
        return Couleurs.VIDE;
    }

    private bool TrouveAlignement(Couleurs couleur, int posX, int posY)
    {
         int nbCouleursPareil = 0;
         if(posX == 0)
         {
            // Check les 3 colonnes en partant du haut
            for(int j= 0; j < MAX_COLONNES; j++)
            {
                for (int i = 0; i < MAX_LIGNES; i++)
                {
                    if (grille[i][j] == couleur)
                        nbCouleursPareil++;
                }
                if (nbCouleursPareil == 3)
                    return true;
                else
                    nbCouleursPareil = 0;
            }

            // Check la premiere diagonale en partant de la gauche
            for(int i =0; i < MAX_COLONNES; i++)
            {
                if (grille[i][i] == couleur)
                    nbCouleursPareil++;
            }
            if (nbCouleursPareil == 3)
                return true;
            else
                nbCouleursPareil = 0;

            // Check la deuxieme diagonale en partant de la droite
            for(int j = 0; j< MAX_LIGNES; j++)
            {
                for(int i = MAX_COLONNES - 1; i >= 0; i--)
                {
                    if (grille[j][i] == couleur)
                        nbCouleursPareil++;
                }
            }
            if (nbCouleursPareil == 3)
                return true;
            else
                nbCouleursPareil = 0;
         }

         if(posY == 0)
        {
            // Check les 3 colonnes en partant du haut
            for (int j = 0; j < MAX_LIGNES; j++)
            {
                for (int i = 0; i < MAX_COLONNES; i++)
                {
                    if (grille[j][i] == couleur)
                        nbCouleursPareil++;
                }
                if (nbCouleursPareil == 3)
                    return true;
                else
                    nbCouleursPareil = 0;
            }
        }

        return false;
    }
}
