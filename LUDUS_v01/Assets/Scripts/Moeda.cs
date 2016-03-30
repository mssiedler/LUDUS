using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Moeda : MonoBehaviour {

	public int dinheiro;

	void Start () 
	{
		this.dinheiro = 50;
	}
	
	public void adicionaValor(int valor)
	{
		dinheiro = dinheiro + valor;
	}

	public void retiraValor(int valor)
	{
		dinheiro = dinheiro - valor;
	}

	public int retornaValor()
	{
		return dinheiro;
	}
}