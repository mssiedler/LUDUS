using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoverObstaculo : MonoBehaviour {


	// Use this for initialization
	public float velocidade; //velocidade do movimento do objeto
	private float eixoX;
	private float distancia;
	private float distanciaObj;
	public int posicao;
	public int valor;
	private bool parado;
	public int opcao;

	/* tipo de movimento que deve ser executando no obstáculo
	 * pode ser:
	 *   I - valor inicial de entrada do elemento
	 *   D - move a direita do centário
	 *   E - move a esquerda do cenário
	 */
	public string tipoMovimento;  





	//ADICIONADO NA PONTUAÇÃO
	public GameObject jogador;


	void Start () {
		velocidade = -0.08f;
		//ADICIONADO NA PONTUAÇÃO
		jogador = GameObject.Find ("Jogador") as GameObject;

		distancia = 1.2f;
		distanciaObj = 3.1f;
		parado = false;
		tipoMovimento = "I";

		foreach (Text item2 in transform.gameObject.GetComponentsInChildren<Text>()) {
			item2.text = posicao.ToString();
			
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!parado) {
			switch (tipoMovimento) {
			case "I":
				andarInicial();
				break;
			case "D":
				andarDireita();
				break;
			case "E":
				andarEsquerda();
				break;
			default:
				break;
			}

				//Destroy (transform.gameObject);

		}

	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			//verifica se o valor é o certo(no caso valor fixo 2)
			if(this.valor == 2)
			{
				moverObstaculos();
			}


		}
	}

	private void moverObstaculos()
	{
		//busca os objetos com a TAG obstaculo
		GameObject[] obstaculos = GameObject.FindGameObjectsWithTag ("obstaculoJogo");
		MoverObstaculo mo;


		foreach (GameObject item in obstaculos) {
			GameObject temporario = item;
			mo = temporario.GetComponent<MoverObstaculo>();
			if(mo.valor == 2)
				mo.tipoMovimento = "E";
			else
				mo.tipoMovimento = "D";

			mo.parado=false;

		}

	}

	private void andarInicial()
	{


		eixoX = transform.position.x; //posico atual do objeto
		eixoX += (velocidade + (Time.deltaTime));
		Vector3 v3 = new Vector3 (eixoX, transform.position.y, transform.position.z);
		transform.position = v3;
		
		if(eixoX <=jogador.transform.position.x+(distancia+(distanciaObj*posicao-1)))
		{
			parado = true;
		}
	}

	private void andarEsquerda()
	{
		
		eixoX = transform.position.x; //posico atual do objeto
		eixoX += (velocidade + (Time.deltaTime));
		Vector3 v3 = new Vector3 (eixoX, transform.position.y, transform.position.z);
		transform.position = v3;
		
		if(eixoX <=-14f)
		{
			Destroy (transform.gameObject);
		}
	}

	private void andarDireita()
	{
		
		eixoX = transform.position.x; //posico atual do objeto
		eixoX += (velocidade*-1 + (Time.deltaTime));
		Vector3 v3 = new Vector3 (eixoX, transform.position.y, transform.position.z);
		transform.position = v3;
		
		if(eixoX >=23f)
		{
			Destroy (transform.gameObject);
		}
	}

}
