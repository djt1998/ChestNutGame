using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuScript : MonoBehaviour
{
    public void PlayGame (){
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
