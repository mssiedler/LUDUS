using UnityEngine;
using System.Collections;

public class IniciarJogo : MonoBehaviour {

	// Use this for initialization

	void Start () {
	
	}
	



	public void EscolherCenario (string texto) {
		PlayerPrefs.SetString ("obstaculo", texto);
		
		Application.LoadLevel("fase1");
		
	}
}
