using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform _spawners;
    [SerializeField] private CoinCount _coinCount;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_spawners.childCount];

        for (int i = 0; i < _spawners.childCount; i++)
        {
            _points[i] = _spawners.GetChild(i);
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {       
        for (int i = 0; i < _points.Length; i++)
        {
            var spawnedCoin =  Instantiate(_coin, _points[i].position, Quaternion.identity);
            spawnedCoin.Init(_coinCount);
            yield return null;
        }
    }
}
