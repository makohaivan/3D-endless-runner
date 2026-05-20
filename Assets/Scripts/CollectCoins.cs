using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    { 
        coinFX.Play();
        MasterInfo.coinCount += 1;
        this.gameObject.SetActive(true);
    }
    
}
