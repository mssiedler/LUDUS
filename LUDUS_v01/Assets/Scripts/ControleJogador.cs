using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class ControleJogador : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D corpoJogador;
	public int forcaPulo;

	public Animator animador;



	public bool pisandoNoChao;
	public LayerMask oQueEChao;
	public Transform checarChao;




	public Transform colisor;

	 

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//Vector3 v3 = new Vector3(colisor.position.x, colisor.position.y+quantoabaixar, colisor.position.z);


	}

	void OnTriggerEnter2D()
	{


		//Application.LoadLevel("gameover");

	}
}
