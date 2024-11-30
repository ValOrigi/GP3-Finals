using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class CollectionController : MonoBehaviour
{
    public Spawn spawn;

    public bool isWin;

    public int points;
    public int coinsCollected;
    public int chestOpened;

    public TextMeshProUGUI scorePointsText;
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI chestText;
    public GameObject winPanel;

    private void Start()
    {
        spawn = GetComponent<Spawn>();
    }

    public void Collected(int pointsCollected)
    {
        points += pointsCollected;
        coinsCollected++;

        if (coinsCollected == spawn.spawnNum + 12)
        {
            isWin = true;
            winPanel.SetActive(true);
        }

        scorePointsText.text = "Score: " + points;
        coinsText.text = "Coins: " + coinsCollected;
    }
}