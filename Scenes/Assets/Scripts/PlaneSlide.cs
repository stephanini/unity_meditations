using UnityEngine;
using System.Collections;

public class PlaneSlide : MonoBehaviour {
	public float moveDist;

	// Use this for initialization
	void Start () {
			iTween.MoveBy(gameObject, iTween.Hash("x", moveDist, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
		}
	}
