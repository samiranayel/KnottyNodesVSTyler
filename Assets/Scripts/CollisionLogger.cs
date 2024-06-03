using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollisionLogger : MonoBehaviour
{
    public string sceneToLoad;
    public string targetTag;


/*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Debug.Log("##Collision detected with object of tag: " + targetTag);
        }
    }
    */

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            Debug.Log("##Trigger " + targetTag);
            StartCoroutine(LoadSceneAsync(sceneToLoad));
        }
    }

     private IEnumerator LoadSceneAsync(string sceneName)
    {
        Debug.Log("##LoadScene1");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
            Debug.Log("##LoadScene2");
        }
        Debug.Log("##LoadScene3");
    }
}
