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
	private Pergunta perg;


	void Start () {
		perg = FindObjectOfType (typeof(Pergunta)) as Pergunta;
		conf = FindObjectOfType (typeof(Configuracao)) as Configuracao;

		posicao = -1.1f;
		intervalo = 2.0f;

		carregarObjetos ();



	}


	private void carregarObjetos()
	{
		perg.exibeTitulo ();
		SpriteRenderer sr;
		for (int i = 1; i < 4; i++) {
			
			GameObject temporario = Instantiate(obstaculoCompleto) as GameObject;
			sr = temporario.GetComponent<SpriteRenderer>();
			sr.sprite = conf.obstaculo;
			//sr.sprite
			
			MoverObstaculo  mo = temporario.GetComponent<MoverObstaculo>();
			mo.posicao = i;
			temporario.transform.position = 
				new Vector3 (transform.position.x, posicao, transform.position.z);
			
			
		}	
	}

	// Update is called once per frame
	void Update () {

		if (GameObject.FindGameObjectsWithTag ("obstaculoJogo").Length == 0) {

			carregarObjetos();
		}

	}




}
