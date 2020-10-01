using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : Collectable
{
    // Start is called before the first frame update
    void Start()
    {
        collectableName = "coin";
        description = "increse score by 10";
    }

    override public void Use()
    {
        player.GetComponent<playerManager>().ChangeScore(10);
        Destroy(this.gameObject);
    }
  
}
