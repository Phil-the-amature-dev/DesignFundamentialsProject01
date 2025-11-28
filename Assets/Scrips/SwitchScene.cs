using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SwitchScene : MonoBehaviour
{
    public UnityEvent nextScene;

    private void OnTriggerEnter()
    {
        nextScene.Invoke();
    }
}
