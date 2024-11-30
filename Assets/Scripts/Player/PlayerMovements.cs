using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovements : MonoBehaviour
{
    public CollectionController controller;
    
    public float speed;

    public bool isInteractable;
    public GameObject interactable;

    private void Start()
    {
        CollectionController controller = GetComponent<CollectionController>();
    }

    private void Update()
    {
        if (!controller.isWin)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(x, 0, z);

            transform.Translate(move * Time.deltaTime * speed);
        }

        if (isInteractable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (interactable.TryGetComponent<Chest>(out Chest chest))
                {
                    chest.Interacted();
                    controller.chestOpened++;
                    controller.chestText.text = "Chest: " + controller.chestOpened;
                }
                else if (interactable.TryGetComponent<Door>(out Door door))
                {
                    door.Interacted();
                }

                isInteractable = false;
                interactable = null;
            }
        }
    }
}
