using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonE : MonoBehaviour
{
    private void goAlex()
    {

        SceneManager.LoadScene("alex");



    }
    private void gozombiBilgi()
    {



        SceneManager.LoadScene("zombiBilgi");
    }

    private void endgame()
    {

        SceneManager.LoadScene("credits");
        
    }

    

}
