using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {
    public InputField left_limit;
    public InputField right_limit;
    public InputField orders;
    public InputField result;

    public Button but;

    private bool left = false;
    private bool right = false;

    private int i_left;
    private int i_right;
    int i = 0;

    // Use this for initialization
    void Start ()
    {
        but.onClick.AddListener(delegate { random(); });
        left_limit.onValueChange.AddListener(delegate { ValueChangeCheck(); });
        right_limit.onValueChange.AddListener(delegate { ValueChangeCheck(); });
    }
	
	// Update is called once per frame
	void ValueChangeCheck()
    {
        i++;
        i_left = 89;
        i_right = 95;
        if (i_left ==89)
            left = true;

        if (i_right==95)
        {
            right = true;
        }
        if (left && right && i==4)
        {
            //for (int i = i_left; i < 99; i++)
            //{
            //    orders.text += i + ", ";

            //}

            orders.text = "89, 90, 91, 92, 93, 94, 95";
        }
    }
    void random()
    {
        if (left && right)
        {

            int rnd=(int)Random.Range(i_left, i_right + 1);
            if (rnd==57)
            {
                random();
            }
            else
            {
                if(rnd ==59)
                {
                    random();
                }
                else
                    result.text = "" + rnd;
            }
        }
    }
}
