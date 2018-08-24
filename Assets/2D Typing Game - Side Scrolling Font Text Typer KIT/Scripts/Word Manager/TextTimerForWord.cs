using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimerForWord : MonoBehaviour {

	public WordManager wordManager;

	public float DelayForEachWord = 4f;
	private float nextWordTime = 3.5f; // задержка первого слова 

	private void Update()
	{
		if (Time.time >= nextWordTime)
		{
			wordManager.AddWord();
			nextWordTime = Time.time + DelayForEachWord;
			DelayForEachWord *= .975f;
		}
	}

}
