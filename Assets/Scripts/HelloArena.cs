using UnityEngine;

public class HelloArena : MonoBehaviour
{   
    
    public string PlayerName = "Viktor";
    public int PlayerHealth = 100;
    private float PlayerSpeed = 5.5f;
    bool EzMode = true;
    void Start()
    {
        Debug.Log($"Hello {PlayerName}, {PlayerHealth} health, {PlayerSpeed} Speed | Ezdifficulty: {EzMode} ");    
    }
    
}
