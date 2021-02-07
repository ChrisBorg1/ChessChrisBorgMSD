using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public static bool traditionalbtn = false;
    public static bool roboticbtn = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    public void TraditionalGame()
    {
        traditionalbtn = true;
        SceneManager.LoadScene(1);
    }

    public void RoboticGame()
    {
        roboticbtn = true;
        SceneManager.LoadScene(1);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
