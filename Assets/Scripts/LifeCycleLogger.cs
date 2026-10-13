using UnityEngine;

public class LifeCycleLogger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Awake -> onEnable -> Start -> Update (nie, Start i Upate (1))

    // Awake i Start

    // Awake wykonalo sie | OnEnable, Start, Update - nie 

    // Start wywoluje sie gdy komponent jest wlaczony, Awake - przy tworzeni lub ladowaniu
    
    private bool isFirstUpdate = true;
    
    public void Awake()
    {
        Debug.Log($"Awake: {Time.frameCount}");
    }

    public void OnEnable()
    {
        Debug.Log($"OnEnable: {Time.frameCount}");
    }

    public void Start()
    {
        Debug.Log($"Start: {Time.frameCount}");
    }

    // Update is called once per frame
    public void Update()
    {
        if (isFirstUpdate)
        {
            Debug.Log($"Update: {Time.frameCount}");
            isFirstUpdate = false;
        }
    }

    public void OnDisable()
    {
        Debug.Log($"OnDisable: {Time.frameCount}");
        
    }

    public void OnDestroy()
    {
        Debug.Log($"OnDestroy: {Time.frameCount}");
    }
    
}
