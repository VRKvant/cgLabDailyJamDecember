using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ToyCounter : MonoBehaviour
{
    [SerializeField] private Text toyCountText;

    private int toyCount = 0;

    public int ToyCount { get => toyCount; private set => toyCount = value; }

    private void Start()
    {
        toyCountText.text = ToyCount.ToString();
    }
    private void OnEnable()
    {
        Toy.CollectToyEvent += AddToy;
    }
    void AddToy()
    {
        ToyCount++;
        toyCountText.text = ToyCount.ToString();
    }

    private void OnDisable()
    {
        Toy.CollectToyEvent -= AddToy;
    }
}
