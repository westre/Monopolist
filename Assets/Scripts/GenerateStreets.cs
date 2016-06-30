using UnityEngine;
using System.Collections;

public class GenerateStreets : MonoBehaviour {

    public GameObject cornerStreet;
    public GameObject street;

	// Use this for initialization
	void Start () {
        InitializeCornerStreets();
        InitializeStreets();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void InitializeCornerStreets() {
        // Go
        GameObject go = Instantiate(cornerStreet, new Vector3(-4.359f, 0.05f, 4.356f), Quaternion.identity) as GameObject;
        go.transform.parent = gameObject.transform;

        // In jail/just visiting
        go = Instantiate(cornerStreet, new Vector3(4.359f, 0.05f, 4.356f), Quaternion.identity) as GameObject;
        go.transform.parent = gameObject.transform;

        // Free parking
        go = Instantiate(cornerStreet, new Vector3(4.359f, 0.05f, -4.356f), Quaternion.identity) as GameObject;
        go.transform.parent = gameObject.transform;

        // Go to jail
        go = Instantiate(cornerStreet, new Vector3(-4.359f, 0.05f, -4.356f), Quaternion.identity) as GameObject;
        go.transform.parent = gameObject.transform;
    }

    private void InitializeStreets() {
        float startPos = -3.309f;
        for(int index = 0; index < 9; index++) {
            GameObject go = Instantiate(street, new Vector3(startPos, 0.05f, 4.356f), Quaternion.identity) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos += 0.830f;
        }

        startPos = 3.307f;
        for (int index = 0; index < 9; index++) {
            GameObject go = Instantiate(street, new Vector3(4.358f, 0.05f, startPos), Quaternion.Euler(new Vector3(0, 270, 0))) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos -= 0.830f;
        }

        startPos = 3.309f;
        for (int index = 0; index < 9; index++) {
            GameObject go = Instantiate(street, new Vector3(startPos, 0.05f, -4.356f), Quaternion.identity) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos -= 0.830f;
        }

        startPos = -3.307f;
        for (int index = 0; index < 9; index++) {
            GameObject go = Instantiate(street, new Vector3(-4.358f, 0.05f, startPos), Quaternion.Euler(new Vector3(0, 270, 0))) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos += 0.830f;
        }
    }
}
