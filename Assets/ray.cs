using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{

    private const KeyCode key = KeyCode.B;
    private IEnumerator werewolf;

    IEnumerator Werewolves(float delay)
    {
        while (true)
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward)))
            {
                print("werewolves~");
            }
            yield return new WaitForSeconds(delay);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            werewolf = Werewolves(.1f);
            StartCoroutine(werewolf);
        }
        if (Input.GetKeyUp(key))
            StopCoroutine(werewolf);
    }
}