using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiFollow : MonoBehaviour
{
    private Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    private Vector3 GetRoamPos()
    {
        return startingPos + GetRandomDir() * Random.Range(10f,70f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Vector3 GetRandomDir()
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;
    }
}
