using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = { "расчет", "производится", "помощью", "скоринговой", "модели", "которая", "учитывает", "множество", "параметров", "каждому", "клиентов", "формирует", "профиль" };

    private static string[] wordListUa = { "використовуємо", "індивідуальний", "підхід", "встановленні", "кредитного", "ліміту", "кожного", "клієнта", "розрахунок", "проводиться", "допомогою", "скорингової", "моделі", "враховує", "безліч", "параметрів", "кожному", "клієнтів", "формує", "профіль" };

    public static string GetRandomWord()
    {
        int langProv = 0;

        langProv = EasyGameMode.lang;
        //int langProv2 = NormalGameMode.lang;


        if (langProv == 1)
        {
            int randomIndex = Random.Range(0, wordListUa.Length);
            string randomWord = wordListUa[randomIndex];

            return randomWord;
        }
        else
        {
                int randomIndex = Random.Range(0, wordList.Length);
                string randomWord = wordList[randomIndex];

                return randomWord;
           
        }
        // return randomWord;
    }


    
}
