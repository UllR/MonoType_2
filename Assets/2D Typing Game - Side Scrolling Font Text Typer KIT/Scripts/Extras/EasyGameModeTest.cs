using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EasyGameModeTest : MonoBehaviour
{
    public static int lang = 0;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown()
    {
        //Application.LoadLevel(Application.loadedLevel+1);
        SceneManager.LoadScene(+1);
        
    }
}
