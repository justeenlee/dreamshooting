using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;


    Text textComp;


    void Awake ()
    {
		textComp = GetComponent <Text> ();
        score = 0;
    }


    void Update ()
    {
		textComp.text = "Score: " + score;
    }
}
