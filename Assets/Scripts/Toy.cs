using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour,ICollectible
{

    public static event Action CollectToyEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Notify();
            Destroy(gameObject);
        }
    }

    public void Notify()
    {
        CollectToyEvent?.Invoke();
    }
}
