using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGeneratorUa : MonoBehaviour {

	private static string[] wordListUa = {   "walking",    };

	public static string GetRandomWordUa ()
	{
		int randomIndex = Random.Range(0, wordListUa.Length);
		string randomWordUa = wordListUa[randomIndex];

		return randomWordUa;
	}

}
