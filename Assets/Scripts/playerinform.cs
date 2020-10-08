using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinform : MonoBehaviour
{
    public int health;
    public int score;
    public List<Collectable> inventory;
    // Start is called before the first frame update

   
    void Start()
    {
        DontDestoryOnLoad(this.gameObject);
       
        foreach(Collectable item in info.inventory)
        (
            item.player = this.gameObject;
        )
    }
    
   
}
