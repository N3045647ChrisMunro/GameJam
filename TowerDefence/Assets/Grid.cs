using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public GameObject side;
	public CubeSide[] worldCube;
	private const int numSides_ = 6;

	// Use this for initialization
	void Awake () {

		//worldCube = new GameObject[numSides_];
		Vector3 testPos = new Vector3 (0, 0, 0);
		Vector3 testRot = new Vector3 (0, 0, 0);
		GameObject newSide = Instantiate(side, testPos, this.transform.rotation) as GameObject;

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
