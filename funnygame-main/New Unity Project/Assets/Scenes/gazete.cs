using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gazete : MonoBehaviour
{
    public int sahne; 
    public float zaman;
    public float süre;
    public int sayac;
    // Update is called once per frame






    private void Start()
    {
        sayac = 0;
    }
    void FixedUpdate()
    {
        zaman += Time.deltaTime;
        if (zaman > süre)
        {
            if (sayac == 0)
            {
                if (sahne == 1)
                {

                  camiyeGec();

                }
                else if(sahne == 2)
                {



                    detroiteGec();


                }
                /*else if (sahne == 3)
                {

                    creditseGec();


                }*/
                else if(sahne == 4)
                {

                    zombiyeGec();


                }
               
                sayac++;

            }
          
            
        }
    }

    private void camiyeGec()
    {

        SceneManager.LoadScene("cami");



    }

       private void detroiteGec()
    {

        SceneManager.LoadScene("Detroid");

    }

    private void zombiyeGec()
    {

        SceneManager.LoadScene("zombi");


    }





}
