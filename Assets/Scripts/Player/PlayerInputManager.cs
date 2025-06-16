using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    float xInput;
    float yInput;

    private void Update()
    {
        InputManager();     
    }
    void InputManager()
    {
        if(Input.GetKey(KeyCode.W))
        {
            yInput = 1;
        }
        else if(Input.GetKey(KeyCode.S))
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
        return new Vector2(xInput,yInput);
    }
}//Class
