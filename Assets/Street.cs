using UnityEngine;
using System.Collections;

public class Street : MonoBehaviour {

    public string identifier = "undefineds";
    public StreetType type;
    

	// Use this for initialization
	void Start () {
        Debug.Log(identifier);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log(identifier);
        }
    }
}
