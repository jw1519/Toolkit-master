using PhysicsPuzzle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraMaze : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject mazeCamera;
    public GameObject ui;
    public GameObject maze;
    public GameObject player;
    public GameObject mazeCanvas;

    // Start is called before the first frame update
    void Start()
    {
        mazeCamera.SetActive(false);
        maincamera.SetActive(true);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            mazeCamera.SetActive(true);
            maincamera.SetActive(false);
            ui.SetActive(false);
            maze.GetComponent<MazeController>().enabled = true;
            player.SetActive(false);
            mazeCanvas.SetActive(true);
        }
    }
}
