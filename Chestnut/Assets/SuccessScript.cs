using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessScript : MonoBehaviour
{
    public void ToMenu (){
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void RestartGame (){
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
