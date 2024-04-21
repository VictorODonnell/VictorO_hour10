using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            Light lightComponent = GetComponent<Light>();
            if (lightComponent != null)
            {
                lightComponent.enabled = false;
            }
            else
            {
                Debug.LogWarning("No Light component found on the game object: " + gameObject.name);
            }
            Destroy(collidedWith);
        }
    }
}
