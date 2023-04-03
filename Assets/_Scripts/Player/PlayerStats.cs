
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float runinngSpeed = 10f;
    [SerializeField] private float jumpHeigth = 80f;
    [SerializeField] private int heals = 1;
    
    public float GetRunningSpeed(){
        return runinngSpeed;
    }

    public float GetJumpHeigth(){
        return jumpHeigth;
    }

    public void TakeRunningSpeed(){
        runinngSpeed = runinngSpeed * 1.2f;
    }
    
}
