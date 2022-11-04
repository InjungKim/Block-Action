using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buff : Effect
{
    public double buff;
    public GameObject text = GameObject.Find("Output");

    public Buff(double buff) {
        this.buff = buff;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ActivateEffect(Fighter fighter)
    {
        foreach (Fighter f in targets)
        {
            BuffCounter bc = new BuffCounter(numTurns, buff);
            f.buffLeft.Add(bc);
            f.buff *= buff;
            // change back to Debug.Log later
            if (f.Equals(Player.player))
            {
                text.GetComponent<TMP_Text>().text += "Player buff set to " + f.buff + "x\n";
            }
            else
            {
                text.GetComponent<TMP_Text>().text += "Enemy buff set to " + f.buff + "x\n";
            }
        }
    }
}
