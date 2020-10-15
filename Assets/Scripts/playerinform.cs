using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinform : MonoBehaviour
{
    public int health = 0;
    public int score = 100;
    public List<Collectable> inventory;
    // Start is called before the first frame update

   
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
       

    }
    
   
}
