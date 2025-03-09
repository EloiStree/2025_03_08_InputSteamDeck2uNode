using UnityEngine;

public class SteamMono_InputMappingImageDebugger : MonoBehaviour
{

    public SteamMono_InputMappingEvent m_source;
    public SteamDeckButtonsImage m_canvas;


    private void OnEnable()
    {

        if (m_source == null)
        {
            return;
        }
        if (m_canvas == null)
        {
            return;
        }

        Subscribe(m_source.m_input.m_aDownButton, m_canvas.m_aDownButton);
        Subscribe(m_source.m_input.m_yUpButton, m_canvas.m_yUpButton);
        Subscribe(m_source.m_input.m_xLeftButton, m_canvas.m_xLeftButton);
        Subscribe(m_source.m_input.m_bRightButton, m_canvas.m_bRightButton);
        Subscribe(m_source.m_input.m_menuLeftButton, m_canvas.m_menuLeftButton);
        Subscribe(m_source.m_input.m_menuRightButton, m_canvas.m_menuRightButton);
        Subscribe(m_source.m_input.m_backLeftTopButton, m_canvas.m_backLeftTopButton);
        Subscribe(m_source.m_input.m_backLeftDownButton, m_canvas.m_backLeftDownButton);
        Subscribe(m_source.m_input.m_backRightTopButton, m_canvas.m_backRightTopButton);
        Subscribe(m_source.m_input.m_backRightDownButton, m_canvas.m_backRightDownButton);
        Subscribe(m_source.m_input.m_sideButtonLeft, m_canvas.m_sideButtonLeft);
        Subscribe(m_source.m_input.m_sideButtonRight, m_canvas.m_sideButtonRight);
        Subscribe(m_source.m_input.m_triggerButtonLeft, m_canvas.m_triggerButtonLeft);
        Subscribe(m_source.m_input.m_triggerButtonRight, m_canvas.m_triggerButtonRight);
        Subscribe(m_source.m_input.m_dpadLeft.m_upButton, m_canvas.m_dpadLeft.m_upButton);
        Subscribe(m_source.m_input.m_dpadLeft.m_rightButton, m_canvas.m_dpadLeft.m_rightButton);
        Subscribe(m_source.m_input.m_dpadLeft.m_downButton, m_canvas.m_dpadLeft.m_downButton);
        Subscribe(m_source.m_input.m_dpadLeft.m_leftButton, m_canvas.m_dpadLeft.m_leftButton);
        Subscribe(m_source.m_input.m_dpadLeft.m_pressButton, m_canvas.m_dpadLeft.m_pressButton);
        Subscribe(m_source.m_input.m_dpadLeft.m_outer, m_canvas.m_dpadLeft.m_outer);
        Subscribe(m_source.m_input.m_dpadLeft.m_touchButton, m_canvas.m_dpadLeft.m_touchButton);
        Subscribe(m_source.m_input.m_dpadRight.m_upButton, m_canvas.m_dpadRight.m_upButton);
        Subscribe(m_source.m_input.m_dpadRight.m_rightButton, m_canvas.m_dpadRight.m_rightButton);
        Subscribe(m_source.m_input.m_dpadRight.m_downButton, m_canvas.m_dpadRight.m_downButton);
        Subscribe(m_source.m_input.m_dpadRight.m_leftButton, m_canvas.m_dpadRight.m_leftButton);
        Subscribe(m_source.m_input.m_dpadRight.m_pressButton, m_canvas.m_dpadRight.m_pressButton);
        Subscribe(m_source.m_input.m_dpadRight.m_outer, m_canvas.m_dpadRight.m_outer);
        Subscribe(m_source.m_input.m_dpadRight.m_touchButton, m_canvas.m_dpadRight.m_touchButton);
        Subscribe(m_source.m_input.m_joystickLeft.m_upButton, m_canvas.m_joystickLeft.m_upButton);
        Subscribe(m_source.m_input.m_joystickLeft.m_rightButton, m_canvas.m_joystickLeft.m_rightButton);
        Subscribe(m_source.m_input.m_joystickLeft.m_downButton, m_canvas.m_joystickLeft.m_downButton);
        Subscribe(m_source.m_input.m_joystickLeft.m_leftButton, m_canvas.m_joystickLeft.m_leftButton);
        Subscribe(m_source.m_input.m_joystickLeft.m_pressButton, m_canvas.m_joystickLeft.m_pressButton);
        Subscribe(m_source.m_input.m_joystickLeft.m_outer, m_canvas.m_joystickLeft.m_outer);
        Subscribe(m_source.m_input.m_joystickLeft.m_touchButton, m_canvas.m_joystickLeft.m_touchButton);
        Subscribe(m_source.m_input.m_joystickRight.m_upButton, m_canvas.m_joystickRight.m_upButton);
        Subscribe(m_source.m_input.m_joystickRight.m_rightButton, m_canvas.m_joystickRight.m_rightButton);
        Subscribe(m_source.m_input.m_joystickRight.m_downButton, m_canvas.m_joystickRight.m_downButton);
        Subscribe(m_source.m_input.m_joystickRight.m_leftButton, m_canvas.m_joystickRight.m_leftButton);
        Subscribe(m_source.m_input.m_joystickRight.m_pressButton, m_canvas.m_joystickRight.m_pressButton);
        Subscribe(m_source.m_input.m_joystickRight.m_outer, m_canvas.m_joystickRight.m_outer);
        Subscribe(m_source.m_input.m_joystickRight.m_touchButton, m_canvas.m_joystickRight.m_touchButton);

        Subscribe(m_source.m_input.m_arrows.m_upButton, m_canvas.m_arrows.m_upButton);
        Subscribe(m_source.m_input.m_arrows.m_rightButton, m_canvas.m_arrows.m_rightButton);
        Subscribe(m_source.m_input.m_arrows.m_downButton, m_canvas.m_arrows.m_downButton);
        Subscribe(m_source.m_input.m_arrows.m_leftButton, m_canvas.m_arrows.m_leftButton);
    }
    public float m_transparentce = 0.5f;
    public void Subscribe(InputActionButtonRefEvent input, UnityEngine.UI.Image image)
    {
        input.m_onChanged.AddListener((b) =>
        {
            image.color = b ? Color.green : Color.white;
            image.color = new Color(image.color.r, image.color.g, image.color.b, m_transparentce);
        });
    }
}
