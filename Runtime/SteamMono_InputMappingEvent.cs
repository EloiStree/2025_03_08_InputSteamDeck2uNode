using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SteamMono_InputMappingEvent : MonoBehaviour
{
    public SteamDeckButtonsInput m_input;

    public void OnEnable()
    {
        m_input.OnEnable();
    }

    public void OnDisable()
    {
        m_input.OnDisable();
    }
}
