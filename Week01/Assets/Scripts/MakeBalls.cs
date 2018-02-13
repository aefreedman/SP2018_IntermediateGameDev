using UnityEngine;

public class MakeBalls : MonoBehaviour
{
    public GameObject BallPrefab;
    [Range(0, 1000)] public int HowManyBalls;

    private void Start()
    {
        for (var i = 0; i < HowManyBalls; i++)
        {
            Instantiate(
                BallPrefab,
                new Vector3(Random.Range(-HowManyBalls / 10, HowManyBalls / 10),
                    Random.Range(-HowManyBalls / 10, HowManyBalls / 10),
                    Random.Range(-HowManyBalls / 10, HowManyBalls / 10)),
                Quaternion.identity
            );
        }
    }

    private void Update()
    {
    }
}