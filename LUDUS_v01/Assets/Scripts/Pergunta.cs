using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
//GIT
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

	public Pergunta(string quest,int rA, int rB, int rC, int correta, int niv)
	{
		questoes = quest;
		respA = rA;
		respB = rB;
		respC = rC;
		certa = correta;
		nivel = niv;
	}




	void Start () {
		perguntas = new List<Pergunta>();
		idPergunta = 0;
		perguntas.Add(new Pergunta("5+4=?",1,9,7,9,1));
		perguntas.Add(new Pergunta("3+2=?",4,1,5,5,1));
		perguntas.Add(new Pergunta("1+1=?",2,0,4,2,1));
		perguntas.Add(new Pergunta("5+4=?",1,9,7,9,2));
		perguntas.Add(new Pergunta("3+2=?",4,1,5,5,2));
		perguntas.Add(new Pergunta("1+1=?",2,0,4,2,2));

	}

	public void trocaOperacao()
	{

			nivel += 1;
			idPergunta = 0;

	}

	void proximaPergunta()
	{
		if (this.idPergunta == 3) 
		{
			trocaOperacao();
		}
		else
		{
			idPergunta += 1;

		}


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