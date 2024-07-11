using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int HealHp;
    [SerializeField] int PowerupHealHp;
    GameObject gameDirecter;
    GameDirecter game;
    public void Start()
    {
        gameDirecter = GameObject.Find("GameDirecter");
        game = gameDirecter.GetComponent<GameDirecter>();
        heal();
        powerup();
        Destroy(gameObject);
    }
    public virtual void heal()
    {
        game.chengehp(HealHp);
    }
    public virtual void powerup()
    {
        game.chengehp(PowerupHealHp);
    }
    public virtual void newitem()
    {

    }
}
