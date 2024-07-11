using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresurebox : ItemBase
{
    [SerializeField] int bonaspoint;

    public override void newitem()
    {
        clossha.itempoint(bonaspoint);
    }
    // Start is called before the first frame update

}
