using UnityEngine;

namespace Instantiation
{
    public static class Instantiator
    {
        public static GameObject RandomRangeInstantiate(GameObject obj, Vector3 minPos, Vector3 maxPos)
        {
            return Object.Instantiate(obj, new Vector3(Random.Range(minPos.x, maxPos.x), Random.Range(minPos.y, maxPos.y), Random.Range(minPos.z, maxPos.z)), Quaternion.identity);
        }
    }
}