using PhysicsPuzzle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMaze : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject mazeCamera;
    public GameObject ui;
    public GameObject maze;
    public GameObject player;
    public GameObject mazeCanvas;


    public void Exit()
    {
        mazeCamera.SetActive(false);
        maincamera.SetActive(true);
        ui.SetActive(true);
        maze.GetComponent<MazeController>().enabled = false;
        player.SetActive(true);
        mazeCanvas.SetActive(false);
    }
}
