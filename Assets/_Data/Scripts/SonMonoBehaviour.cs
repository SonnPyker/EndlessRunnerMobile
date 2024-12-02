using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SonMonoBehaviour : MonoBehaviour
{
    protected bool isDone = false;
    protected virtual void Start()
    {
        this.LoadSingleton();
    }
    protected virtual void Update()
    {

    }
    protected virtual void FixedUpdate()
    {

    }
    protected virtual void OnEnable()
    {

    }
    protected virtual void OnDisable()
    {

    }
    protected virtual void Awake()
    {
        this.LoadValue();
        this.LoadComponent();
    }
    protected virtual void Reset()
    {
        this.LoadValue();
    }
    protected virtual void LoadValue()
    {
        Debug.Log("Value is loaded");
    }
    protected virtual void LoadComponent()
    {
        Debug.Log("Components is loaded");
    }
    protected virtual void LoadSingleton()
    {
        Debug.Log("Singleton is loaded");
    }
    
}
