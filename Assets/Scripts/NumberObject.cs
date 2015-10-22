using UnityEngine;
using System.Collections;

public class NumberObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collision2D = Physics2D.OverlapPoint(tapPoint);
			if(collision2D) {
				RaycastHit2D hitObject = Physics2D.Raycast(tapPoint, -Vector2.up);
				if(hitObject) {
					Debug.Log("hit object is " + hitObject.collider.gameObject.name);
				}
			}
		}
	}
}
