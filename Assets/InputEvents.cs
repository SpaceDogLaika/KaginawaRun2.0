using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvents : MonoBehaviour
{
    public static InputEvents current;

    void Awake()
    {
        current = this;
    }

    public event System.Action OnFreeTapEvent;
    public event System.Action OnTargetedTapEvent;

    public void FreeTap()
    {
        OnFreeTapEvent.Invoke();
    }

    public void TargetedTap()
    {
        OnTargetedTapEvent.Invoke();
    }

}
