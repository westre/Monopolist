using UnityEngine;
using System.Collections;

public class GenerateStreets : MonoBehaviour {

    private StreetManager streetManager;

    public GameObject cornerStreet;
    public GameObject street;

    private object[,] streetData;

	// Use this for initialization
	void Start () {
        streetManager = gameObject.GetComponent<StreetManager>();

        InitializeStreetData();
        InitializeCornerStreets();
        InitializeStreets();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void InitializeStreetData() {
        streetData = new object[,] {
            { "Old Kent Road", StreetType.GENERIC, streetManager.brownGroup, 60, 30, 10, 30, 90, 160, 250 },
            { "Community Chest", StreetType.COMMUNITY_CHEST, null, null, null, null, null, null, null, null },
            { "Whitechapel Road", StreetType.GENERIC, streetManager.brownGroup, 60, 30, 20, 60, 180, 320, 450 },
            { "Income Tax", StreetType.INCOME_TAX, null, null, null, null, null, null, null, null },
            { "Kings Cross Station", StreetType.STATION, null, null, null, null, null, null, null, null },
            { "The Angel Islington", StreetType.GENERIC, streetManager.cyanGroup, 100, 50, 30, 90, 270, 400, 550 },
            { "Chance", StreetType.CHANCE, null, null, null, null, null, null, null, null },
            { "Euston Road", StreetType.GENERIC, streetManager.cyanGroup, 100, 50, 30, 90, 270, 400, 550 },
            { "Pentonville Road", StreetType.GENERIC, streetManager.cyanGroup, 120, 60, 40, 100, 300, 450, 600 },
            { "Pall Mall", StreetType.GENERIC, streetManager.purpleGroup, 140, 70, 50, 150, 450, 625, 750 },
            { "Electric Company", StreetType.ELECTRIC_COMPANY, null, null, null, null, null, null, null, null },
            { "Whitehall", StreetType.GENERIC, streetManager.purpleGroup, 140, 70, 50, 150, 450, 625, 750 },
            { "Northumberland Avenue", StreetType.GENERIC, streetManager.purpleGroup, 160, 80, 60, 170, 500, 700, 900 },
            { "Marylebone Station", StreetType.STATION, null, null, null, null, null, null, null, null },
            { "Bow Street", StreetType.GENERIC, streetManager.orangeGroup, 180, 90, 70, 200, 550, 750, 950 },
            { "Community Chest", StreetType.COMMUNITY_CHEST, null, null, null, null, null, null, null, null },
            { "Marlborough Street", StreetType.GENERIC, streetManager.orangeGroup, 180, 90, 70, 200, 550, 750, 950 },
            { "Vine Street", StreetType.GENERIC, streetManager.orangeGroup, 200, 100, 80, 220, 600, 800, 1000 },
            { "The Strand", StreetType.GENERIC, streetManager.redGroup, 220, 110, 90, 250, 700, 875, 1050 },
            { "Chance", StreetType.CHANCE, null, null, null, null, null, null, null, null },
            { "Fleet Street", StreetType.GENERIC, streetManager.redGroup, 220, 110, 90, 250, 700, 875, 1050 },
            { "Trafalgar Square", StreetType.GENERIC, streetManager.redGroup, 240, 120, 100, 300, 750, 925, 1100 },
            { "Fenchurch St Station", StreetType.STATION, null, null, null, null, null, null, null, null },
            { "Leicester Square", StreetType.GENERIC, streetManager.yellowGroup, 260, 130, 110, 330, 800, 975, 1150 },
            { "Coventry Street", StreetType.GENERIC, streetManager.yellowGroup, 260, 130, 110, 330, 800, 975, 1150 },
            { "Water Works", StreetType.WATER_WORKS, null, null, null, null, null, null, null, null },
            { "Piccadilly", StreetType.GENERIC, streetManager.yellowGroup, 280, 140, 120, 360, 850, 1025, 1200 },
            { "Regent Street", StreetType.GENERIC, streetManager.greenGroup, 300, 150, 130, 390, 900, 1100, 1275 },
            { "Oxford Street", StreetType.GENERIC, streetManager.greenGroup, 300, 150,120, 390, 900, 110, 1275 },
            { "Community Chest", StreetType.COMMUNITY_CHEST, null, null, null, null, null, null, null, null },
            { "Bond Street", StreetType.GENERIC, streetManager.greenGroup, 320, 160, 150, 450, 1000, 1200, 1400 },
            { "Liverpool Street Station", StreetType.STATION, null, null, null, null, null, null, null, null },
            { "Park Lane", StreetType.GENERIC, streetManager.blueGroup, 350, 175, 175, 500, 1100, 1300, 1500 },
            { "Super Tax", StreetType.SUPER_TAX, null, null, null, null, null, null, null, null },
            { "Mayfair", StreetType.GENERIC, streetManager.blueGroup, 400, 200, 200, 600, 1400, 1700, 2000 },
        };
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
            Debug.Log(index);
        }

        startPos = 3.307f;
        for (int index = 9; index < 18; index++) {
            GameObject go = Instantiate(street, new Vector3(4.358f, 0.05f, startPos), Quaternion.Euler(new Vector3(0, 270, 0))) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos -= 0.830f;
            Debug.Log(index);
        }

        startPos = 3.309f;
        for (int index = 18; index < 27; index++) {
            GameObject go = Instantiate(street, new Vector3(startPos, 0.05f, -4.356f), Quaternion.identity) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos -= 0.830f;
            Debug.Log(index);
        }

        startPos = -3.307f;
        for (int index = 27; index < 36; index++) {
            GameObject go = Instantiate(street, new Vector3(-4.358f, 0.05f, startPos), Quaternion.Euler(new Vector3(0, 270, 0))) as GameObject;
            go.transform.parent = gameObject.transform;
            startPos += 0.830f;
            Debug.Log(index);
        }
    }
}
