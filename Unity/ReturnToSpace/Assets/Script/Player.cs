using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{

    public Animator playerAnimatior;

    //目标点的坐标
    private Vector3 mTargetPos;

    private void Start()
    {

    }
    public void Update()
    {
        //按下鼠标右键时
        if(Input.GetMouseButton(1))
        {
            //获取屏幕坐标
            Vector3 mScreenPos = Input.mousePosition;
            //定义射线
            Ray mRay = Camera.main.ScreenPointToRay(mScreenPos);
            RaycastHit mHit;
            //判断射线是否击中地面
            if(Physics.Raycast(mRay, out mHit))
            {
                //获取目标坐标
                mTargetPos = mHit.point;
            }
            //让主角朝目标坐标并向目标移动
            transform.LookAt(mTargetPos);
            PlayerMove(mTargetPos);
        }   

        if (Input.GetMouseButtonUp(1))
        {
            playerAnimatior.SetBool("walkF",false);
        }

    }

    public void PlayerMove(Vector3 mTargetPos)
    {
        playerAnimatior.SetBool("walkF", true);

        transform.Translate(Vector3.forward * 2f*Time.deltaTime);
    }    
    
    public void PlayerTurn( Vector3 mTargetPos)
    {
        ///右转
        ///if(newM.z>oldM.z)

    }
}
