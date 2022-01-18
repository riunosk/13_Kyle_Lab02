using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndController : MonoBehaviour
{
    public GameObject RedWin;
    public GameObject GreenWin;

    // Update is called once per frame
    void Update()
    {
        if (Controller.Winner == 1)
		{
            RedWin.SetActive(true);
		}
        if (Controller.Winner == 2)
		{
            GreenWin.SetActive(true);
		}
        if (Input.GetKeyDown(KeyCode.Space))
		{
            SceneManager.LoadScene("Main");
		}
    }
}
