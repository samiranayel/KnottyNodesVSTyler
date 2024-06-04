using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public AudioSource backgroundMusic; // Reference to the AudioSource for background music
    public GameObject player; // Reference to the player

    private void Start()
    {
        // Ensure the video player is initially stopped
        videoPlayer.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            // Player entered the trigger area
            backgroundMusic.Pause(); // Pause the background music
            videoPlayer.Play(); // Play the video
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            // Player exited the trigger area
            videoPlayer.Stop(); // Stop the video
            backgroundMusic.Play(); // Resume the background music
        }
    }
}
