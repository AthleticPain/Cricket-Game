using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    public Image ballButtonFrame;
    public Image batButtonFrame;
    public Image pitchButtonFrame;

    public Button[] ballButtons;
    public Button[] batButtons;
    public Button[] pitchButtons;

    public void MoveBallButtonFrameToButton(int index)
    {
        ballButtonFrame.transform.position = ballButtons[index].transform.position;
    }

    public void MoveBatButtonFrameToButton(int index)
    {
        batButtonFrame.transform.position = batButtons[index].transform.position;
    }

    public void MovePitchButtonFrameToButton(int index)
    {
        pitchButtonFrame.transform.position = pitchButtons[index].transform.position;
    }
}
