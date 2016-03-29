using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Pergunta : MonoBehaviour {
	public Text pergunta;


	public int idPergunta;
	public string questoes;
	public int respA;
	public int respB;
	public int respC;
	public int certa;
	public List<Pergunta> perguntas;
	public int nivel;

	public Pergunta(string quest,int rA, int rB, int rC, int correta)
	{
		questoes = quest;
		respA = rA;
		respB = rB;
		respC = rC;
		certa = correta;
	}




	void Start () {
		perguntas = new List<Pergunta>();
		idPergunta = 0;
		perguntas.Add(new Pergunta("5+4=?",9,1,7,9));
		perguntas.Add(new Pergunta("3+2=?",4,1,5,5));
		perguntas.Add(new Pergunta("1+1=?",2,0,4,2));


	}


	void proximaPergunta()
	{
		idPergunta += 1;


	}

	public void exibeTitulo()
	{
		pergunta.text = perguntas[idPergunta].questoes;
	}

	public bool verificaResposta(string alternativa)
	{
		bool certa = false;
		switch (alternativa) {
		case "A": 
			if(perguntas[idPergunta].certa == perguntas[idPergunta].respA)
				{
					proximaPergunta();
					certa = true;
				}
			break;
		case "B":
			if(perguntas[idPergunta].certa == perguntas[idPergunta].respB)
			{
				proximaPergunta();
				certa = true;
			}

				break;
		case "C": 
			if(perguntas[idPergunta].certa == perguntas[idPergunta].respC)
			{
				proximaPergunta();
				certa = true;
			}

				break;
		}
		return certa;
	}
}