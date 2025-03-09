using UnityEngine;

[System.Serializable]
public class SteamDeckButtonsGeneric<T>
{
    [Header("Side Buttons")]
    public T m_sideButtonLeft;
    public T m_sideButtonRight;
    public T m_triggerButtonLeft;
    public T m_triggerButtonRight;

    [Header("Power Buttons")]
    public T m_yUpButton;
    public T m_bRightButton;
    public T m_aDownButton;
    public T m_xLeftButton;



    [Header("Menu")]
    public T m_menuLeftButton;
    public T m_menuRightButton;


    [Header("Back Buttons")]
    public T m_backLeftTopButton;
    public T m_backLeftDownButton;
    public T m_backRightTopButton;
    public T m_backRightDownButton;

    [Header("Arrow Buttons")]
    public InputActionDirection<T> m_arrows;

    [Header("Joystick Direction")]
    public InputActionDirectionWithTouch<T> m_dpadLeft;
    public InputActionDirectionWithTouch<T> m_dpadRight;
    public InputActionDirectionWithTouch<T> m_joystickLeft;
    public InputActionDirectionWithTouch<T> m_joystickRight;

}

[System.Serializable]
public class InputActionDirection<T>
{

    public T m_upButton;
    public T m_rightButton;
    public T m_downButton;
    public T m_leftButton;
}
[System.Serializable]
public class InputActionDirectionOuter<T> : InputActionDirection<T>
{
    public T m_pressButton;
    public T m_outer;
}
[System.Serializable]
public class InputActionDirectionWithTouch<T> : InputActionDirectionOuter<T>
{
    public T m_touchButton;
}