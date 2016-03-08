using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

    [SerializeField]
    GameObject ball;

    [SerializeField]
    float position = 1;

	// Use this for initialization
	void Start () {
        StartCoroutine(BallFactory());
	}

    IEnumerator BallFactory()
    {
        while (true)
        {
            Instantiate(ball,new Vector3(Random.Range(-position,position),10,0),transform.rotation);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
