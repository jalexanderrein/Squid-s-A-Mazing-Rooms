using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

//	public Maze mazePrefab;

//	public Player playerPrefab;

//	private Maze mazeInstance;

//	private Player playerInstance;
	private Vector3 defaultPos;
	private Quaternion defaultRot;
	private Vector3 defaultScale;

	private void Awake ()
    {
        Debug.Log("Awake called.");
		defaultPos = transform.position;
		defaultRot = transform.rotation;
		defaultScale = transform.localScale;
	}
    
    
    private void Start ()
    {
        Debug.Log("Start called.");
		defaultPos = transform.position;
		defaultRot = transform.rotation;
		defaultScale = transform.localScale;
    }
	
	//private void Update () {
	//	if (Input.GetKeyDown(KeyCode.Space)) {
	//		RestartGame();
	//	}
	//}

	

	//private void RestartGame () {
	//	Debug.Log("Restart called.");
	//	transform.position = defaultPos;
	//	transform.rotation = defaultRot;
	//	transform.localScale = defaultScale;
	//}
}