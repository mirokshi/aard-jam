using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paswordControl : MonoBehaviour
{
    public static Action onOpenDoor;
    public static Action onCloseDoor;
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
                onOpenDoor?.Invoke(); 
                print("correcte");
            }
            else
            {
                onCloseDoor?.Invoke();
                print("incorrecte");
            }
            borrar();
            num = 0;
        }
    }

    private void borrar()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
