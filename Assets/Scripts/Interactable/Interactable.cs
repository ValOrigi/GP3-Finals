using UnityEngine;
using TMPro;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] protected bool isInteracted;
    [SerializeField] protected TextMeshProUGUI Tooltips;

    protected virtual void OnCollisionEnter(Collision collision)
    {
        Tooltips.gameObject.SetActive(true);
        if (collision.gameObject.TryGetComponent<PlayerMovements>(out PlayerMovements player))
        {
            player.interactable = gameObject;
            player.isInteractable = true;
        }
    }
    protected virtual void OnCollisionExit(Collision collision)
    {
        Tooltips.gameObject.SetActive(false);
        if (collision.gameObject.TryGetComponent<PlayerMovements>(out PlayerMovements player))
        {
            player.interactable = null;
            player.isInteractable = false;
        }
    }

    public virtual void Interacted()
    {
        if (!isInteracted)
        {
            isInteracted = true;
            gameObject.SetActive(false);
        }
        else
        {
            isInteracted = false;
            gameObject.SetActive(true);
        }
    }
}
