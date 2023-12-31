﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúPrincipal : MonoBehaviour {
    public string GameScene;
    public GameObject Creditos;
    public GameObject Niveles;
    public AudioSource FoleyPlayer;
    public AudioSource MenuOSTPlayer;

    public void GoToInfinito()
    {
        FoleyPlayer.Play();
        SceneManagerController.Instance.LoadScene("Infinito");
    }

    public void Exit()
    {
        FoleyPlayer.Play();
        Application.Quit();
    }

    public void FuncCreditos()
    {
        FoleyPlayer.Play();
        Creditos.SetActive(true);
    }
    
    public void Load1() { 
        FoleyPlayer.Play();
        Debug.Log("Load1");
        SceneManagerController.Instance.LoadScene("Level1");
        SceneManager.LoadScene("Level1");
        }
    public void Load2() { 
        FoleyPlayer.Play();
        SceneManagerController.Instance.LoadScene("Level2");
        SceneManager.LoadScene("Level2");
    }
    public void Load3() { 
        FoleyPlayer.Play();
        SceneManagerController.Instance.LoadScene("Level3");
        SceneManager.LoadScene("Level3");
    }
    public void Load4() { 
        FoleyPlayer.Play();
        SceneManagerController.Instance.LoadScene("Level4");
        SceneManager.LoadScene("Level4");
    }
    public void Load5() { FoleyPlayer.Play();
    SceneManagerController.Instance.LoadScene("Level5");
        SceneManager.LoadScene("Level5");
    }
    public void Load6() { 
        FoleyPlayer.Play();
        SceneManagerController.Instance.LoadScene("Level6");
        SceneManager.LoadScene("Levell6");
    }

        public void Jugar()
        {
            FoleyPlayer.Play();
            Niveles.SetActive(true);
            //SceneManagerController.Instance.LoadScene("Level1");
    }

    public void Atras()
    {
        FoleyPlayer.Play();
        Niveles.SetActive(false);
    }
}
