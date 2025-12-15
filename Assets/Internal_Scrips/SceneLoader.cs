using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    
}

