using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// This handles the direction of the player through the mobile buttons.
///</summary>
public class MobileDirectionManager : MonoBehaviour
{
    
    #region Singleton

    private static MobileDirectionManager INSTANCE = null;

    private void Awake()
    {

        if (INSTANCE != null && INSTANCE != this)
        {
            Destroy(gameObject);
            return;
        }

        else
        {
            INSTANCE = this;
        }

        DontDestroyOnLoad(gameObject);
        print("Mobile Direction Manager INSTANCE created.");

    }

    #endregion

    private EnumDirection direction = EnumDirection.Up;

    // Sets the direction to "UP" when the Button Up is clicked. 
    public void SetUpDirectionButtonClicked() =>  direction = EnumDirection.Up;

    // Sets the direction to "DOWN" when the Button Down is clicked. 
    public void SetDownDirectionButtonClicked() =>  direction = EnumDirection.Down;

    // Sets the direction to "LEFT" when the Button Left is clicked. 
    public void SetLeftDirectionButtonClicked() =>  direction = EnumDirection.Left;

    // Sets the direction to "LEFT" when the Button Right is clicked. 
    public void SetRightDirectionButtonClicked() =>  direction = EnumDirection.Right;

    // Returns the direction of the button when clicked. Else, returns an up direction.
    public static EnumDirection GetDirectionButtonClicked()
    {
        return (INSTANCE == null) ? EnumDirection.Up : INSTANCE.direction;
    }

}

// The enumerator for the directions available in swiping. 
public enum EnumDirection
{
    Up = 0,
    Down = 1, 
    Left = 2, 
    Right = 3,
}