using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject Cube6;
    public GameObject Cube7;
    public GameObject Cube8;
    public GameObject Cube9;

    private int Player = 1;
    private Color TurnColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        Cube1.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube2.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube3.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube4.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube5.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube6.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube7.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube8.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube9.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        print(Player);
        if (Player == 1)
		{
            TurnColor = Color.red;
		}
        if (Player == 2)
		{
            TurnColor = Color.green;
		}
        if (Input.GetKeyDown(KeyCode.Q) && Cube1.GetComponent<MeshRenderer>().material.color == Color.white)
		{
            Cube1.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.W) && Cube2.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube2.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.E) && Cube3.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube3.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.A) && Cube4.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube4.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.S) && Cube5.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube5.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.D) && Cube6.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube6.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.Z) && Cube7.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube7.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.X) && Cube8.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube8.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
        if (Input.GetKeyDown(KeyCode.C) && Cube9.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            Cube9.GetComponent<MeshRenderer>().material.color = TurnColor;
            NextTurn();
        }
    }

    private void NextTurn()
	{
        ++Player;
        if (Player >= 3)
		{
            Player = 1;
		}
	}
    private void RedWin()
	{
        if (Cube1.GetComponent<MeshRenderer>().material.color == Color.red && Cube2.GetComponent<MeshRenderer>().material.color == Color.red)
		{

		}

    }
}
