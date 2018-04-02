using UnityEngine;

public static class VectorExtensions
{
    public static Vector2 RandomVector2(Vector2 minVector, Vector2 maxVector)
    {
        return new Vector2(Random.Range(minVector.x, maxVector.x), Random.Range(minVector.y, maxVector.y));
    }

    public static Vector3 RandomVector3(float minVector, float maxVector)
    {
        return new Vector3(Random.Range(minVector, maxVector), Random.Range(minVector, maxVector), Random.Range(minVector, maxVector));
    }
}