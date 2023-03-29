using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;

    void Start()
    {
        // Select the PLAY button so it is ready to be pressed!
        playButton.Select();

        // Hide the mouse cursor
        Cursor.visible = false;

        // Prevent the cursor from exiting our game window
        Cursor.lockState = CursorLockMode.Confined;
    }
}
