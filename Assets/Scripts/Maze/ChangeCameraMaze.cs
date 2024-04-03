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

    // Start is called before the first frame update
    void Start()
    {
        mazeCamera.SetActive(false);
        maincamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide");
        mazeCamera.SetActive(true);
        maincamera.SetActive(false);
        ui.SetActive(false);
        maze.GetComponent<MazeController>().enabled = true;
    }
}
