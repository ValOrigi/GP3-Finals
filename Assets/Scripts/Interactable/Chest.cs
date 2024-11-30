using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chest : Interactable
{
    public List<Coin> coins;
    public GameObject coinParents;

    private void Awake()
    {
        Tooltips.text = "Press E to Open Chest";
    }

    public override void Interacted()
    {
        if (!isInteracted)
        {
            isInteracted = true;
            SpawnCoin();
            gameObject.SetActive(false);
        }
        else
        {
            isInteracted = false;
            gameObject.SetActive(true);
        }
    }
    public void SpawnCoin() 
    {
        int randomCoin = Random.Range(0, coins.Count);
        Instantiate(coins[randomCoin], transform.position, Quaternion.identity, coinParents.transform);
    }
}
