using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Teste : MonoBehaviour {

	// Use this for initialization
	GameObject item;
	void Start () {
		item = transform.gameObject;
		foreach (Text item2 in item.GetComponentsInChildren<Text>()) {
			Debug.Log (item2.text);

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
