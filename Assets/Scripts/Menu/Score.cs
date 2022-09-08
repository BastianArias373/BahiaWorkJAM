using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform avancePlayer;
    private Vector3 vectorPosicion;
    public TMP_Text score;


    private void Awake()
    {
        vectorPosicion.x = Mathf.Abs(avancePlayer.position.normalized.x);
    }
    void Update()
    {
        vectorPosicion.x = Mathf.Round(avancePlayer.position.x + 6);
        score.text = "score: " + vectorPosicion.x * 2 + " Mts";
    }
}
