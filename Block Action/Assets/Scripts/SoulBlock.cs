using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBlock : MonoBehaviour
{
    Vector3 prevMousePosition = new Vector3(0, 0, 0);
    public float selectedTime = 0;
    public bool placed;
    public bool mouseTouching;
    public int squareCount;
    public Collider2D blockCollider;
    public float relX;
    public float relY;

    //list of variables used for turn calculations
    public bool isAoe;
    public bool isSingleTarget;
    public bool isHeal;
    public int damage;
    public int heal;

    // Start is called before the first frame update
    void Start()
    {
        blockCollider = GetComponent<Collider2D>();
        //make sure at least 1 of these booleans are set
        isAoe = false;
        isSingleTarget = false;
        isHeal = false;
        //make sure damage or heal is set
        damage = 0;
        heal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        mouseTouching = true;
    }

    void OnMouseExit()
    {
        mouseTouching = false;    
    }
}
