using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddObject : MonoBehaviour {

	public GameObject  obstaculoCompleto;
	public float       intervalo;
	
	//private float      tempoAtual;

	private float      posicao;
	private float      eixoY;

	private Text     texto;

	private Configuracao conf;


	private bool trigger;
	// Use this for initialization
	void Start () {

		conf = FindObjectOfType (typeof(Configuracao)) as Configuracao;

		posicao = -1.1f;
		intervalo = 2.0f;

		

		SpriteRenderer sr;
		trigger = true;
		for (int i = 1; i < 4; i++) {

				GameObject temporario = Instantiate(obstaculoCompleto) as GameObject;
				sr = temporario.GetComponent<SpriteRenderer>();
				sr.sprite = conf.obstaculo;
				//sr.sprite
		
				MoverObstaculo  mo = temporario.GetComponent<MoverObstaculo>();
				mo.posicao = i;
				mo.valor = i;
				temporario.transform.position = 
				new Vector3 (transform.position.x, posicao, transform.position.z);


		}

	}


	
	// Update is called once per frame
	void Update () {

	}




}
