using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    [SerializeField]
    float speed = 0.2f;

    int count = 0;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Score", 0);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed,0,0));
	}

    void OnCollisionEnter(Collision other){

        if (other.gameObject.tag == "Ball")
        {
            count++;
            PlayerPrefs.SetInt("Score", count);

            if(PlayerPrefs.GetInt("HighScore") < count)
            {
                PlayerPrefs.SetInt("HighScore", count);
            }

            Debug.Log(count);
            Destroy(other.gameObject);
        }
    }

}
