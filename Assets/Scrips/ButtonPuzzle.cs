using Unity.VisualScripting;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isCompleted = false;
    public int buttonGoal;
    [HideInInspector]
    public int buttonNum = 0;
    public PuzzleDoorAnimationScript puzzleDoor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonNum >= buttonGoal)
        {
            puzzleDoor.Animate();
            enabled = false;
        }
    }
}
