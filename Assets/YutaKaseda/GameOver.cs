using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("GameOver");
            Debug.Log("今回のスコア:" + PlayerPrefs.GetInt("Score"));
            Debug.Log("HighScore:" + PlayerPrefs.GetInt("HighScore"));

        }
    }
}
