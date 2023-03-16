using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Up, Down, Left, Right, Null
}

public static class Utilities
{
    public static IEnumerator Rotate(Transform transform)
    {
        float duration = 0.5f;

        for (int i = 0; i < 2; i++)
        {
            Quaternion startingRot = transform.rotation;
            Quaternion endingRot = transform.rotation;
            endingRot *= Quaternion.Euler(Vector3.up * 180);

            float elapsed = 0.0f;
            while (elapsed < duration)
            {
                transform.rotation = Quaternion.Slerp(startingRot, endingRot, elapsed / duration);
                elapsed += Time.deltaTime;
                yield return null;
            }

            transform.rotation = endingRot;
        }
    }

    public static Vector3 TargetPosition(Direction direction, Transform transform)
    {
        Vector3 position = transform.position;

        switch (direction)
        {
            case Direction.Up:
                position.z += 1;
                break;
            case Direction.Down:
                position.z -= 1;
                break;
            case Direction.Left:
                position.x -= 1;
                break;
            case Direction.Right:
                position.x += 1;
                break;
        }

        return position;
    }
}