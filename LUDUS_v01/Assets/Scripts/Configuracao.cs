using UnityEngine;
using System.Collections;

public class Configuracao : MonoBehaviour {

	// Use this for initialization
	public int pontuacao;
	public Sprite obstaculo;
	public Sprite boneco;
	public Sprite cenario;

	void Start () {
		string obstaculoPreferecial = PlayerPrefs.GetString ("obstaculo");
		//gambiarra quando eu acessar direto as fase
		if (obstaculoPreferecial == null) {
			obstaculoPreferecial = "";
		}
		if (obstaculoPreferecial.Equals ("Espinho")) {
			this.obstaculo = Resources.Load <Sprite> ("Sprites/obstaculo");

				
		} else {
			this.obstaculo = Resources.Load <Sprite> ("Sprites/obstaculopreto");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
