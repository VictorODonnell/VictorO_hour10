using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float distanceBetweenLamps = 2.0f; // Adjust this value as needed

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the total length to span with the lamps
        float totalLength = distanceBetweenLamps * 9; // 9 Gaps between 10 lamps

        // Calculate the starting position based on the total length
        Vector3 startPosition = transform.position - new Vector3(totalLength / 2, 0, 0);

        // Loop to spawn 10 street lamps
        for (int i = 0; i < 10; i++)
        {
            // Calculate the position for the current lamp
            Vector3 lampPosition = startPosition + new Vector3(i * distanceBetweenLamps, 0, 0);

            // Instantiate the lamp at the calculated position
            Instantiate(prefab, lampPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
