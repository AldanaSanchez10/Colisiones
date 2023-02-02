using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    [SerializeField] GameObject Wall;

    [SerializeField] Transform[] newPositions;

    [SerializeField] private float tempo = 0f;
    [SerializeField] private float timeLimit = 2f;

    private void OnCollisionStay(Collision collision)
    {
        if (tempo >= timeLimit)
        {
            Destroy(Wall);
            MoveWall();
        }

        tempo += Time.deltaTime;
    }

    private void MoveWall()
    {
        GetPositions();
        Instantiate(newPositions[0], newPositions[0].position, newPositions[0].transform.rotation);
    }

    public Transform GetPositions()
    {
        return newPositions[Random.Range(0, newPositions.Length)];
    }
}
