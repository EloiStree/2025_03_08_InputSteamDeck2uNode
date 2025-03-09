using System;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[System.Serializable]
public class SteamDeckButtonsInput : SteamDeckButtonsGeneric<InputActionButtonRefEvent>
{

    public void OnEnable()
    {
        m_sideButtonLeft.OnEnable();
        m_sideButtonRight.OnEnable();
        m_triggerButtonLeft.OnEnable();
        m_triggerButtonRight.OnEnable();
        m_yUpButton.OnEnable();
        m_bRightButton.OnEnable();
        m_aDownButton.OnEnable();
        m_xLeftButton.OnEnable();
        m_menuLeftButton.OnEnable();
        m_menuRightButton.OnEnable();
        m_backLeftTopButton.OnEnable();
        m_backLeftDownButton.OnEnable();
        m_backRightTopButton.OnEnable();
        m_backRightDownButton.OnEnable();
        m_dpadLeft.m_pressButton.OnEnable();
        m_dpadLeft.m_outer.OnEnable();
        m_dpadLeft.m_touchButton.OnEnable();
        m_dpadLeft.m_upButton.OnEnable();
        m_dpadLeft.m_rightButton.OnEnable();
        m_dpadLeft.m_downButton.OnEnable();
        m_dpadLeft.m_leftButton.OnEnable();

        m_dpadRight.m_pressButton.OnEnable();
        m_dpadRight.m_outer.OnEnable();
        m_dpadRight.m_touchButton.OnEnable();
        m_dpadRight.m_upButton.OnEnable();
        m_dpadRight.m_rightButton.OnEnable();
        m_dpadRight.m_downButton.OnEnable();
        m_dpadRight.m_leftButton.OnEnable();

        m_joystickLeft.m_pressButton.OnEnable();
        m_joystickLeft.m_outer.OnEnable();
        m_joystickLeft.m_touchButton.OnEnable();
        m_joystickLeft.m_upButton.OnEnable();
        m_joystickLeft.m_rightButton.OnEnable();
        m_joystickLeft.m_downButton.OnEnable();
        m_joystickLeft.m_leftButton.OnEnable();

        m_joystickRight.m_pressButton.OnEnable();
        m_joystickRight.m_outer.OnEnable();
        m_joystickRight.m_touchButton.OnEnable();
        m_joystickRight.m_upButton.OnEnable();
        m_joystickRight.m_rightButton.OnEnable();
        m_joystickRight.m_downButton.OnEnable();
        m_joystickRight.m_leftButton.OnEnable();

        m_arrows.m_upButton.OnEnable();
        m_arrows.m_rightButton.OnEnable();
        m_arrows.m_downButton.OnEnable();
        m_arrows.m_leftButton.OnEnable();



    }

    public void OnDisable()
    {
        m_sideButtonLeft.OnDisable();
        m_sideButtonRight.OnDisable();
        m_triggerButtonLeft.OnDisable();
        m_triggerButtonRight.OnDisable();
        m_yUpButton.OnDisable();
        m_bRightButton.OnDisable();
        m_aDownButton.OnDisable();
        m_xLeftButton.OnDisable();
        m_menuLeftButton.OnDisable();
        m_menuRightButton.OnDisable();
        m_backLeftTopButton.OnDisable();
        m_backLeftDownButton.OnDisable();
        m_backRightTopButton.OnDisable();
        m_backRightDownButton.OnDisable();
        
        
        m_dpadLeft.m_pressButton.OnDisable();
        m_dpadLeft.m_outer.OnDisable();
        m_dpadLeft.m_touchButton.OnDisable();
        m_dpadLeft.m_upButton.OnDisable();
        m_dpadLeft.m_rightButton.OnDisable();
        m_dpadLeft.m_downButton.OnDisable();
        m_dpadLeft.m_leftButton.OnDisable();

        m_dpadRight.m_pressButton.OnDisable();
        m_dpadRight.m_outer.OnDisable();
        m_dpadRight.m_touchButton.OnDisable();
        m_dpadRight.m_upButton.OnDisable();
        m_dpadRight.m_rightButton.OnDisable();
        m_dpadRight.m_downButton.OnDisable();
        m_dpadRight.m_leftButton.OnDisable();

        m_joystickLeft.m_pressButton.OnDisable();
        m_joystickLeft.m_outer.OnDisable();
        m_joystickLeft.m_touchButton.OnDisable();
        m_joystickLeft.m_upButton.OnDisable();
        m_joystickLeft.m_rightButton.OnDisable();
        m_joystickLeft.m_downButton.OnDisable();
        m_joystickLeft.m_leftButton.OnDisable();

        m_joystickRight.m_pressButton.OnDisable();
        m_joystickRight.m_outer.OnDisable();
        m_joystickRight.m_touchButton.OnDisable();
        m_joystickRight.m_upButton.OnDisable();
        m_joystickRight.m_rightButton.OnDisable();
        m_joystickRight.m_downButton.OnDisable();
        m_joystickRight.m_leftButton.OnDisable();

        m_arrows.m_upButton.OnDisable();
        m_arrows.m_rightButton.OnDisable();
        m_arrows.m_downButton.OnDisable();
        m_arrows.m_leftButton.OnDisable();

    }
}

[System.Serializable]
public class InputActionButtonRefEvent {

    public InputActionReference m_input;
    public UnityEvent<bool> m_onChanged;
    public UnityEvent m_onTrueChanged;
    public UnityEvent m_onFalseChanged;
    public bool m_value;


    public void OnEnable()
    {
        if (m_input == null)
        {
            return;
        }
        m_input.action.performed += OnPerformed;
        m_input.action.canceled += OnCanceled;
        m_input.action.started += OnStarted;
    }
    public void OnDisable()
    {
        if (m_input == null)
        {
            return;
        }
        m_input.action.performed -= OnPerformed;
        m_input.action.canceled -= OnCanceled;
        m_input.action.started -= OnStarted;
    }

    private void OnStarted(InputAction.CallbackContext context)
    {
        SetValue(context.ReadValue<float>() > 0.5f);
    }

    private void OnCanceled(InputAction.CallbackContext context)
    {
        SetValue(context.ReadValue<float>() > 0.5f);
    }

    private void OnPerformed(InputAction.CallbackContext context)
    {
        SetValue(context.ReadValue<float>() > 0.5f);
    }

    public void SetValue(bool value)
    {
        if (m_input == null)
        {
            return;
        }
        if (m_value != value)
        {
            m_value = value;
            m_onChanged.Invoke(value);
            if (value)
            {
                m_onTrueChanged.Invoke();
            }
            else
            {
                m_onFalseChanged.Invoke();
            }
        }
    }



}
