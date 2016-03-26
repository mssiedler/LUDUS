using UnityEngine;
using System.Collections;

public class MoverCenario : MonoBehaviour {

	// Use this for initialization
	public Material  materialAtual; //qual material usado no objeto
	public float velocidade;
	private float eixoX;
	Vector2 vetorposiciona;
	void Start () {
		velocidade = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
		eixoX = velocidade + Time.deltaTime;
		//Alterar o posicionamento da textura (fazer andar)
		vetorposiciona = new Vector2 (eixoX, 0);
		materialAtual.SetTextureOffset("_MainTex",vetorposiciona);
	}
}
