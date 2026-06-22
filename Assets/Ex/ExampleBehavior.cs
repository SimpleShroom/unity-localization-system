using System;
using TMPro;
using UnityEngine;


public class ExampleBehavior : MonoBehaviour
{
    [SerializeField] private ScriptableEX config;

    private TMP_Text tmp;


    public float Speed10X => 10 * config.speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tmp = GetComponent<TMP_Text>();
        Debug.Log(tmp);
    }

    // Update is called once per frame
    void Update()
    {
        if (config.freeze) return;
        AddSpeed(config.speed);
    }

    private void AddSpeed(float speed)
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}