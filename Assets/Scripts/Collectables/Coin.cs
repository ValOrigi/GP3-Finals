using UnityEngine;

public class Coin : MonoBehaviour
{
    public int givePoints;

    private void OnCollisionEnter(Collision collision)
    {
        if (GameObject.Find("Collector").TryGetComponent<CollectionController>(out CollectionController player))
        {
            player.Collected(givePoints);
            Destroy(gameObject);
        }
    }
}
