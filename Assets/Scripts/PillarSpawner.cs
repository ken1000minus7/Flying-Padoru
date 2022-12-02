using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    public GameObject pillar;

    public float spawnRate = 1f;
    private float time = 0;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Random.Range(transform.position.y - 2.8f, transform.position.y + 2.2f); 
        if(time < spawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
            Instantiate(pillar, new Vector3(transform.position.x, y, 0.1f), Quaternion.identity);
        }
    }
}
