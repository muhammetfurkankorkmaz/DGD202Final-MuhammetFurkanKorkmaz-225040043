using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    bool canTakeInput = true;

    float xInput;
    float yInput;
    private void Start()
    {
        GameController.Instance.onGameStart += GameStart;
        GameController.Instance.onGameEnd += GameEnd;
    }
    private void Update()
    {
        if (!canTakeInput) return;
        InputManager();
    }
    void GameStart()
    {
        canTakeInput = true;
    }
    void GameEnd()
    {
        xInput = 0;
        yInput = 0;
        canTakeInput = false;
    }
    void InputManager()
    {
        if (Input.GetKey(KeyCode.W))
        {
            yInput = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            yInput = -1;
        }
        else
        {
            yInput = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xInput = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xInput = -1;
        }
        else
        {
            xInput = 0;
        }
    }
    public Vector2 ReturnMovementVector()
    {
        return new Vector2(xInput, yInput);
    }
}//Class
