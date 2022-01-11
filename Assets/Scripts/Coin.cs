using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinCount _count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PhysicsMovement>(out PhysicsMovement player))
        {
            _count.OnCoinCollected();
            Destroy(this.gameObject);
        }
    }

    internal void Init(CoinCount coinCount)
    {
        _count = coinCount;
    }
}
