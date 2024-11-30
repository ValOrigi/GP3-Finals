using UnityEngine;
using TMPro;

public class Door : Interactable
{
    private void Awake()
    {
        Tooltips.text = "Press E to Open Door";
    }
}
