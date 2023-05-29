using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float currentTime; // 현재의 시간
    private float maxTime; // 최대 시간 == 5분
    private float overTime;
    private bool timeOver; // timeover라는 것을 표현하기 위한 bool변수입니다.
    void Start()
    {
        currentTime = 0.0f;
        maxTime = 600.0f;
        overTime = 0.0f;
        timeOver = false;
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime) // 현재 시간이 5분(600초)이상이라면 timeOver를 true로 바꾸고, overTime을 증가시킨다.
        {
            timeOver = true; 
            overTime = currentTime - maxTime; // overTime은 현재 시간에서 맥스타임인 5분을 뺀 시간입니다.
        }
    }
}
