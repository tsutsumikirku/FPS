using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int HealHp;
    [SerializeField] int PowerupHealHp;
    [SerializeField] float deletetime;
    float time;
    GameObject gameDirecter;
    GameDirecter game;
    GameObject closs;
   public Crosshair clossha;
    public void Start()
    {
        gameDirecter = GameObject.Find("GameDirector");
        game = gameDirecter.GetComponent<GameDirecter>();
        closs = GameObject.Find("crosshair");
        clossha = closs.GetComponent<Crosshair>();

        
    }
    public void gene()
    {
        game.chengehp(HealHp);
        game.chengehp(PowerupHealHp);
        Destroy(gameObject);
    }
    public void Update()
    {
        time += Time.deltaTime;
        if(time > deletetime)
        {
            Destroy(gameObject);
        }
    }
    public virtual void newitem()
    {

    }
}
