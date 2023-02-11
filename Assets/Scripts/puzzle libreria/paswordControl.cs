using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paswordControl : MonoBehaviour
{
    private int num = 0;
    private int[] nums = new int [4];
    private void OnEnable()
    {
        num = 0;
        detectarClick.buttonCliked += control;
    }

    private void OnDisable()
    {
        detectarClick.buttonCliked -= control;
    }
    
    private void control(detectarClick obj)
    {
        nums[num] = obj.value;
        num++;
        if (num == 4)
        {
            if (nums[0] == 1 && nums[1] == 9 && nums[2] == 8 && nums[3] == 4)
            {
                print("correcte");
            }
            else
            {
                print("incorrecte");
            }

            num = 0;
        }
    }
    
}
